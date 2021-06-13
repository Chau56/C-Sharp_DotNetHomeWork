using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Hashtable urls = new Hashtable();
        private int count = 0;
        private Task[] tk = new Task[3];

        // 显示数组
        private List<string> rightUrls = new List<string>();
        private List<string> falseUrls = new List<string>();

        public string CertainWebsite { get; private set; }

        public void Crawl()
        {
            //Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)   // 找到一个还没有下载过的链接
                {
                    if ((bool)urls[url]) continue;  // 已经下载过的，不再下载
                    current = url;
                }

                if (current == null || count > 10) break;

                // 只有当爬取的是html/aspx/jsp等网页时，才解析并爬取下一级URL
                if (!(current.Contains(".html") || current.Contains(".aspx") || current.Contains("jsp") || count <= 1))
                {
                    urls[current] = true;
                    continue;
                }

                //Console.WriteLine("爬行" + current + "页面!");
                string html = DownLoad(current);    // 下载
                urls[current] = true;
                count++;
                Parse(html, current);                        // 解析,并加入新的链接
                //Console.WriteLine("爬行结束");
                rightUrls.Add(current);
            }
            Console.WriteLine("全部爬行结束");
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + ":" + url);
                return "";
            }
        }

        public static bool certainUrl(string a)
        {
            try
            {
                string Url = @"^http://([\w-]+\.)+[\w-]+(/[\w-./?%&=]*)?$";
                return Regex.IsMatch(a, Url);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void Parse(string html, string currentUrl)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');

                // 只爬取某个指定网站上的网页
                if (!certainUrl(strRef))
                {
                    continue;
                }

                // 相对地址(test/page.html, ./test/page.html, ../test2/page2.html, /test3/page.html)转成完整地址进行爬取
                if (strRef.Contains(".."))
                {
                    if (currentUrl.EndsWith(@"/"))
                    {
                        strRef = currentUrl + strRef.Replace("..", "");
                    }
                    else
                    {
                        strRef = currentUrl.Substring(0, currentUrl.LastIndexOf('/') + 1) + strRef.Replace("..", "");
                    }
                }

                if (strRef.Length == 0) continue;
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }

        private void begin_Click(object sender, EventArgs e)
        {
            urls.Add(InitURL.Text, false);

            tk[0] = new Task(Crawl);
            tk[1] = new Task(Crawl);
            tk[0].RunSynchronously();
            tk[1].RunSynchronously();

            Crawl();
            rightListBox.DataSource = rightUrls;
            falseListBox.DataSource = falseUrls;
        }

    }
}

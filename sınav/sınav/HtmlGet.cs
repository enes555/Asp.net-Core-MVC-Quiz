using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace sınav
{
    public class HtmlGet
    {
        private string GetHtml(string urlAddress)
        {
            Uri url = new Uri(urlAddress);
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;

            string html = client.DownloadString(url);
            return html;
        }
        /*
        public string Title()
        {
           

            for (int i = 0; i < 5; i++)
            {
               
                string htmlContent = GetHtml(GetPageLink()[i].ToString());
                HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
                document.LoadHtml(htmlContent);

            
                var title = document.DocumentNode;
                if (document.DocumentNode.SelectSingleNode("//*[@id='articleTitleFull']") != null)
                    title = document.DocumentNode.SelectSingleNode("//*[@id='articleTitleFull']");
                else
                    title = document.DocumentNode.SelectSingleNode("//*[@id='articleTitle']");

         

                var text = document.DocumentNode;
                if (document.DocumentNode.SelectSingleNode("//*[@id='app-root']/div/div[3]/div/div[4]/div/div[2]/main/article/div/p[1]") != null)
                    text = document.DocumentNode.SelectSingleNode("//*[@id='app-root']/div/div[3]/div/div[4]/div/div[2]/main/article/div/p[1]");
                else if (document.DocumentNode.SelectSingleNode("//*[@id='app-root']/div/div[3]/div/div[3]/div[2]/div/main/article/div[1]/section[1]/p[4]") != null)
                    text = document.DocumentNode.SelectSingleNode("//*[@id='app-root']/div/div[3]/div/div[3]/div[2]/div/main/article/div[1]/section[1]/p[4]");
                else
                    text = document.DocumentNode.SelectSingleNode("//*[@id='app-root']/div/div[3]/div/div[3]/div[2]/div/main/article/div/p[1]");

             
            }

        }*/


        private string Xpath(int pageID)
        {
            string pageXPath = "";

            switch (pageID)
            {
                case 1:
                    pageXPath = "//*[@id='app-root']/div/div/div/div/div/div/div/div/div/div/div/div[1]/a[2]";
                    break;
                case 2:
                    pageXPath = "//*[@id='app-root']/div/div/div/div/div/div/div/div/div/div/div/div[1]/a";
                    break;
                case 3:
                    pageXPath = "//*[@id='app-root']/div/div/div/div/div/div/div/div/div/div/div/div[2]/a";
                    break;
                case 4:
                    pageXPath = "//*[@id='app-root']/div/div/div/div/div/div/div/div/div/div/div/div[3]/a[3]";
                    break;
                case 5:
                    pageXPath = "//*[@id='app-root']/div/div/div/div/div/div/div/div/div/div/div/div[4]/a";
                    break;
                default:
                    break;
            }

            return pageXPath;
        }/*
        private List<string> GetPageLink()
        {
            List<string> links = new List<string>();
            string url = "https://www.wired.com";

            string htmlContent = GetHtmlContent(url);

            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(htmlContent);

            for (int i = 1; i < 6; i++)
            {
                var node = document.DocumentNode.SelectSingleNode(Xpath(i));
                links.Add(url + node.Attributes[0].DeEntitizeValue)
            }
            return links;
        }

        */
    }
}

using HtmlAgilityPack;
using ScrapySharp.Extensions;
using ScrapySharp.Network;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUIWebScraper.Modules
{
    public class Node
    {
        public const string uriString = "https://www.cvonline.lt/darbo-skelbimai/informacines-technologijos";
        public const string cssString = ".cvo_module_offer h2 a";
        public const string fileDir = "..\\..\\..\\Results.txt";

        public static void NodeCycle(List<HtmlNode> nodes)
        {
            using (var fr = File.AppendText(fileDir))
            {               
                foreach (var node in nodes)
                {
                    Console.OutputEncoding = Encoding.UTF8;
                    Console.WriteLine(node.InnerText);
                    fr.WriteLine(node.InnerText);
                }
            }
        }

        public static void PrintAllNodesToConsoleAndFile(ScrapingBrowser browser)
        {
            DeleteIfFIleExists();

            WebPage homepage = browser.NavigateToPage(new Uri(uriString));
            var html = homepage.Html;
            var nodes = html.CssSelect(cssString).ToList();
            NodeCycle(nodes);
        }

        public static void DeleteIfFIleExists()
        {
            if (File.Exists(fileDir))
                File.Delete(fileDir);
        }
    }
}

using ConsoleUIWebScraper.Modules;
using ScrapySharp.Extensions;
using ScrapySharp.Network;
using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleUIWebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            var browser = Factory.GetScrapingBrowser();
            Node.PrintAllNodesToConsoleAndFile(browser);         
        }
    }
}

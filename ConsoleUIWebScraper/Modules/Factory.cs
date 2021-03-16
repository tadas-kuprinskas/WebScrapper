using ScrapySharp.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUIWebScraper.Modules
{
    public class Factory
    {
        public static ScrapingBrowser GetScrapingBrowser() 
        {
            return new ScrapingBrowser() { Encoding = Encoding.UTF8 };
        }
    }
}

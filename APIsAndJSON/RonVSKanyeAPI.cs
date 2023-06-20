using Microsoft.VisualBasic;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace APIsAndJSON
{
    //public class RonVSKanyeAPI
    //{
//        /public static void Kanye()
//        {
//            var client = new HttpClient();
//            var KanyeURL = "https://api.kanye.rest";
//            var KanyeResponse = client.GetStringAsync(KanyeURL).Result;
//            var kanyeQuote = JObject.Parse(KanyeResponse).GetValue("quote").ToString();
            
//            Console.WriteLine($"Kanye: '{kanyeQuote}'");

//        }
//        public static void Ron()
//        {
//            var client = new HttpClient();
//            var RonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
//            var RonResponse = client.GetStringAsync(RonURL).Result;
//            var ronQuote = JArray.Parse(RonResponse);
            
//            Console.WriteLine($"Ron:'{ronQuote[0]}'");
//        }
//    }
}

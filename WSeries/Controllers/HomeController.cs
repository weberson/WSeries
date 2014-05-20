using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WSeries.Core.Data;
using WSeries.Core.Model;

namespace WSeries.Controllers
{
    public class HomeController : Controller
    {
        private IWSeriesContext _wSeriesContext;

        public HomeController() 
        { }

        public async Task<ActionResult> Index()
        {
            List<Show> model = new List<Show>();
            using (var client = new HttpClient())
            {
                var url = string.Format("{0}{1}", ConfigurationManager.AppSettings["ApiUrl"], "/Api/Shows");
                var result = await client.GetAsync(url);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    model = JsonConvert.DeserializeObject<List<Show>>(content);
                }
            }

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using GearsStore.Models;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using GearsStore.ViewModels;
using System.Data.Entity;
using System.Runtime.InteropServices;

namespace GearsStore.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public async Task<ActionResult> Index()
        {
            
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44345/api/");

                //HTTP GET
                var getTask = client.GetAsync("Games");
                getTask.Wait();

                var getResult = getTask.Result;
                //System.Diagnostics.Debug.WriteLine(postresult);
                if (getResult.IsSuccessStatusCode)
                {
                    var temp = await getResult.Content.ReadAsStringAsync();
                    //JObject obj = JObject.Parse(temp);
                    var gameList = JsonConvert.DeserializeObject<List<Game>>(temp);
                    //List<Game> gameList = result;

                    var gameViewModel = new GameViewModel
                    {
                        GameList = gameList
                    };

                    //string name = (string)obj["GameName"];
                    System.Diagnostics.Debug.WriteLine(temp);
                    if (User.IsInRole("CanManageGames"))
                    {
                        return View(gameViewModel);
                    }
                    return View("ReadOnlyIndex",gameViewModel);
                    //var existingGames = await getResult.Content.ReadAsAsync<IQueryable<Game>>();
                    //System.Diagnostics.Debug.WriteLine(existingGames.GetType());
                }
                
            }
            
            /*var games=new GameViewModel
            {
                GameList=
            }*/
            return View();
        }

        [Authorize]// to view the recommend page requires a login first
        public ActionResult MyRecommendations()
        {
            ViewBag.Message = "My Daily Recommendations.";

            return View();
        }
        [Authorize]// to view the profile page requires a login first
        public ActionResult profile()
        {
            ViewBag.Message = "My Profile.";

            return View();
        }
    }
}
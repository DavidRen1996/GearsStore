using GearsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GearsStore.ViewModels
{
    public class GameViewModel
    {
        public List<Game> GameList { get; set; }
        public Game game { get; set; }
        public HttpPostedFileBase InputFile { get; set; }
    }
}
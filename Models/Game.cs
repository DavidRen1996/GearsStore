using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GearsStore.Models
{
    public class Game
    {
        public int Id { get; set; }
        public List<String> GameType { get; set; }
        public String GameName { get; set; }
        public float GamePrice { get; set; }
        public String GameReleasedDate { get; set; }
        public String GameDescription { get; set; }
        public String GameVideoLink { get; set; }
        public String GameSnapshotLink { get; set; }
        public List<String> GameReviews { get; set; }
    }
}
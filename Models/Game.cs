using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.IO;
namespace GearsStore.Models
{
    public class Game
    {
        public int Id { get; set; }
        public List<String> GameType { get; set; }
        //[Required]
        public String GameName { get; set; }
        //[Required]
        public float GamePrice { get; set; }
        public String GameReleasedDate { get; set; }
        public String GameDescription { get; set; }
        public String GameVideoLink { get; set; }
        //[Required]
        
        public String GameSnapshotLink { get; set; }
        public List<String> GameReviews { get; set; }
    }
}
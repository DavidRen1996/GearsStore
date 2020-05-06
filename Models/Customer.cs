using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GearsStore.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public bool ExternalRegister { get; set; }
        public String EmailAddress { get; set; }
        public String Birthday { get; set; }
        public String UserName { get; set; }
        public List<Game> Chart { get; set; }
        public List<Game> OwnedGames { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChatterPairProgramming.Models
{
    public class Follower
    {
       
        public int Id { get; set; }
        public ICollection<UserInfo> Followers { get; set; }
        public ICollection<UserInfo> Following { get; set; }

    }
}
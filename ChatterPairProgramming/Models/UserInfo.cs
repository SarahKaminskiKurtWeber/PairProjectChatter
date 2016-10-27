using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ChatterPairProgramming.Models
{
    public class UserInfo
    {
        [Key]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        

        [ForeignKey("Follower")]
        public int FollowerID { get; set; }
        public virtual Follower Followers { get; set; }
        public virtual Follower Following { get; set; }
    }
}
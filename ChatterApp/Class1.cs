using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChatterApp
{
    public class Class1
    {
        [Key]
        public int ChatterID { get; set; }
        [Display]
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userName { get; set; }
        public string chat { get; set; }
        public DateTime time { get; set; }


    }
}
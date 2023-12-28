using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SinglePageTask.DB.Models
{
    public class Products_Service_Tbl
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ServiceName { get; set; }
        [Required]
        public string Unit { get; set; }
    }
}
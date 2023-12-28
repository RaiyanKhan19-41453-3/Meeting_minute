using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SinglePageTask.DB.Models
{
    public class Meeting_Minutes_Details_Tbl
    {
        [Key]
        public int Id { get; set; }
        public int SL { get; set; }
        public string ProductService { get; set; }
        public string Unit { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("meetingId")]
        public int meetId { get; set; }

        public virtual Meeting_Minutes_Master_Tbl meetingId { get; set; }
    }
}
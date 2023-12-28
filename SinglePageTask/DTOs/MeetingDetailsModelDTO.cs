using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SinglePageTask.DTOs
{
    public class MeetingDetailsModelDTO
    {
        public int SL { get; set; }
        public string ProductService { get; set; }
        public string Unit { get; set; }
        [RegularExpression(@"^[0-9]+$")]
        public int Quantity { get; set; }
    }
}
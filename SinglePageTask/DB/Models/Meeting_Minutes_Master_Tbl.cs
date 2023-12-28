using SinglePageTask.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SinglePageTask.DB.Models
{
    public class Meeting_Minutes_Master_Tbl
    {
        [Key]
        public int Id { get; set; }
        public string CustomerType { get; set; }
        public string CustomerName { get; set; }
        public string MeetingAgenda { get; set; }
        public string MeetingDate { get; set; }
        public string MeetingDiscussion { get; set; }
        public string AttendsFromClientSide { get; set; }
        public string MeetingDecision { get; set; }
        public string AttendsFromHostSide { get; set; }

        public virtual ICollection<Meeting_Minutes_Details_Tbl> MeetingDetails { get; set; }

        public Meeting_Minutes_Master_Tbl()
        {
            MeetingDetails = new List<Meeting_Minutes_Details_Tbl>();
        }
    }
}
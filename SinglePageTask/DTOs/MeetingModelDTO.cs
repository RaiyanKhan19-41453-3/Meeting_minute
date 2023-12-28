using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinglePageTask.DTOs
{
    public class MeetingModelDTO
    {
        public string CustomerType { get; set; }
        public string CustomerName { get; set; }
        public string MeetingAgenda { get; set; }
        public DateTime MeetingDate { get; set; }
        public string MeetingDiscussion { get; set; }
        public string AttendsFromClientSide { get; set; }
        public string MeetingDecision { get; set; }
        public string AttendsFromHostSide { get; set; }

        public List<MeetingDetailsModelDTO> MeetingDetails { get; set; }
    }
}
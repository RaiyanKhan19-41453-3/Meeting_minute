using SinglePageTask.DB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SinglePageTask.DB
{
    public class MeetingDBContext: DbContext
    {
        public DbSet<Corporate_Customer_Tbl> CorporateCustomers { get; set; }
        public DbSet<Individual_Customer_Tbl> individualCustomers { get; set; }
        public DbSet<Products_Service_Tbl> products { get; set; }
        public DbSet<Meeting_Minutes_Master_Tbl> meetingMinutes { get; set; }
        public DbSet<Meeting_Minutes_Details_Tbl> meetingMinutesDetails { get; set; }
    }
}
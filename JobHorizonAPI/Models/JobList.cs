//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JobHorizonAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class JobList
    {
        public JobList()
        {
            this.BidLists = new HashSet<BidList>();
            this.JobHistories = new HashSet<JobHistory>();
        }
    
        public int JobId { get; set; }
        public int PostedBy { get; set; }
        public string Status { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Budget { get; set; }
        public string JobType { get; set; }
        public List<Links> Links = new List<Links>();

        public virtual ICollection<BidList> BidLists { get; set; }
        public virtual ICollection<JobHistory> JobHistories { get; set; }
        public virtual User User { get; set; }
    }
}

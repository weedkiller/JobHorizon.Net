﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class JobHorizonContext : DbContext
    {
        public JobHorizonContext()
            : base("name=JobHorizonContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BidList> BidLists { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Forum> Fora { get; set; }
        public DbSet<JobHistory> JobHistories { get; set; }
        public DbSet<JobList> JobLists { get; set; }
        public DbSet<Messege> Messeges { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoviesProjectMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MoviesEntities3 : DbContext
    {
        public MoviesEntities3()
            : base("name=MoviesEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<actor> actor { get; set; }
        public virtual DbSet<category> category { get; set; }
        public virtual DbSet<comments> comments { get; set; }
        public virtual DbSet<customer> customer { get; set; }
        public virtual DbSet<director> director { get; set; }
        public virtual DbSet<movie> movie { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<rating> rating { get; set; }
    }
}

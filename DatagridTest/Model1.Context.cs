﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatagridTest
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PrjDbEntities : DbContext
    {
        public PrjDbEntities()
            : base("name=PrjDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GameScore> GameScore { get; set; }
        public virtual DbSet<ScoreBoard> ScoreBoard { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}

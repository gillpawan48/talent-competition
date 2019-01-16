﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Talent.Data.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TalentEntities : DbContext
    {
        public TalentEntities()
            : base("name=TalentEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AddressLocation> AddressLocations { get; set; }
        public virtual DbSet<AvailableDay> AvailableDays { get; set; }
        public virtual DbSet<AvailableDays_2> AvailableDays_2 { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<LogEntry> LogEntries { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PersonAddress> PersonAddresses { get; set; }
        public virtual DbSet<PersonAvailability> PersonAvailabilities { get; set; }
        public virtual DbSet<PersonContact> PersonContacts { get; set; }
        public virtual DbSet<PersonDescription> PersonDescriptions { get; set; }
        public virtual DbSet<PersonDocument> PersonDocuments { get; set; }
        public virtual DbSet<PersonEducation> PersonEducations { get; set; }
        public virtual DbSet<PersonLanguage> PersonLanguages { get; set; }
        public virtual DbSet<PersonPhoto> PersonPhotoes { get; set; }
        public virtual DbSet<PersonService> PersonServices { get; set; }
        public virtual DbSet<PersonServiceTag> PersonServiceTags { get; set; }
        public virtual DbSet<PersonSkill> PersonSkills { get; set; }
        public virtual DbSet<PersonSkillListing> PersonSkillListings { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<ServiceCategory> ServiceCategories { get; set; }
        public virtual DbSet<SkillTag> SkillTags { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}

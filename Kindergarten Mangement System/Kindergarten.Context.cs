﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kindergarten_Mangement_System
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Kindergarten_Mangement_SystemEntities : DbContext
    {
        public Kindergarten_Mangement_SystemEntities()
            : base("name=Kindergarten_Mangement_SystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bond> Bonds { get; set; }
        public virtual DbSet<Bus> Buses { get; set; }
        public virtual DbSet<Classes_schedule> Classes_schedule { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Guadian> Guadians { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Level> Levels { get; set; }
        public virtual DbSet<Password> Passwords { get; set; }
        public virtual DbSet<Semester_works> Semester_works { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
    }
}
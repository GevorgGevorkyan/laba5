﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace laba5
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class labaEntities : DbContext
    {
        public labaEntities()
            : base("name=labaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Orders_Scooters> Orders_Scooters { get; set; }
        public virtual DbSet<Payment_Method> Payment_Method { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<Providers> Providers { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Scooters> Scooters { get; set; }
        public virtual DbSet<Scooters_Types> Scooters_Types { get; set; }
        public virtual DbSet<Storages> Storages { get; set; }
    }
}

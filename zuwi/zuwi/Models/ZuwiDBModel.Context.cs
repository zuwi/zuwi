﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zuwi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ZuwiDBModelContainer : DbContext
    {
        public ZuwiDBModelContainer()
            : base("name=ZuwiDBModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RequiredWidgetKey> RequiredWidgetKeys { get; set; }
        public virtual DbSet<Site> Sites { get; set; }
        public virtual DbSet<WidgetData> WidgetDatas { get; set; }
        public virtual DbSet<Widget> Widgets { get; set; }
    }
}

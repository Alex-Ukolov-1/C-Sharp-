﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace diagramms
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class аква_паркEntities : DbContext
    {
        public аква_паркEntities()
            : base("name=аква_паркEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Билет> Билет { get; set; }
        public virtual DbSet<дата_найма> дата_найма { get; set; }
        public virtual DbSet<Заказ> Заказ { get; set; }
        public virtual DbSet<Клиент> Клиент { get; set; }
        public virtual DbSet<Оплата_труда> Оплата_труда { get; set; }
        public virtual DbSet<Сотрудники> Сотрудники { get; set; }
    }
}
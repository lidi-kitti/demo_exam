﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proga.БД
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DataBaseEntities : DbContext
    {
        public DataBaseEntities()
            : base("name=DataBaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Заявка> Заявка { get; set; }
        public virtual DbSet<Комментарий> Комментарий { get; set; }
        public virtual DbSet<Оборудование> Оборудование { get; set; }
        public virtual DbSet<Пользователь> Пользователь { get; set; }
        public virtual DbSet<Роль> Роль { get; set; }
        public virtual DbSet<Статус> Статус { get; set; }
    }
}

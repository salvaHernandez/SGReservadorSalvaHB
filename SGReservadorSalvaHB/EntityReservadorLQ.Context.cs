﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SGReservadorSalvaHB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class reservadorEntitiesLQ : DbContext
    {
        public reservadorEntitiesLQ()
            : base("name=reservadorEntitiesLQ")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AULAS> AULAS { get; set; }
        public virtual DbSet<PERFILES> PERFILES { get; set; }
        public virtual DbSet<RESERVAS> RESERVAS { get; set; }
        public virtual DbSet<USUARIOS> USUARIOS { get; set; }
    }
}

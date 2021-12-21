﻿using JsaCqrsApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JsaCqrsApi.Infrastructure.Context
{
    public class ApplicationContext : DbContext, IApplicationContext
    {
       
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<SourceType> SourceTypes { get; set; }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
                .Property(p => p.BuyingPrice)
                .HasColumnType("decimal(18,4)");
            modelBuilder.Entity<Product>()
                .Property(p => p.Rate)
                .HasColumnType("decimal(18,4)");

            modelBuilder.Entity<SourceType>(entity =>
            {
                entity.HasKey(e => e.StId)
                    .HasName("PK__st_Id");

                entity.ToTable("SourceType");

                entity.Property(e => e.StId)
                    .ValueGeneratedNever()
                    .HasColumnName("st_ID");

                entity.Property(e => e.StType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("st_Type");

                entity.Property(e => e.StTypeName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("st_TypeName");
            });

        }
    }
}

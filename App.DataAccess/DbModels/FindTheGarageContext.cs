﻿using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace App.DataAccess.DbModels
{
    public partial class FindTheGarageContext : IdentityDbContext<Identity.AspNetUsers, Identity.AspNetRoles, Guid>
    {
        public FindTheGarageContext()
        {
        }

        public FindTheGarageContext(DbContextOptions<FindTheGarageContext> options)
            : base(options)
        {
        }

        //public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        //public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        //public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        //public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        //public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        //public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        //public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<PortalTypes> PortalTypes { get; set; }
        public virtual DbSet<RefreshToken> RefreshToken { get; set; }
        public virtual DbSet<TestTable> TestTable { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

        //    //modelBuilder.Entity<AspNetRoleClaims>(entity =>
        //    //{
        //    //    entity.HasIndex(e => e.RoleId);

        //    //    entity.HasOne(d => d.Role)
        //    //        .WithMany(p => p.AspNetRoleClaims)
        //    //        .HasForeignKey(d => d.RoleId);
        //    //});

        //    //modelBuilder.Entity<AspNetRoles>(entity =>
        //    //{
        //    //    entity.HasIndex(e => e.NormalizedName)
        //    //        .HasName("RoleNameIndex")
        //    //        .IsUnique()
        //    //        .HasFilter("([NormalizedName] IS NOT NULL)");

        //    //    entity.Property(e => e.Id).ValueGeneratedNever();

        //    //    entity.Property(e => e.Name).HasMaxLength(256);

        //    //    entity.Property(e => e.NormalizedName).HasMaxLength(256);
        //    //});

        //    //modelBuilder.Entity<AspNetUserClaims>(entity =>
        //    //{
        //    //    entity.HasIndex(e => e.UserId);

        //    //    entity.HasOne(d => d.User)
        //    //        .WithMany(p => p.AspNetUserClaims)
        //    //        .HasForeignKey(d => d.UserId);
        //    //});

        //    //modelBuilder.Entity<AspNetUserLogins>(entity =>
        //    //{
        //    //    entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

        //    //    entity.HasIndex(e => e.UserId);

        //    //    entity.HasOne(d => d.User)
        //    //        .WithMany(p => p.AspNetUserLogins)
        //    //        .HasForeignKey(d => d.UserId);
        //    //});

        //    //modelBuilder.Entity<AspNetUserRoles>(entity =>
        //    //{
        //    //    entity.HasKey(e => new { e.UserId, e.RoleId });

        //    //    entity.HasIndex(e => e.RoleId);

        //    //    entity.HasOne(d => d.Role)
        //    //        .WithMany(p => p.AspNetUserRoles)
        //    //        .HasForeignKey(d => d.RoleId);

        //    //    entity.HasOne(d => d.User)
        //    //        .WithMany(p => p.AspNetUserRoles)
        //    //        .HasForeignKey(d => d.UserId);
        //    //});

        //    //modelBuilder.Entity<AspNetUserTokens>(entity =>
        //    //{
        //    //    entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

        //    //    entity.HasOne(d => d.User)
        //    //        .WithMany(p => p.AspNetUserTokens)
        //    //        .HasForeignKey(d => d.UserId);
        //    //});

        //    //modelBuilder.Entity<AspNetUsers>(entity =>
        //    //{
        //    //    entity.HasIndex(e => e.NormalizedEmail)
        //    //        .HasName("EmailIndex");

        //    //    entity.HasIndex(e => e.NormalizedUserName)
        //    //        .HasName("UserNameIndex")
        //    //        .IsUnique()
        //    //        .HasFilter("([NormalizedUserName] IS NOT NULL)");

        //    //    entity.Property(e => e.Id).ValueGeneratedNever();

        //    //    entity.Property(e => e.Email).HasMaxLength(256);

        //    //    entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

        //    //    entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

        //    //    entity.Property(e => e.UserName).HasMaxLength(256);
        //    //});

        //    modelBuilder.Entity<PortalTypes>(entity =>
        //    {
        //        entity.Property(e => e.PortalType).HasMaxLength(50);
        //    });

        //    modelBuilder.Entity<RefreshToken>(entity =>
        //    {
        //        entity.Property(e => e.CreatedUsedId).HasMaxLength(50);

        //        entity.Property(e => e.ExpiresUtc).HasColumnType("datetime");

        //        entity.Property(e => e.IssuedUtc).HasColumnType("datetime");

        //        entity.Property(e => e.UpdatedUserId).HasMaxLength(50);

        //        entity.Property(e => e.UserId)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);
        //    });

        //    modelBuilder.Entity<TestTable>(entity =>
        //    {
        //        entity.ToTable("testTable");

        //        entity.Property(e => e.Id).ValueGeneratedNever();

        //        entity.Property(e => e.LastName).HasMaxLength(50);

        //        entity.Property(e => e.Name).HasMaxLength(50);
        //    });
        //}
    }
}

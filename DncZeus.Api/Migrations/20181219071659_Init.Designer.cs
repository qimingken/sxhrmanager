﻿// <auto-generated />
using System;
using DncZeus.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DncZeus.Api.Migrations
{
    [DbContext(typeof(DncZeusDbContext))]
    [Migration("20181219071659_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DncZeus.Api.Entities.DncIcon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("CreatedByUserName");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Custom")
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsDeleted");

                    b.Property<int>("ModifiedByUserId");

                    b.Property<string>("ModifiedByUserName");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("DncIcon");
                });

            modelBuilder.Entity("DncZeus.Api.Entities.DncMenu", b =>
                {
                    b.Property<Guid>("Guid");

                    b.Property<string>("Alias")
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("CreatedByUserName");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(800)");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IsDefaultRouter");

                    b.Property<int>("IsDeleted");

                    b.Property<int>("Level");

                    b.Property<int>("ModifiedByUserId");

                    b.Property<string>("ModifiedByUserName");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("ParentGuid");

                    b.Property<string>("ParentName");

                    b.Property<int>("Sort");

                    b.Property<int>("Status");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Guid");

                    b.ToTable("DncMenu");
                });

            modelBuilder.Entity("DncZeus.Api.Entities.DncPermission", b =>
                {
                    b.Property<string>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ActionCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("CreatedByUserName");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icon");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IsDeleted");

                    b.Property<Guid>("MenuGuid");

                    b.Property<int>("ModifiedByUserId");

                    b.Property<string>("ModifiedByUserName");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Status");

                    b.Property<int>("Type");

                    b.HasKey("Code");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("MenuGuid");

                    b.ToTable("DncPermission");
                });

            modelBuilder.Entity("DncZeus.Api.Entities.DncRole", b =>
                {
                    b.Property<string>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("CreatedByUserName");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsBuiltin");

                    b.Property<int>("IsDeleted");

                    b.Property<bool>("IsSuperAdministrator");

                    b.Property<int>("ModifiedByUserId");

                    b.Property<string>("ModifiedByUserName");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Status");

                    b.HasKey("Code");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("DncRole");
                });

            modelBuilder.Entity("DncZeus.Api.Entities.DncRolePermissionMapping", b =>
                {
                    b.Property<string>("RoleCode")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PermissionCode")
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("CreatedOn");

                    b.HasKey("RoleCode", "PermissionCode");

                    b.HasIndex("PermissionCode");

                    b.ToTable("DncRolePermissionMapping");
                });

            modelBuilder.Entity("DncZeus.Api.Entities.DncUser", b =>
                {
                    b.Property<Guid>("Guid");

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("CreatedByUserName");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(800)");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IsDeleted");

                    b.Property<int>("IsLocked");

                    b.Property<string>("LoginName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ModifiedByUserId");

                    b.Property<string>("ModifiedByUserName");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Status");

                    b.Property<int>("UserType");

                    b.HasKey("Guid");

                    b.ToTable("DncUser");
                });

            modelBuilder.Entity("DncZeus.Api.Entities.DncUserRoleMapping", b =>
                {
                    b.Property<Guid>("UserGuid");

                    b.Property<string>("RoleCode");

                    b.Property<DateTime>("CreatedOn");

                    b.HasKey("UserGuid", "RoleCode");

                    b.HasIndex("RoleCode");

                    b.ToTable("DncUserRoleMapping");
                });

            modelBuilder.Entity("DncZeus.Api.Entities.DncPermission", b =>
                {
                    b.HasOne("DncZeus.Api.Entities.DncMenu", "Menu")
                        .WithMany("Permissions")
                        .HasForeignKey("MenuGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DncZeus.Api.Entities.DncRolePermissionMapping", b =>
                {
                    b.HasOne("DncZeus.Api.Entities.DncPermission", "DncPermission")
                        .WithMany("Roles")
                        .HasForeignKey("PermissionCode")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DncZeus.Api.Entities.DncRole", "DncRole")
                        .WithMany("Permissions")
                        .HasForeignKey("RoleCode")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DncZeus.Api.Entities.DncUserRoleMapping", b =>
                {
                    b.HasOne("DncZeus.Api.Entities.DncRole", "DncRole")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleCode")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DncZeus.Api.Entities.DncUser", "DncUser")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserGuid")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}

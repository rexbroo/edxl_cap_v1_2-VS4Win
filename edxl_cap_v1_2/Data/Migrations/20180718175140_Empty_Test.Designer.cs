﻿// <auto-generated />
using edxl_cap_v1_2.Data;
using edxl_cap_v1_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using MySql.Data.EntityFrameworkCore.Storage.Internal;
using System;

namespace edxl_cap_v1_2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180718175140_Empty_Test")]
    partial class Empty_Test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("edxl_cap_v1_2.Models.Alert", b =>
                {
                    b.Property<int>("AlertIndex")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Addresses");

                    b.Property<string>("Alert_Identifier")
                        .HasMaxLength(150);

                    b.Property<string>("Code");

                    b.Property<int>("DataCategory_Id");

                    b.Property<string>("Incidents");

                    b.Property<int>("MsgType");

                    b.Property<string>("Note");

                    b.Property<string>("References");

                    b.Property<string>("Restriction");

                    b.Property<int>("Scope");

                    b.Property<string>("Sender");

                    b.Property<DateTime>("Sent");

                    b.Property<string>("Source");

                    b.Property<int>("Status");

                    b.HasKey("AlertIndex");

                    b.HasIndex("Alert_Identifier")
                        .IsUnique();

                    b.ToTable("Alert");
                });

            modelBuilder.Entity("edxl_cap_v1_2.Models.Area", b =>
                {
                    b.Property<int>("AreaIndex")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Alert_Identifier")
                        .HasMaxLength(150);

                    b.Property<string>("Altitude");

                    b.Property<string>("AreaDesc");

                    b.Property<string>("Ceiling");

                    b.Property<string>("Circle");

                    b.Property<int>("DataCategory_Id");

                    b.Property<string>("Geocode");

                    b.Property<string>("Polygon");

                    b.HasKey("AreaIndex");

                    b.HasIndex("Alert_Identifier")
                        .IsUnique();

                    b.ToTable("Area");
                });

            modelBuilder.Entity("edxl_cap_v1_2.Models.ContentViewModels.EdxlCapMessageViewModel", b =>
                {
                    b.Property<string>("Alert_Identifier")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Alert_Identifier");

                    b.ToTable("EdxlCapMessageViewModel");
                });

            modelBuilder.Entity("edxl_cap_v1_2.Models.DataCategory", b =>
                {
                    b.Property<int>("DataCategory_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DataCategoryName");

                    b.HasKey("DataCategory_Id");

                    b.ToTable("DataCategory");
                });

            modelBuilder.Entity("edxl_cap_v1_2.Models.Element", b =>
                {
                    b.Property<int>("ElementIndex")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AlertIndex");

                    b.Property<int?>("AreaIndex");

                    b.Property<int?>("DataCategory_Id1");

                    b.Property<string>("ElementName");

                    b.Property<int?>("InfoIndex");

                    b.Property<int?>("ResourceIndex");

                    b.HasKey("ElementIndex");

                    b.HasIndex("AlertIndex");

                    b.HasIndex("AreaIndex");

                    b.HasIndex("DataCategory_Id1");

                    b.HasIndex("InfoIndex");

                    b.HasIndex("ResourceIndex");

                    b.ToTable("Element");
                });

            modelBuilder.Entity("edxl_cap_v1_2.Models.Info", b =>
                {
                    b.Property<int>("InfoIndex")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Alert_Identifier")
                        .HasMaxLength(150);

                    b.Property<string>("Audience");

                    b.Property<int>("Category");

                    b.Property<int>("Certainty");

                    b.Property<string>("Contact");

                    b.Property<int>("DataCategory_Id");

                    b.Property<string>("Description");

                    b.Property<DateTime>("Effective");

                    b.Property<string>("Event");

                    b.Property<string>("EventCode");

                    b.Property<DateTime>("Expires");

                    b.Property<string>("Headline");

                    b.Property<string>("Instruction");

                    b.Property<string>("Language");

                    b.Property<DateTime>("Onset");

                    b.Property<string>("Parameter");

                    b.Property<int>("ResponseType");

                    b.Property<string>("SenderName");

                    b.Property<int>("Severity");

                    b.Property<int>("Urgency");

                    b.Property<string>("Web");

                    b.HasKey("InfoIndex");

                    b.HasIndex("Alert_Identifier")
                        .IsUnique();

                    b.ToTable("Info");
                });

            modelBuilder.Entity("edxl_cap_v1_2.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PersonName");

                    b.HasKey("PersonId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("edxl_cap_v1_2.Models.Resource", b =>
                {
                    b.Property<int>("ResourceIndex")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Alert_Identifier")
                        .HasMaxLength(150);

                    b.Property<int>("DataCategory_Id");

                    b.Property<string>("DerefUri");

                    b.Property<string>("Digest");

                    b.Property<string>("Info_Alert_Identifier");

                    b.Property<string>("MimeType");

                    b.Property<string>("ResourceDesc");

                    b.Property<int>("Size");

                    b.Property<string>("Uri");

                    b.HasKey("ResourceIndex");

                    b.HasIndex("Alert_Identifier")
                        .IsUnique();

                    b.ToTable("Resource");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<string>", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(200);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("IdentityRole<string>");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole<string>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser<string>", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(200);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("IdentityUser<string>");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser<string>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(200);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(200);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(200);

                    b.Property<string>("RoleId")
                        .HasMaxLength(200);

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .HasMaxLength(200);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole<string>");


                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");

                    b.HasDiscriminator().HasValue("IdentityRole");
                });

            modelBuilder.Entity("edxl_cap_v1_2.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser<string>");


                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("edxl_cap_v1_2.Models.Alert", b =>
                {
                    b.HasOne("edxl_cap_v1_2.Models.ContentViewModels.EdxlCapMessageViewModel")
                        .WithOne("Alert")
                        .HasForeignKey("edxl_cap_v1_2.Models.Alert", "Alert_Identifier");
                });

            modelBuilder.Entity("edxl_cap_v1_2.Models.Area", b =>
                {
                    b.HasOne("edxl_cap_v1_2.Models.ContentViewModels.EdxlCapMessageViewModel")
                        .WithOne("Area")
                        .HasForeignKey("edxl_cap_v1_2.Models.Area", "Alert_Identifier");
                });

            modelBuilder.Entity("edxl_cap_v1_2.Models.Element", b =>
                {
                    b.HasOne("edxl_cap_v1_2.Models.Alert")
                        .WithMany("Elements")
                        .HasForeignKey("AlertIndex");

                    b.HasOne("edxl_cap_v1_2.Models.Area")
                        .WithMany("Elements")
                        .HasForeignKey("AreaIndex");

                    b.HasOne("edxl_cap_v1_2.Models.DataCategory", "DataCategory")
                        .WithMany("Elements")
                        .HasForeignKey("DataCategory_Id1");

                    b.HasOne("edxl_cap_v1_2.Models.Info")
                        .WithMany("Elements")
                        .HasForeignKey("InfoIndex");

                    b.HasOne("edxl_cap_v1_2.Models.Resource")
                        .WithMany("Elements")
                        .HasForeignKey("ResourceIndex");
                });

            modelBuilder.Entity("edxl_cap_v1_2.Models.Info", b =>
                {
                    b.HasOne("edxl_cap_v1_2.Models.ContentViewModels.EdxlCapMessageViewModel")
                        .WithOne("Info")
                        .HasForeignKey("edxl_cap_v1_2.Models.Info", "Alert_Identifier");
                });

            modelBuilder.Entity("edxl_cap_v1_2.Models.Resource", b =>
                {
                    b.HasOne("edxl_cap_v1_2.Models.ContentViewModels.EdxlCapMessageViewModel")
                        .WithOne("Resource")
                        .HasForeignKey("edxl_cap_v1_2.Models.Resource", "Alert_Identifier");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("edxl_cap_v1_2.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("edxl_cap_v1_2.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("edxl_cap_v1_2.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("edxl_cap_v1_2.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using BugTracker.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BugTracker.Migrations
{
    [DbContext(typeof(RaidContext))]
    partial class RaidContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("AppUserProjectTask", b =>
                {
                    b.Property<int>("AppUsersId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectTasksID")
                        .HasColumnType("int");

                    b.HasKey("AppUsersId", "ProjectTasksID");

                    b.HasIndex("ProjectTasksID");

                    b.ToTable("AppUserProjectTask");
                });

            modelBuilder.Entity("BugTracker.Models.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            ConcurrencyStamp = "ce709480-93ce-479e-943c-3d2e4cbd3005",
                            Name = "Administrator"
                        },
                        new
                        {
                            Id = 5,
                            ConcurrencyStamp = "6c6d3bee-039d-4d4e-a367-4a8b2715f97b",
                            Name = "StandardUser"
                        });
                });

            modelBuilder.Entity("BugTracker.Models.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "dabbd1f4-50b4-4f36-a467-c4204e7d0328",
                            EmailConfirmed = false,
                            FirstName = "Josh",
                            LastName = "Maddox",
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEMhWhGvOv77wVK4I+ROeIDZaI2EtjWc+Hul5CbyNYe2BJyvkPUFwWCWHPTmpfDpH1g==",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "JoshFM"
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fdbb87c0-4d33-4581-a276-0114807f7cce",
                            EmailConfirmed = false,
                            FirstName = "Lauren",
                            LastName = "Ackleh",
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEIwMp0m2OnBDMs6nkdd6C+KeUedV17a68KYP/caCcOlMRj3ncDGLAMyLJ53/yhslqw==",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "LaurenGA"
                        },
                        new
                        {
                            Id = 3,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2d8350b9-fb39-4d1c-bfc1-e2db43e2c79b",
                            EmailConfirmed = false,
                            FirstName = "Spencer",
                            LastName = "Hall",
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEIkT+bTpJ7aSJJ/D4yv24KzxPaXeX2I/VpgnfW/eBrddP+jgVRIyAsXUffKi2eU9Nw==",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "SpencerDH"
                        });
                });

            modelBuilder.Entity("BugTracker.Models.AppUserViewedIssue", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AppUserId")
                        .HasColumnType("int");

                    b.Property<int?>("IssueID")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeViewed")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("AppUserId");

                    b.HasIndex("IssueID");

                    b.ToTable("AppUserViewedIssues");
                });

            modelBuilder.Entity("BugTracker.Models.Issue", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<int>("ProjectTaskID")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserCreated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ProjectTaskID");

                    b.ToTable("Issues");
                });

            modelBuilder.Entity("BugTracker.Models.IssueComment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AppUserId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IssueID")
                        .HasColumnType("int");

                    b.Property<string>("UserCreated")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AppUserId");

                    b.HasIndex("IssueID");

                    b.ToTable("IssueComments");
                });

            modelBuilder.Entity("BugTracker.Models.Project", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Moving to Atlanta"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Starting front-end studies"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Algorithm practice"
                        });
                });

            modelBuilder.Entity("BugTracker.Models.ProjectTask", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ProjectID");

                    b.ToTable("ProjectTasks");
                });

            modelBuilder.Entity("BugTracker.Models.UserIssue", b =>
                {
                    b.Property<int>("AppUserID")
                        .HasColumnType("int");

                    b.Property<int>("IssueID")
                        .HasColumnType("int");

                    b.HasKey("AppUserID", "IssueID");

                    b.HasIndex("IssueID");

                    b.ToTable("UserIssues");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUserRole<int>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BugTracker.Models.UserRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUserRole<int>");

                    b.HasDiscriminator().HasValue("UserRole");

                    b.HasData(
                        new
                        {
                            UserId = 3,
                            RoleId = 4
                        });
                });

            modelBuilder.Entity("AppUserProjectTask", b =>
                {
                    b.HasOne("BugTracker.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("AppUsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BugTracker.Models.ProjectTask", null)
                        .WithMany()
                        .HasForeignKey("ProjectTasksID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BugTracker.Models.AppUserViewedIssue", b =>
                {
                    b.HasOne("BugTracker.Models.AppUser", "AppUser")
                        .WithMany("RecentlyViewedIssues")
                        .HasForeignKey("AppUserId");

                    b.HasOne("BugTracker.Models.Issue", "Issue")
                        .WithMany()
                        .HasForeignKey("IssueID");

                    b.Navigation("AppUser");

                    b.Navigation("Issue");
                });

            modelBuilder.Entity("BugTracker.Models.Issue", b =>
                {
                    b.HasOne("BugTracker.Models.ProjectTask", "ProjectTask")
                        .WithMany("Issues")
                        .HasForeignKey("ProjectTaskID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProjectTask");
                });

            modelBuilder.Entity("BugTracker.Models.IssueComment", b =>
                {
                    b.HasOne("BugTracker.Models.AppUser", "AppUser")
                        .WithMany("IssueComments")
                        .HasForeignKey("AppUserId");

                    b.HasOne("BugTracker.Models.Issue", "Issue")
                        .WithMany("IssueComments")
                        .HasForeignKey("IssueID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Issue");
                });

            modelBuilder.Entity("BugTracker.Models.ProjectTask", b =>
                {
                    b.HasOne("BugTracker.Models.Project", null)
                        .WithMany("ProjectTasks")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BugTracker.Models.UserIssue", b =>
                {
                    b.HasOne("BugTracker.Models.AppUser", "AppUser")
                        .WithMany("UserIssues")
                        .HasForeignKey("AppUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BugTracker.Models.Issue", "Issue")
                        .WithMany("UserIssues")
                        .HasForeignKey("IssueID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Issue");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("BugTracker.Models.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("BugTracker.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("BugTracker.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("BugTracker.Models.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BugTracker.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("BugTracker.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BugTracker.Models.AppUser", b =>
                {
                    b.Navigation("IssueComments");

                    b.Navigation("RecentlyViewedIssues");

                    b.Navigation("UserIssues");
                });

            modelBuilder.Entity("BugTracker.Models.Issue", b =>
                {
                    b.Navigation("IssueComments");

                    b.Navigation("UserIssues");
                });

            modelBuilder.Entity("BugTracker.Models.Project", b =>
                {
                    b.Navigation("ProjectTasks");
                });

            modelBuilder.Entity("BugTracker.Models.ProjectTask", b =>
                {
                    b.Navigation("Issues");
                });
#pragma warning restore 612, 618
        }
    }
}

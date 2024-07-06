﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using src.Data;

#nullable disable

namespace src.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240704202731_DeliveredProductMigration")]
    partial class DeliveredProductMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApplicationUserGroupChat", b =>
                {
                    b.Property<string>("ChatsId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MembersId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ChatsId", "MembersId");

                    b.HasIndex("MembersId");

                    b.ToTable("UserGroupChats", (string)null);
                });

            modelBuilder.Entity("FreelancerSkill", b =>
                {
                    b.Property<string>("FreelancersId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SkillsId")
                        .HasColumnType("int");

                    b.HasKey("FreelancersId", "SkillsId");

                    b.HasIndex("SkillsId");

                    b.ToTable("FreelancerSkill");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ProjectSkill", b =>
                {
                    b.Property<int>("ProjectsId")
                        .HasColumnType("int");

                    b.Property<int>("SkillsId")
                        .HasColumnType("int");

                    b.HasKey("ProjectsId", "SkillsId");

                    b.HasIndex("SkillsId");

                    b.ToTable("ProjectSkill");
                });

            modelBuilder.Entity("src.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

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

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("ApplicationUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("src.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("src.Models.DeliveredProduct", b =>
                {
                    b.Property<int>("WorkId")
                        .HasColumnType("int");

                    b.Property<string>("GitHubUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Verified")
                        .HasColumnType("bit");

                    b.HasKey("WorkId");

                    b.ToTable("DeliveredProducts");
                });

            modelBuilder.Entity("src.Models.GroupChat", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AdminId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.ToTable("GroupChats", "chat");
                });

            modelBuilder.Entity("src.Models.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("src.Models.Message", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MessageType")
                        .HasColumnType("int");

                    b.Property<string>("ReceiverGroupId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ReceiverUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SenderId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ReceiverGroupId");

                    b.HasIndex("ReceiverUserId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages", "chat");
                });

            modelBuilder.Entity("src.Models.OnlineUser", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConnectionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("OnlineUsers", "chat");
                });

            modelBuilder.Entity("src.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("ExpectedBudget")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ClientId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("src.Models.Proposal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateOnly>("DeliverDate")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("FreelancerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Proposal");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Proposal");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("src.Models.ProposalReplay", b =>
                {
                    b.Property<int>("ProposalId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAccepted")
                        .HasColumnType("bit");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProposalId");

                    b.ToTable("ProposalReplay");
                });

            modelBuilder.Entity("src.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("src.Models.Client", b =>
                {
                    b.HasBaseType("src.Models.ApplicationUser");

                    b.HasDiscriminator().HasValue("Client");
                });

            modelBuilder.Entity("src.Models.Freelancer", b =>
                {
                    b.HasBaseType("src.Models.ApplicationUser");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ExperienceYears")
                        .HasColumnType("int");

                    b.HasIndex("CategoryId");

                    b.HasDiscriminator().HasValue("Freelancer");
                });

            modelBuilder.Entity("src.Models.JobProposal", b =>
                {
                    b.HasBaseType("src.Models.Proposal");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.HasIndex("FreelancerId");

                    b.HasIndex("JobId");

                    b.HasDiscriminator().HasValue("JobProposal");
                });

            modelBuilder.Entity("src.Models.ProjectProposal", b =>
                {
                    b.HasBaseType("src.Models.Proposal");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasIndex("FreelancerId");

                    b.HasIndex("ProjectId");

                    b.HasDiscriminator().HasValue("ProjectProposal");
                });

            modelBuilder.Entity("ApplicationUserGroupChat", b =>
                {
                    b.HasOne("src.Models.GroupChat", null)
                        .WithMany()
                        .HasForeignKey("ChatsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("src.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("MembersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FreelancerSkill", b =>
                {
                    b.HasOne("src.Models.Freelancer", null)
                        .WithMany()
                        .HasForeignKey("FreelancersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("src.Models.Skill", null)
                        .WithMany()
                        .HasForeignKey("SkillsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("src.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("src.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("src.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("src.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjectSkill", b =>
                {
                    b.HasOne("src.Models.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("src.Models.Skill", null)
                        .WithMany()
                        .HasForeignKey("SkillsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("src.Models.DeliveredProduct", b =>
                {
                    b.HasOne("src.Models.Job", "Job")
                        .WithOne("DeliveredProduct")
                        .HasForeignKey("src.Models.DeliveredProduct", "WorkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("src.Models.Project", "Project")
                        .WithOne("DeliveredProduct")
                        .HasForeignKey("src.Models.DeliveredProduct", "WorkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("src.Models.GroupChat", b =>
                {
                    b.HasOne("src.Models.ApplicationUser", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("src.Models.Job", b =>
                {
                    b.HasOne("src.Models.Project", "Project")
                        .WithMany("Jobs")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("src.Models.Message", b =>
                {
                    b.HasOne("src.Models.GroupChat", "ReceiverGroup")
                        .WithMany("Messages")
                        .HasForeignKey("ReceiverGroupId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("src.Models.ApplicationUser", "ReceiverUser")
                        .WithMany("MessagesReceived")
                        .HasForeignKey("ReceiverUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("src.Models.ApplicationUser", "Sender")
                        .WithMany("MessagesSent")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ReceiverGroup");

                    b.Navigation("ReceiverUser");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("src.Models.Project", b =>
                {
                    b.HasOne("src.Models.Category", "Category")
                        .WithMany("Projects")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("src.Models.Client", "Client")
                        .WithMany("Projects")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("src.Models.Duration", "ExpectedDuration", b1 =>
                        {
                            b1.Property<int>("ProjectId")
                                .HasColumnType("int");

                            b1.Property<int>("Days")
                                .HasColumnType("int");

                            b1.Property<int>("Months")
                                .HasColumnType("int");

                            b1.HasKey("ProjectId");

                            b1.ToTable("Projects");

                            b1.WithOwner()
                                .HasForeignKey("ProjectId");
                        });

                    b.Navigation("Category");

                    b.Navigation("Client");

                    b.Navigation("ExpectedDuration");
                });

            modelBuilder.Entity("src.Models.ProposalReplay", b =>
                {
                    b.HasOne("src.Models.Proposal", "Proposal")
                        .WithOne("ProposalReplay")
                        .HasForeignKey("src.Models.ProposalReplay", "ProposalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proposal");
                });

            modelBuilder.Entity("src.Models.Freelancer", b =>
                {
                    b.HasOne("src.Models.Category", "Category")
                        .WithMany("Freelancers")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("src.Models.JobProposal", b =>
                {
                    b.HasOne("src.Models.Freelancer", "Freelancer")
                        .WithMany("JobProposals")
                        .HasForeignKey("FreelancerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("src.Models.Job", "Job")
                        .WithMany("Proposals")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Freelancer");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("src.Models.ProjectProposal", b =>
                {
                    b.HasOne("src.Models.Freelancer", "Freelancer")
                        .WithMany("ProjectsProposal")
                        .HasForeignKey("FreelancerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("src.Models.Project", "Project")
                        .WithMany("Proposals")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Freelancer");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("src.Models.ApplicationUser", b =>
                {
                    b.Navigation("MessagesReceived");

                    b.Navigation("MessagesSent");
                });

            modelBuilder.Entity("src.Models.Category", b =>
                {
                    b.Navigation("Freelancers");

                    b.Navigation("Projects");
                });

            modelBuilder.Entity("src.Models.GroupChat", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("src.Models.Job", b =>
                {
                    b.Navigation("DeliveredProduct");

                    b.Navigation("Proposals");
                });

            modelBuilder.Entity("src.Models.Project", b =>
                {
                    b.Navigation("DeliveredProduct");

                    b.Navigation("Jobs");

                    b.Navigation("Proposals");
                });

            modelBuilder.Entity("src.Models.Proposal", b =>
                {
                    b.Navigation("ProposalReplay");
                });

            modelBuilder.Entity("src.Models.Client", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("src.Models.Freelancer", b =>
                {
                    b.Navigation("JobProposals");

                    b.Navigation("ProjectsProposal");
                });
#pragma warning restore 612, 618
        }
    }
}

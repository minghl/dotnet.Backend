﻿// <auto-generated />
using System;
using BlogSystem.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlogSystem.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(BlogSystemDbContext))]
    partial class BlogSystemDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BlogSystem.Domain.AccountInfo.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PasswordAnswer")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PasswordQuestion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("QQ")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("RegistTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Sex")
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("BlogSystem.Domain.NewsInfo.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("BlogSystem.Domain.NewsInfo.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasComment("文章作者");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasComment("文章类型Id");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasComment("文章类型名称");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasComment("文章内容");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasComment("文章摘要");

                    b.Property<int>("ReplyCount")
                        .HasColumnType("int")
                        .HasComment("文章回复数");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasComment("文章标题");

                    b.HasKey("Id");

                    b.ToTable("News");
                });

            modelBuilder.Entity("BlogSystem.Domain.NewsInfo.Reply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("NewsId")
                        .HasColumnType("int");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ReplyCount")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ReplyDate")
                        .HasColumnType("int");

                    b.Property<int>("ReplyTitle")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Reply");
                });
#pragma warning restore 612, 618
        }
    }
}

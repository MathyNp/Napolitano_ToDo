﻿// <auto-generated />
using LabIV_01.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LabIV_01.Migrations
{
    [DbContext(typeof(ToDoContext))]
    [Migration("20240416001701_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("LabIV_01.Models.ToDoItem", b =>
                {
                    b.Property<int>("Id_todo_item")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId_user")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id_todo_item");

                    b.HasIndex("UserId_user");

                    b.ToTable("ToDoItems");
                });

            modelBuilder.Entity("LabIV_01.Models.User", b =>
                {
                    b.Property<int>("Id_user")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id_user");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LabIV_01.Models.ToDoItem", b =>
                {
                    b.HasOne("LabIV_01.Models.User", "User")
                        .WithMany("ToDoItems")
                        .HasForeignKey("UserId_user")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("LabIV_01.Models.User", b =>
                {
                    b.Navigation("ToDoItems");
                });
#pragma warning restore 612, 618
        }
    }
}

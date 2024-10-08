﻿using TasksProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Task = TasksProject.Domain.Entities.Task;

namespace TasksProject.Infrastructure.Connections;

public partial class TaskmanagerbdContext : DbContext
{
   public TaskmanagerbdContext()
   {
   }

   public TaskmanagerbdContext(DbContextOptions<TaskmanagerbdContext> options)
       : base(options)
   {
   }

   public virtual DbSet<Category> Categories { get; set; }

   public virtual DbSet<Task> Tasks { get; set; }

   public virtual DbSet<TaskCategory> TaskCategories { get; set; }

   public virtual DbSet<User> Users { get; set; }


 protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
       modelBuilder.Entity<Category>(entity =>
       {
           entity.HasKey(e => e.Id).HasName("category_pkey");

           entity.ToTable("category");

           entity.Property(e => e.Id)
               .ValueGeneratedNever()
               .HasColumnName("id");
           entity.Property(e => e.Description)
               .HasColumnType("character varying")
               .HasColumnName("description");
           entity.Property(e => e.Name)
               .HasColumnType("character varying")
               .HasColumnName("name");
       });

       modelBuilder.Entity<Task>(entity =>
       {
           entity.HasKey(e => e.Id).HasName("task_pkey");

           entity.ToTable("task");

           entity.Property(e => e.Id)
               .ValueGeneratedNever()
               .HasColumnName("id");
           entity.Property(e => e.CreationDate)
               .HasColumnType("timestamp without time zone")
               .HasColumnName("creation_date");
           entity.Property(e => e.Description)
               .HasColumnType("character varying")
               .HasColumnName("description");
           entity.Property(e => e.ExpirationDate)
               .HasColumnType("timestamp without time zone")
               .HasColumnName("expiration_date");
           entity.Property(e => e.Priority).HasColumnName("priority");
           entity.Property(e => e.State).HasColumnName("state");
           entity.Property(e => e.Title)
               .HasColumnType("character varying")
               .HasColumnName("title");
           entity.Property(e => e.UserId).HasColumnName("user_id");

           entity.HasOne(d => d.User).WithMany(p => p.Tasks)
               .HasForeignKey(d => d.UserId)
               .HasConstraintName("user_id_fk");
       });

       modelBuilder.Entity<TaskCategory>(entity =>
       {
           entity.HasKey(e => e.Id).HasName("task_category_pkey");

           entity.ToTable("task_category");

           entity.Property(e => e.Id)
               .ValueGeneratedNever()
               .HasColumnName("id");
           entity.Property(e => e.CategoryId).HasColumnName("category_id");
           entity.Property(e => e.TaskId).HasColumnName("task_id");

           entity.HasOne(d => d.Category).WithMany(p => p.TaskCategories)
               .HasForeignKey(d => d.CategoryId)
               .HasConstraintName("category_id_fk");

           entity.HasOne(d => d.Task).WithMany(p => p.TaskCategories)
               .HasForeignKey(d => d.TaskId)
               .HasConstraintName("task_id_fk");
       });

       modelBuilder.Entity<User>(entity =>
       {
           entity.HasKey(e => e.Id).HasName("User_pkey");

           entity.ToTable("user");

           entity.Property(e => e.Id)
               .ValueGeneratedNever()
               .HasColumnName("id");
           entity.Property(e => e.Mail)
               .HasColumnType("character varying")
               .HasColumnName("mail");
           entity.Property(e => e.Name)
               .HasColumnType("character varying")
               .HasColumnName("name");
           entity.Property(e => e.Password)
               .HasColumnType("character varying")
               .HasColumnName("password");
           entity.Property(e => e.State).HasColumnName("state");
       });

       OnModelCreatingPartial(modelBuilder);
   }

   partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

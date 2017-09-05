using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using StackOverflow.Models;

namespace StackOverflow.DataContext
{
    public partial class StackOverflowContext : DbContext
    {
        public DbSet<AnswersModel> Answers {get; set;}
        public DbSet<CommentsModel> Comments {get; set;}
        public DbSet<QtiesModel> Qties {get; set;}
        public DbSet<QuestionsModel> Questions {get; set;}
        public DbSet<TagsModel> Tags {get; set;}
        public DbSet<UserModel> Users {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql(@"Host=localhost;Database=StackOverflow;Username=dev;Password=dev");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}
    }
}

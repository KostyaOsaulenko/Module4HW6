using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW6.DataAccess.DbModels;

namespace Module4HW6.DataAccess.DbConfiguration
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.ToTable("Genre").HasKey(g => g.Id);

            builder.Property(g => g.Id).HasColumnName("GenreId").ValueGeneratedOnAdd();

            builder.Property(g => g.Title).HasColumnName("Title").IsRequired();

            builder.HasData(new List<Genre>()
            {
                new Genre() { Id = 1, Title = "Genre 1", },
                new Genre() { Id = 2, Title = "Genre 2", },
                new Genre() { Id = 3, Title = "Genre 3", },
                new Genre() { Id = 4, Title = "Genre 4", },
                new Genre() { Id = 5, Title = "Genre 5", },
            });
        }
    }
}

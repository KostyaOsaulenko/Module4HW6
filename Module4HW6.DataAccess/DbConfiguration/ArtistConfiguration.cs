using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW6.DataAccess.DbModels;

namespace Module4HW6.DataAccess.DbConfiguration
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.ToTable("Artist").HasKey(a => a.Id);

            builder.Property(a => a.Id).HasColumnName("ArtistId").ValueGeneratedOnAdd();

            builder.Property(a => a.Name).HasColumnName("Name").IsRequired();
            builder.Property(a => a.DateOfBirth).HasColumnName("DateOfBirth").HasColumnType("date").IsRequired();
            builder.Property(a => a.Phone).HasColumnName("Phone").HasMaxLength(15).IsRequired(false);
            builder.Property(a => a.Email).HasColumnName("Email").HasMaxLength(320).IsRequired(false);
            builder.Property(a => a.InstagramUrl).HasColumnName("InstagramUrl").IsRequired(false);

            builder.HasData(new List<Artist>()
            {
                new Artist() { Id = 1, Name = "Artist 1", DateOfBirth = new DateTime(1980, 06, 06), Phone = "380961234567", Email = "artist1@outlook.com", InstagramUrl = "https://www.instagram.com/artist1", },
                new Artist() { Id = 2, Name = "Artist 2", DateOfBirth = new DateTime(1990, 10, 10), Phone = "380661234567", Email = "artist2@outlook.com", InstagramUrl = "https://www.instagram.com/artist2", },
                new Artist() { Id = 3, Name = "Artist 3", DateOfBirth = new DateTime(2000, 01, 01), Phone = "380963456789", Email = "artist3@outlook.com", InstagramUrl = "https://www.instagram.com/artist3", },
                new Artist() { Id = 4, Name = "Artist 4", DateOfBirth = new DateTime(1977, 07, 07), Phone = "380663456789", Email = "artist4@outlook.com", InstagramUrl = "https://www.instagram.com/artist4", },
                new Artist() { Id = 5, Name = "Artist 5", DateOfBirth = new DateTime(1995, 05, 05), Phone = "380555555555", Email = "artist5@outlook.com", InstagramUrl = "https://www.instagram.com/artist5", },
            });
        }
    }
}

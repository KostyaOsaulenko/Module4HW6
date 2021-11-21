using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW6.DataAccess.DbModels;

namespace Module4HW6.DataAccess.DbConfiguration
{
    public class SongConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.ToTable("Song").HasKey(s => s.Id);

            builder.Property(s => s.Id).HasColumnName("SongId").ValueGeneratedOnAdd();

            builder.Property(s => s.Title).HasColumnName("Title").IsRequired();
            builder.Property(s => s.Duration).HasColumnName("Duration").IsRequired();
            builder.Property(s => s.ReleasedDate).HasColumnName("ReleasedDate").HasColumnType("date").IsRequired();

            builder.HasOne(s => s.Genre).WithMany(g => g.Songs)
                .HasForeignKey(s => s.GenreId).OnDelete(DeleteBehavior.Cascade).IsRequired();

            builder.HasData(new List<Song>()
            {
                new Song() { Id = 1, Title = "Song 1", Duration = 180, GenreId = 1, ReleasedDate = new DateTime(2015, 01, 01), },
                new Song() { Id = 2, Title = "Song 2", Duration = 190, GenreId = 2, ReleasedDate = new DateTime(2015, 02, 02), },
                new Song() { Id = 3, Title = "Song 3", Duration = 200, GenreId = 3, ReleasedDate = new DateTime(2015, 03, 03), },
                new Song() { Id = 4, Title = "Song 4", Duration = 210, GenreId = 4, ReleasedDate = new DateTime(2015, 04, 04), },
                new Song() { Id = 5, Title = "Song 5", Duration = 220, GenreId = 5, ReleasedDate = new DateTime(2015, 05, 05), },
                new Song() { Id = 6, Title = "Song 6", Duration = 230, GenreId = 1, ReleasedDate = new DateTime(2015, 06, 06), },
                new Song() { Id = 7, Title = "Song 7", Duration = 240, GenreId = 1, ReleasedDate = new DateTime(2015, 07, 07), },
                new Song() { Id = 8, Title = "Song 8", Duration = 250, GenreId = 2, ReleasedDate = new DateTime(2015, 08, 08), },
                new Song() { Id = 9, Title = "Song 9", Duration = 260, GenreId = 3, ReleasedDate = new DateTime(2015, 09, 09), },
                new Song() { Id = 10, Title = "Song 10", Duration = 270, ReleasedDate = new DateTime(2015, 10, 10), },
            });
        }
    }
}

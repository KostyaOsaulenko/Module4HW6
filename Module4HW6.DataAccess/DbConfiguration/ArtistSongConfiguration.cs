using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW6.DataAccess.DbModels;

namespace Module4HW6.DataAccess.DbConfiguration
{
    public class ArtistSongConfiguration : IEntityTypeConfiguration<ArtistSong>
    {
        public void Configure(EntityTypeBuilder<ArtistSong> builder)
        {
            builder.ToTable("ArtistSong").HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("ArtistSongId").ValueGeneratedOnAdd();

            builder.HasOne(a => a.Artist).WithMany(x => x.ArtistSongs)
                .HasForeignKey(a => a.ArtistId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(s => s.Song).WithMany(x => x.ArtistSongs)
                .HasForeignKey(s => s.SongId).OnDelete(DeleteBehavior.Cascade);

            builder.HasData(new List<ArtistSong>()
            {
                new ArtistSong() { Id = 1, ArtistId = 1, SongId = 1, },
                new ArtistSong() { Id = 2, ArtistId = 2, SongId = 2, },
                new ArtistSong() { Id = 3, ArtistId = 3, SongId = 3, },
                new ArtistSong() { Id = 4, ArtistId = 4, SongId = 4, },
                new ArtistSong() { Id = 5, ArtistId = 5, SongId = 5, },
                new ArtistSong() { Id = 6, ArtistId = 1, SongId = 6, },
                new ArtistSong() { Id = 7, ArtistId = 2, SongId = 7, },
                new ArtistSong() { Id = 8, ArtistId = 3, SongId = 8, },
                new ArtistSong() { Id = 9, ArtistId = 4, SongId = 9, },
                new ArtistSong() { Id = 10, ArtistId = 5, SongId = 10, },
                new ArtistSong() { Id = 11, ArtistId = 5, SongId = 1, },
                new ArtistSong() { Id = 12, ArtistId = 4, SongId = 1, },
                new ArtistSong() { Id = 13, ArtistId = 3, SongId = 2, },
                new ArtistSong() { Id = 14, ArtistId = 2, SongId = 3, },
                new ArtistSong() { Id = 15, ArtistId = 1, SongId = 4, },
                new ArtistSong() { Id = 16, ArtistId = 1, SongId = 3, },
                new ArtistSong() { Id = 17, ArtistId = 2, SongId = 4, },
                new ArtistSong() { Id = 18, ArtistId = 3, SongId = 4, },
                new ArtistSong() { Id = 19, ArtistId = 4, SongId = 10, },
                new ArtistSong() { Id = 20, ArtistId = 5, SongId = 8, },
            });
        }
    }
}

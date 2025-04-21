using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SonHaftaHoca.Models.Configurations
{
    public class KategoriCFG : IEntityTypeConfiguration<Kategori>
    {
        public void Configure(EntityTypeBuilder<Kategori> builder)
        {
            builder.HasData(
                new Kategori
                {
                KategoriId = 1,
                KategoriAdi = "İş",
 
                },
                new Kategori
                {
                    KategoriId = 2,
                    KategoriAdi = "Ev",
                },

                new Kategori
                {
                    KategoriId = 3,
                    KategoriAdi = "Hafta Sonu",
                }

            );
        }
    }
}

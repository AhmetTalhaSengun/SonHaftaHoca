﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace SonHaftaHoca.Models
{
    public class Eylem
    {
        public int EylemId { get; set; }

        public string EylemAdi { get; set; }

        public string Aciklama { get; set; }

        public DateTime OlusturmaTarihi { get; set; }

        public DateTime EylemTarihi { get; set; }

        public bool EylemYapildiMi { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public int KategoriId { get; set; }

        public IdentityUser? User { get; set; }
        public Kategori? Kategori { get; set; }

    }
}

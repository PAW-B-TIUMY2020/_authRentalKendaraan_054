using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan.Models
{
    public partial class Kendaraan
    {
        public Kendaraan()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdKendaraan { get; set; }
        [Required(ErrorMessage = "Nama kendaraan tidak boleh kosong")]
        public string NamaKendaraan { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public string NoPolisi { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public string NoStnk { get; set; }
        public int? IdJenisKendaraan { get; set; }
        [Required(ErrorMessage = "Ketersediaan tidak boleh kosong")]
        public string Ketersediaan { get; set; }

        public JenisKendaraan IdJenisKendaraanNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}

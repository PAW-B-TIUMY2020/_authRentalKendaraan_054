using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan.Models
{
    public partial class JenisKendaraan
    {
        public JenisKendaraan()
        {
            Kendaraan = new HashSet<Kendaraan>();
        }

        public int IdJenisKendaraan { get; set; }
        [Required(ErrorMessage = "Nama jenis kendaraan tidak boleh kosong")]
        public string NamaJenisKendaraan { get; set; }

        public ICollection<Kendaraan> Kendaraan { get; set; }
    }
}

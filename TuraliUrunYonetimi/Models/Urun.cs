using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TuraliUrunYonetimi.Models
{
    public class Urun
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UrunId { get; set; }

        [Required]
        [MaxLength(80)]
        public string UrunAdi { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Range(0, double.MaxValue, ErrorMessage = "Fiyat negatif olamaz.")]
        public decimal? Fiyat { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Stok miktarı negatif olamaz.")]
        public int StokMiktari { get; set; }
    }
}

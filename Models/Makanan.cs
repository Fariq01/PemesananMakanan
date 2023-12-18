using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using PemesananMakanan;

namespace PemesananMakanan.Models
{

public class Makanan
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int MakananId {get; set;}

    [Required]

    [StringLength(20)]
    public string? MakananNama {get; set;}
    public float Harga {get; set;}
    public string? PicturePath{get; set;}
}

}
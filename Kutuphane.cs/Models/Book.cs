using System.ComponentModel.DataAnnotations;
namespace Kutuphane.cs.Models
{

   public class Book
   {
    public int Id { get; set; }

    [Required(ErrorMessage = "Kitap başlığı boş bırakılamaz.")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Yazar ismi boş bırakılamaz.")]
    public string Author { get; set; }

    [Range(1, 10000, ErrorMessage = "Fiyat 1 ile 10.000 arasında olmalıdır.")]
    public decimal Price { get; set; }

    [Range(0, 500, ErrorMessage = "Stok 0'dan küçük olamaz.")]
    public int Stock { get; set; }
    }
}

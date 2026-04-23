using Kutuphane.cs.Models;

namespace KUTUPHANE.Models
{
    public class Kategori
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}

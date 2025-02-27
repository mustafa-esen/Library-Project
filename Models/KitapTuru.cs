using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ders1.Models
{
    public class KitapTuru
    {
        [Key] // primary key. Id microsoft tarafından üzerine [Key] yazmadan da otomatik olarak primary key olarak atanır.
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Kitap Tür Adı Boş Bırakılamaz!")] // not null
        [MaxLength(25)]
        [DisplayName("Kitap Türü Adı")]
        public string Ad { get; set; }
    }
}

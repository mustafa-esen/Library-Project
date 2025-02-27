using ders1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

// Veritabanında EF tablo oluşturması için ilgili model sınıflarınızı buraya eklemelisiniz.
namespace ders1.Utility
{
    public class UygulamaDBContext : IdentityDbContext 
    {
        public UygulamaDBContext(DbContextOptions<UygulamaDBContext> options) : base(options) { }
        public DbSet<KitapTuru> KitapTurleri { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Kiralama> Kiralamalar { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}


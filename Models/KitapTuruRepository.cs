using ders1.Utility;

namespace ders1.Models
{
    public class KitapTuruRepository : Repository<KitapTuru>, IKitapTuruRepository
    {

        private UygulamaDBContext _uygulamaDbContext;
        public KitapTuruRepository(UygulamaDBContext uygulamaDbContext) : base(uygulamaDbContext)
        {
            _uygulamaDbContext = uygulamaDbContext;
        }

        public void Guncelle(KitapTuru kitapTuru)
        {
            _uygulamaDbContext.Update(kitapTuru);
        }

        public void Kaydet()
        {
            _uygulamaDbContext.SaveChanges();
        }
    }
}

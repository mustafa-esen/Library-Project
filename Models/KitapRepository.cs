using ders1.Utility;

namespace ders1.Models
{
    public class KiralamaRepository : Repository<Kiralama>, IKiralamaRepository
    {
        private UygulamaDBContext _uygulamaDbContext;
        public KiralamaRepository(UygulamaDBContext uygulamaDbContext) : base(uygulamaDbContext)
        {
            _uygulamaDbContext = uygulamaDbContext;
        }

        public void Guncelle(Kiralama kiralama)
        {
            _uygulamaDbContext.Update(kiralama);
        }

        public void Kaydet()
        {
            _uygulamaDbContext.SaveChanges();
        }
    }
}

﻿using ders1.Utility;

namespace ders1.Models
{
    public class KitapRepository : Repository<Kitap>, IKitapRepository
    {
        private UygulamaDBContext _uygulamaDbContext;
        public KitapRepository(UygulamaDBContext uygulamaDbContext) : base(uygulamaDbContext)
        {
            _uygulamaDbContext = uygulamaDbContext;
        }

        public void Guncelle(Kitap kitap)
        {
            _uygulamaDbContext.Update(kitap);
        }

        public void Kaydet()
        {
            _uygulamaDbContext.SaveChanges();
        }
    }
}

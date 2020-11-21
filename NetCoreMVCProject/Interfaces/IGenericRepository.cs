using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMVCProject.Interfaces
{
    public interface IGenericRepository<Tablo> where Tablo : class, new()
    {
        void Ekle(Tablo tablo);
        void Sil(Tablo tablo);
        void Guncelle(Tablo tablo);
        public List<Tablo> HepsiniGetir();
        public Tablo Getiridile(int id);

    }
}

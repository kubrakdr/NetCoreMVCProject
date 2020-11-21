using NetCoreMVCProject.Contexts;
using NetCoreMVCProject.Entities;
using NetCoreMVCProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMVCProject.Repositories
{
    public class UrunKategoriRepository : GenericRepository<UrunKategori>, IUrunKategoriRepository
    {
        public UrunKategori Getiridile(int id)
        {
            throw new NotImplementedException();
        }

        public List<UrunKategori> GHepsiniGetir()
        {
            throw new NotImplementedException();
        }
    }
}

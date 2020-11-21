using NetCoreMVCProject.Contexts;
using NetCoreMVCProject.Entities;
using NetCoreMVCProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMVCProject.Repositories
{
    public class KategoriRepository : GenericRepository<Kategori>, IKategoriRepository
    {
        public Kategori Getiridile(int id)
        {
            throw new NotImplementedException();
        }

        public List<Kategori> GHepsiniGetir()
        {
            throw new NotImplementedException();
        }
    }
}

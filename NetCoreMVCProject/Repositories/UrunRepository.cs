using NetCoreMVCProject.Contexts;
using NetCoreMVCProject.Entities;
using NetCoreMVCProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMVCProject.Repositories
{
    public class UrunRepository : GenericRepository<Urun>, IUrunRepository
    {
        public Urun Getiridile(int id)
        {
            throw new NotImplementedException();
        }

        public List<Urun> GHepsiniGetir()
        {
            throw new NotImplementedException();
        }
    }
}

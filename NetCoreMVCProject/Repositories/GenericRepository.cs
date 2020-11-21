﻿using NetCoreMVCProject.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMVCProject.Repositories
{
    public class GenericRepository<Tablo> where Tablo:class,new()
    {
        public void Ekle(Tablo tablo)
        {
            using var context = new YoutubeContext();
            context.Set<Tablo>().Add(tablo);
            context.SaveChanges();
        }
        public void Guncelle(Tablo tablo)
        {
            using var context = new YoutubeContext();
            context.Set<Tablo>().Update(tablo);
            context.SaveChanges();
        }
        public void Sil(Tablo tablo)
        {
            using var context = new YoutubeContext();
            context.Set<Tablo>().Remove(tablo);
            context.SaveChanges();
        }
        public List<Tablo> HepsiniGetir()
        {
            using var context = new YoutubeContext();
            return context.Set<Tablo>().ToList();
        }
        public Tablo GetirIdile(int id)
        {
            using var context = new YoutubeContext();
            return context.Set<Tablo>().Find(id);
        }




    }
}

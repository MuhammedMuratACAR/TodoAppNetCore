using ACARProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Context;
using ACARProje.ToDo.DataAccess.Interfaces;
using ACARProje.ToDo.Entities.Concrete;
using ACARProje.ToDo.Entities.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACARProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGenericRepository<Tablo> : IGenericDal<Tablo> where Tablo : class, ITablo, new()
    {
        public List<Tablo> GetiHepsi()
        {
            //  context.Calismalar=context.Set<Calisma>()
            using var context = new ToDoContext();
            return context.Set<Tablo>().ToList();
        }

        public Tablo GetirIdile(int id)
        {
            using var context = new ToDoContext();
            return context.Set<Tablo>().Find(id);
        }

        public void Guncelle(Tablo tablo)
        {
            using var context = new ToDoContext();
            //context.Entry(tablo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.Set<Tablo>().Update(tablo);
            context.SaveChanges();
        }

        public void Kaydet(Tablo tablo)
        {
            using var context = new ToDoContext();
            context.Set<Tablo>().Add(tablo);
            context.SaveChanges();
        }

        public void Sil(Tablo tablo)
        {
            using var context = new ToDoContext();
            context.Set<Tablo>().Remove(tablo);
            context.SaveChanges();
        }
    }
}

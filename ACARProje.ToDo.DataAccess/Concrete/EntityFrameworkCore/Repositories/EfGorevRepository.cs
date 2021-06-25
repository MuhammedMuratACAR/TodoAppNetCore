using ACARProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Context;
using ACARProje.ToDo.DataAccess.Interfaces;
using ACARProje.ToDo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ACARProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGorevRepository : EfGenericRepository<Gorev>, IGorevDal
    {
        public List<Gorev> GetirAciliyetIleTamamlanmayan()
        {
            using (var context = new ToDoContext())
            {
                return context.Gorevler.Include(I => I.Aciliyet).Where(I => !I.Durum).OrderByDescending(I => I.OlusturulmaTarih).ToList();            }
        }
    }
}

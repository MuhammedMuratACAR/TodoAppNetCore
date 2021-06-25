using ACARProje.ToDo.DataAccess.Interfaces;
using ACARProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACARProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfRaporRepository : EfGenericRepository<Rapor>, IRaporDal
    {
    }
}

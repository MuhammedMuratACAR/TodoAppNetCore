using ACARProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACARProje.ToDo.Business.Interfaces
{
    public interface IGorevService:IGenericService<Gorev>
    {
        List<Gorev> GetirAciliyetIleTamamlanmayan();

    }
}

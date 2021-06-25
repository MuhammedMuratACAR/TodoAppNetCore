using ACARProje.ToDo.Entities.Concrete;
using System.Collections.Generic;

namespace ACARProje.ToDo.DataAccess.Interfaces
{
    public interface IGorevDal:IGenericDal<Gorev>
    {
        List<Gorev> GetirAciliyetIleTamamlanmayan();

    }
}

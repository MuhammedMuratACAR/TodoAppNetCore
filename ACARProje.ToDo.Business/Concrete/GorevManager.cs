using ACARProje.ToDo.Business.Interfaces;
using ACARProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using ACARProje.ToDo.DataAccess.Interfaces;
using ACARProje.ToDo.Entities.Concrete;
using System.Collections.Generic;

namespace ACARProje.ToDo.Business.Concrete
{
    public class GorevManager : IGorevService
    {
        private readonly IGorevDal _gorevDal;

        public GorevManager(IGorevDal gorevDal)
        {
            _gorevDal = gorevDal;
        }
        public List<Gorev> GetirHepsi()
        {
            return _gorevDal.GetiHepsi();
        }

        public List<Gorev> GetirAciliyetIleTamamlanmayan()
        {
            return _gorevDal.GetirAciliyetIleTamamlanmayan();
        }

        public Gorev GetirIdile(int id)
        {
            return _gorevDal.GetirIdile(id);
        }

        public void Guncelle(Gorev tablo)
        {
            _gorevDal.Guncelle(tablo);
        }

        public void Kaydet(Gorev tablo)
        {
            _gorevDal.Kaydet(tablo);

        }


        public void Sil(Gorev tablo)
        {
            _gorevDal.Sil(tablo);

        }
    }
}

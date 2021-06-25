using ACARProje.ToDo.Business.Interfaces;
using ACARProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using ACARProje.ToDo.DataAccess.Interfaces;
using ACARProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACARProje.ToDo.Business.Concrete
{
    public class AciliyetManager : IAciliyetService
    {
        private readonly IAciliyetDal _aciliyetDal;
        public AciliyetManager(IAciliyetDal aciliyetDal)
        {
            _aciliyetDal = aciliyetDal;
        }
        public List<Aciliyet> GetirHepsi()
        {
            return _aciliyetDal.GetiHepsi();
        }

        public Aciliyet GetirIdile(int id)
        {
            return _aciliyetDal.GetirIdile(id);
        }

        public void Guncelle(Aciliyet tablo)
        {
            _aciliyetDal.Guncelle(tablo);
        }

        public void Kaydet(Aciliyet tablo)
        {
            _aciliyetDal.Kaydet(tablo);
        }

        public void Sil(Aciliyet tablo)
        {
            _aciliyetDal.Sil(tablo);
        }
    }
}

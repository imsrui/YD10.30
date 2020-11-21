using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model.reception;

namespace BLL
{
   public class FreeService
    {
        private readonly FreeManager fm = new FreeManager();
        public int Add(Free free)
        {
            return fm.Add(free);
        }

        public int Edit(Free free)
        {

            return fm.Edit(free);
        }
        public int Delete(Guid id)
        {
            return fm.Delete(id);
        }
        public IList<Free> GetAll()
        {
            return fm.GetAll();
        }
        public IList<Free> GetByTitle(string title)
        {
            return fm.GetByTitle(title);
        }
    }
}

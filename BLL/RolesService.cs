using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RolesService
    {
        private readonly RolesManager rm = new RolesManager();
        public int Add(Roles roles)
        {
            return rm.Add(roles);

        }

        public int Edit(Roles roles)
        {
            return rm.Edit(roles);
        }

        public int PutTrash(Guid id)
        {
            return rm.PutTrash(id);
        }

        public int Restore(Guid id)
        {
            return rm.Restore(id);
        }

        public int Delete(Guid id)
        {
            return rm.Delete(id);
        }

        public IList<Roles> GetAll()
        {
            return rm.GetAll();
        }

        public IList<Roles> GetByTitle(string title)
        {
            return rm.GetByTitle(title);
        }


        public Roles GetById(Guid id)
        {
            return rm.GetById(id);
        }

        public IList<Roles> GetAllInTrash()
        {
            return rm.GetAllInTrash();
        }

        public IList<Roles> GetByTitleInTrash(string title)
        {
            return rm.GetByTitleInTrash(title);
        }
    }
}

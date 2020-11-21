using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsersPermissionsService
    {
        private readonly UsersPermissionsManager dal = new UsersPermissionsManager();

        public int Add(UsersPermissions model)
        {
            return dal.Add(model);
        }

        public int Delete(Guid id)
        {
            return dal.Delete(id);
        }

        public IList<UsersPermissions> GetUsersPermissionsesByRolesId(Guid rid)
        {
            return dal.GetUsersPermissionsesByRolesId(rid);
        }

    }
}

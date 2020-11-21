using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class UsersService
    {
        private readonly UsersManager um = new UsersManager();
        public int Add(Users users)
        {
            return um.Add(users);
        }
        public int Edit(Users users)
        {
            return um.Edit(users);
        }
        public int Delete(Guid id)
        {
            return um.Delete(id);
        }
        public IList<Users> GetAll()
        {
            return um.GetAll();
        }

        public Users GetById(Guid id)
        {
            return um.GetById(id);
        }



        public int PutTrash(Guid id)
        {
            return um.PutTrash(id);

        }


        public int Remove(Guid id)
        {
            return um.Remove(id);
        }


        public int PutTrashList(string idList)
        {
            return um.PutTrashList(idList);

        }


        public int Restore(Guid id)
        {
            return um.Restore(id);
        }





        public IList<Users> GetByNickName(string nickname)
        {
            return um.GetByNickName(nickname);
        }




        public IList<Users> GetAllInTrash()
        {
            return um.GetAllInTrash();
        }

        public IList<Users> GetByNickNameInTrash(string nickname)
        {
            return um.GetByNickNameInTrash(nickname);

        }

        public Users Login(string account, string password)
        {
            return um.Login(account, password);
        }
    }
}

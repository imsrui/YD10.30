using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public  class UsersManager
    {
        public int Add(Users users)
        {
            string sql = " insert into Users(Users_Id,Users_Account,Users_Password,Users_NickName,Users_Photo,Users_RolesId,Users_DeleteId,Users_CreateTime,Users_UpdateTime) values(@Users_Id,@Users_Account,@Users_Password,@Users_NickName,@Users_Photo,@Users_RolesId,@Users_DeleteId,@Users_CreateTime,@Users_UpdateTime)";



            return SqlHelper<Users>.ExecuteNonQuery(sql, users);
        }
        public int Edit(Users users)
        {
            string sql = " Update Users set Users_Password=@Users_Password,Users_NickName=@Users_NickName,Users_RolesId=@Users_RolesId, UpdateTime = @UpdateTime where Users_Account=@Users_Account";
            return SqlHelper<Users>.ExecuteNonQuery(sql, users);
        }
        public IList<Users> GetAll()
        {
            string sql = "select * from Users where Users_DeleteId = 1 order by Users_UpdateTime desc";
            return SqlHelper<Users>.Query(sql, null);
        }


        public int PutTrash(Guid id)
        {
            string sql = "update Users set Users_DeleteId = 0 where Users_Id = @Users_Id";

            return SqlHelper<Users>.ExecuteNonQuery(sql, new Users() { Users_Id = id });
        }


        public int Remove(Guid id)
        {
            string sql = "delete from Users where Users_Id_DeleteId = 0 and Users_Id_Id = @Users_Id_Id";

            return SqlHelper<Users>.ExecuteNonQuery(sql, new Users() { Users_Id = id });
        }


        public int PutTrashList(string idList)
        {
            string sql = "update Users set Users_DeleteId = 0 where Users_Id in (" + idList + ")";

            return SqlHelper<Users>.ExecuteNonQuery(sql, null);
        }


        public int Restore(Guid id)
        {
            string sql = "update Users set Users_DeleteId = 0 where Users_Id = @Users_Id";
            return SqlHelper<Users>.ExecuteNonQuery(sql, new Users() { Users_Id = id });
        }

        public int Delete(Guid id)
        {
            string sql = "delete from Users where Users_DeleteId = 0 and Users_Id = @Users_Id";
            return SqlHelper<Users>.ExecuteNonQuery(sql, new Users() { Users_Id = id });
        }



        public IList<Users> GetByNickName(string nickname)
        {
            string sql = "select * from Users where Users_DeleteId = 1 and Users_NickName like @Users_NickName";
            return SqlHelper<Users>.Query(sql, new Users() { Users_NickName = "%" + nickname + "%" });
        }

        public Users GetById(Guid id)
        {
            string sql = "select * from Users where Users_Id = @Users_Id";
            return SqlHelper<Users>.Query(sql, new Users() { Users_Id = id }).FirstOrDefault();
        }


        public IList<Users> GetAllInTrash()
        {
            string sql = "select * from Users where Users_DeleteId = 0";
            return SqlHelper<Users>.Query(sql, null);
        }

        public IList<Users> GetByNickNameInTrash(string nickname)
        {
            string sql = "select * from Users where Users_DeleteId = 0 and Users_NickName like @Users_NickName";
            return SqlHelper<Users>.Query(sql, new Users() { Users_NickName = "%" + nickname + "%" });
        }

        public Users Login(string account, string password)
        {
            string sql = "select * from Users where Users_Account = @Users_Account and Users_Password = @Users_Password";
            return SqlHelper<Users>.Query(sql, new Users() { Users_Account = account, Users_Password = password }).FirstOrDefault();
        }
    }
}

using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class RolesManager
    {
        public int Add(Roles roles)
        {
            string sql = "insert into Roles(Roles_Id,Roles_Title,Roles_DeleteId,Roles_CreateTime,Roles_UpdateTime) " +
                         "values(@Roles_Id,@Roles_Title,@Roles_DeleteId,@Roles_CreateTime,@Roles_UpdateTime)";

            return SqlHelper<Roles>.ExecuteNonQuery(sql, roles);
        }

        public int Edit(Roles roles)
        {
            string sql = "update Roles set Roles_Title = @Roles_Title , Roles_UpdateTime = @Roles_UpdateTime where Roles_Id = @Roles_Id";
            return SqlHelper<Roles>.ExecuteNonQuery(sql, roles);
        }

        public int PutTrash(Guid id)
        {
            string sql = "update Roles set Roles_DeleteId = 0 where Roles_Id = @Roles_Id";
            return SqlHelper<Roles>.ExecuteNonQuery(sql, new Roles() { Roles_Id = id });
        }

        public int Restore(Guid id)
        {
            string sql = "update Roles set Roles_DeleteId = 1 where Roles_Id = @Roles_Id";
            return SqlHelper<Roles>.ExecuteNonQuery(sql, new Roles() { Roles_Id = id });
        }

        public int Delete(Guid id)
        {
            string sql = "delete from Roles where Roles_DeleteId = 0 and Roles_Id = @Roles_Id";
            return SqlHelper<Roles>.ExecuteNonQuery(sql, new Roles() { Roles_Id = id });
        }

        public IList<Roles> GetAll()
        {
            string sql = "select * from Roles where Roles_DeleteId = 1";
            return SqlHelper<Roles>.Query(sql, null);
        }

        public IList<Roles> GetByTitle(string title)
        {
            string sql = "select * from Roles where Roles_DeleteId = 1 and Roles_Title like @roles_Title";
            return SqlHelper<Roles>.Query(sql, new Roles { Roles_Title = "%" + title + "%" });
        }


        public Roles GetById(Guid id)
        {
            string sql = "select * from Roles where Roles_Id = @Roles_Id";
            return SqlHelper<Roles>.Query(sql, new Roles() { Roles_Id = id }).FirstOrDefault();
        }

        public IList<Roles> GetAllInTrash()
        {
            string sql = "select * from Roles where Roles_DeleteId = 0";
            return SqlHelper<Roles>.Query(sql, null);
        }

        public IList<Roles> GetByTitleInTrash(string title)
        {
            string sql = "select * from Roles where Roles_DeleteId = 0 and Roles_Title like @roles_Title";
            return SqlHelper<Roles>.Query(sql, new Roles { Roles_Title = "%" + title + "%" });
        }
    }
}

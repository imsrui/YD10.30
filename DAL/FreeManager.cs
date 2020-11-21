using Model.reception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FreeManager
    {
        public int Add(Free free)
        {
            string sql = "insert into Free( Free_Id, Free_ParentId ,Free_Name , Free_Title,Free_Price , Free_Publish , Free_Author ,Free_Content , Free_Catalohue, Free_Portion ,Free_CreateTime ,Free_UpdateTime) values(@Free_Id, @Free_ParentId ,@Free_Name , @Free_Title,@Free_Price , @Free_Publish ,@Free_Author ,@Free_Content ,@Free_Catalohue, @Free_Portion ,@Free_CreateTime ,@Free_UpdateTime)";
            return SqlHelper<Free>.ExecuteNonQuery(sql, free);
        }

        public int Edit(Free free)
        {
           
            string sql = "update Free set Free_ParentId=@Free_ParentId ,Free_Name=@Free_Name , Free_Title @Free_Title,Free_Price=@Free_Price , Free_Publish=@Free_Publish , Free_Author=@Free_Author ,Free_Content=@Free_Content , Free_Catalohue=@Free_Catalohue, Free_Portion=@Free_Portion , where Free_Id=@Free_Id  ";
            return SqlHelper<Free>.ExecuteNonQuery(sql, free);
        }
        public int Delete(Guid id)
        {
            string sql = "delete from Free where  Free_Id=@Free_Id";
            return SqlHelper<Free>.ExecuteNonQuery(sql, new Free() { Free_Id =id });
        }
        public IList<Free> GetAll() {
            string sql = "select  * from Free";
            return SqlHelper<Free>.Query(sql,null);
        }
        public IList<Free> GetByTitle(string title) {
            string sql = "select  * from Free where Free_Name like @Free_Name";
            return SqlHelper<Free>.Query(sql, new Free() { Free_Name = "%"+title+"%" });
        }
    }
}

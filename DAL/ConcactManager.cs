using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.reception;

namespace DAL
{
    public class ConcactManager
    {
        public int Add(Contact contact)
        {
            string sql = "insert into Concact(Contact_Id ,Contact_Address ,Contact_QQ,Contact_Phone,Contact_WorkTime ,Contact_QRCode ,Contact_DeleteId,Contact_Createtime,Contact_UpdateTime) values(@Contact_Id ,@Contact_Address ,@Contact_QQ,@Contact_Phone,@Contact_WorkTime ,@Contact_QRCode ,@Contact_DeleteId,2Contact_Createtime,@Contact_UpdateTime)";
            return SqlHelper<Contact>.ExecuteNonQuery(sql,contact);
        }
        public int Edit(Contact contact)
        {
            string sql = "uodate Contact set Contact_Address=Contact_Address ,Contact_QQ=@Contact_QQ,Contact_Phone=@Contact_Phone,Contact_WorkTime=@Contact_WorkTime,Contact_QRCode ,Contact_UpdateTime=@Contact_UpdateTime where Contact_Id=@Contact_Id ";
            return SqlHelper<Contact>.ExecuteNonQuery(sql, contact);
        }
        public int Delete(Guid id)
        {
            string sql = "Delete from Contact where Contact_Id=@Contact_Id";
            return SqlHelper<Contact>.ExecuteNonQuery(sql, new Contact() { Contact_Id=id });
        }
        public IList<Contact> GetAll(){

            string sql = "select * from Contact ";
            return SqlHelper<Contact>.Query(sql,null);
        }

    }
}

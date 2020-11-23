using Model.reception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class JsManager
    {
        public int Add(jieshu js)
        {
            string sql = "insert into jieshu(Id,Name,Title,Contact,Image,Link) values(@Id,@Name,@Title,@Contact,@Image,@Link)";
            return SqlHelper<jieshu>.ExecuteNonQuery(sql, js);
        }
        public int Edit(jieshu js) { string sql = "update jieshu set Name=@Name,Title=@Title,Contact=@Contact,Image=@Image,Link=@Link where Id=@Id "; return SqlHelper<jieshu>.ExecuteNonQuery(sql, js); }
        public int Delete(int id) { string sql = "delete from jieshu where Id=@Id"; return SqlHelper<jieshu>.ExecuteNonQuery(sql, new jieshu() { Id = id }); }
        public IList<jieshu> GetAll()
        {
            string sql = "select *from jieshu";
            return SqlHelper<jieshu>.Query(sql, null);
        }
        public IList<jieshu> GetName(string name) { string sql = "select * from jieshu where Name like @Name"; return SqlHelper<jieshu>.Query(sql,new jieshu() { Name="%"+name+"%"})}
    }
}

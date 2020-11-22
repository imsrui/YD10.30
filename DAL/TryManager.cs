using Model.reception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public  class TryManager
    {
        public int Add(Try try1) {
            string sql = "insert into Try(Contact,ParentId) values (@Contact,@ParentId)";
            return SqlHelper<Try>.ExecuteNonQuery(sql, try1);
        }

        public IList<Try> GetAll() {
            string sql = "select * from Try";
            return SqlHelper<Try>.Query(sql, null);
        }

        public IList<Try> GetByContact(string contact) {
            string sql = "select * from Try where Contact like @Contact";
            return SqlHelper<Try>.Query(sql,new Try() { Contact = "%" + contact + "%" });
        }
    }
}

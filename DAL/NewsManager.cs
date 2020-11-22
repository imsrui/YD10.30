using Model.reception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public   class NewsManager
    {
        public int Add(News news) {
            string sql = "insert into News(Title ,Image,content,CreateTime,ParentId) values(@Title ,@Image,@content,@CreateTime,@ParentId)";
            return SqlHelper<News>.ExecuteNonQuery(sql, news);
        }
        public IList<News> GetAll() { string sql = "select *from News";
            return SqlHelper<News>.Query(sql, null);
        }
        public IList<News> GetByTitle(string title) {
            string sql = "select *from News where Title like @Title";
            return SqlHelper<News>.Query(sql, new News() { Title = "%" + title + "%" });
        }
    }
}

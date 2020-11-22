using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.reception;
namespace DAL
{
    public class CatalogueManager
    {
        public int Add(Catalogue cl)
        {
            string sql = "insert into Catalogue(Title,Link) values(@Title,@Link)";
            return SqlHelper<Catalogue>.ExecuteNonQuery(sql, cl);
        }

        public int Edit(Catalogue cl)
        {
            string sql = "updata Catalogue set Title=@Title,,Link=@Link where Id = @id ";

            return SqlHelper<Catalogue>.ExecuteNonQuery(sql, cl);
        }
        public int Delete(int id)
        {
            string sql = "delete from Catalogue where Id = @id ";
            return SqlHelper<Catalogue>.ExecuteNonQuery(sql, new Catalogue() { Id = id });
        }
        public IList<Catalogue> GetALL()
        {
            string sql = "select * from Catalogue";

            return SqlHelper<Catalogue>.Query(sql, null);
        }
        public IList<Catalogue> GetByTitle(string title)
        {
            string sql = "select * from Catalogue where Title like @Title";
            return SqlHelper<Catalogue>.Query(sql, new Catalogue() { Title = "%" + title + "%" });
        }
    }
}

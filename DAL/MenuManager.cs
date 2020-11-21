using Model.reception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MenuManager
    {
        public int Add(Menu menu)
        {
            string sql = "insert into Menu(Menu_Id , Menu_Title , Menu_Href) values(@Menu_Id , @Menu_Title , @Menu_Href)";
            return SqlHelper<Menu>.ExecuteNonQuery(sql, menu);
        }
        public int Edit(Menu menu)
        {
            string sql = "update Menu set Menu_Title= @Menu_Title , Menu_Href =@Menu_Href  where Menu_Id=@Menu_Id";
            return SqlHelper<Menu>.ExecuteNonQuery(sql, menu);
        }
        public int Delete(Guid id)
        {
            string sql = "delete from Menu where Menu_Id=@Menu_Id";
            return SqlHelper<Menu>.ExecuteNonQuery(sql, new Menu() { Menu_Id = id });
        }
        public IList<Menu> GetAll()
        {
            string sql = "select * from Menu";
            return SqlHelper<Menu>.Query(sql, null);
        }
        public IList<Menu> GetByTitle(string title)
        {
            string sql = "select * from Menu where  Menu_Title like @Menu_Title";
            return SqlHelper<Menu>.Query(sql, new Menu() { Menu_Title = "%" + title + "%" });
        }
    }
}

using Model.reception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
   public  class MenuService
    {
        private readonly MenuManager mm = new MenuManager();
        public int Add(Menu menu)
        {
            return mm.Add(menu);
        }
        public int Edit(Menu menu)
        {
            return mm.Edit(menu);
        }
        public int Delete(Guid id)
        {
            return mm.Delete(id);
        }
        public IList<Menu> GetAll()
        {
            return mm.GetAll();
        }
        public IList<Menu> GetByTitle(string title)
        {
            return mm.GetByTitle(title);
        }
    }
}

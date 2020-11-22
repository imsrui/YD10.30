using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model.reception;

namespace BLL
{
    public class CatalohueService
    {
        private readonly CatalogueManager cm = new CatalogueManager();
        public int Add(Catalogue cl)
        {
            return cm.Add(cl);  
        }

        public int Edit(Catalogue cl)
        {
            return cm.Edit(cl);
        }
        public int Delete(int id)
        {
            return cm.Delete(id);
        }
        public IList<Catalogue> GetALL()
        {
            return cm.GetALL();
        }
        public IList<Catalogue> GetByTitle(string title)
        {
            return cm.GetByTitle(title);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model.reception;

namespace BLL
{
    public class JsService
    {
        private readonly JsManager jsm = new JsManager();
        public int Add(jieshu js)
        {
            return jsm.Add(js);
        }
        public int Edit(jieshu js) { return jsm.Edit(js); }
        public int Delete(int id) { return jsm.Delete(id); }
        public IList<jieshu> GetAll()
        {
            return jsm.GetAll();
        }
        public IList<jieshu> GetName(string name) { return jsm.GetName(name); }
    }
}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model.reception;

namespace BLL
{
   public class TryService
    {
        private readonly TryManager tm = new TryManager();
        public int Add(Try try1)
        {
            return tm.Add(try1);
        }

        public IList<Try> GetAll()
        {
            return tm.GetAll();
        }

        public IList<Try> GetByContact(string contact)
        {
            return tm.GetByContact(contact);
         
        }
    }
}

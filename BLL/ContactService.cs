using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model.reception;

namespace BLL
{
    public class ContactService
    {
        private readonly ConcactManager cm = new ConcactManager();
        public int Add(Contact contact)
        {
            return cm.Add(contact);
        }
        public int Edit(Contact contact)
        {
            return cm.Edit(contact);
        }
        public int Delete(Guid id)
        {
            return cm.Delete(id);
        }
        public IList<Contact> GetAll()
        {

            return cm.GetAll();
        }
    }
}

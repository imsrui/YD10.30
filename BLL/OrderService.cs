using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model.reception;

namespace BLL
{
    public class OrderService
    {
        private readonly Order1Manager om = new Order1Manager();
        public int Add(Order1 order1)
        {
            return om.Add(order1);
        }
        public int Edit(Order1 order1)
        {
            return om.Edit(order1);
        }
        public int Delete(Guid id)
        {
            return om.Delete(id);

        }
        public IList<Order1> GetAll()
        {

            return om.GetAll();
        }
        public IList<Order1> GetByName(string name)
        {
            return om.GetByName(name);
                }
    }
}

using DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.reception;

namespace BLL
{
    public class AboutService
    {
        private readonly AboutManager dal = new AboutManager();

        public int Add(About about)
        {
            return dal.Add(about);
        }

        public int Edit(About about)
        {
            return dal.Edit(about);
        }


        public About GetAll()
        {
            return dal.GetAll();
        }
    }
}

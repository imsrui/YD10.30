using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model.reception;

namespace BLL
{
   public  class NewsService
    {
        private readonly NewsManager nm = new NewsManager();
        public int Add(News news)
        {
            return nm.Add(news);
        }
        public IList<News> GetAll()
        {
            return nm.GetAll();
        }
        public IList<News> GetByTitle(string title)
        {
            return nm.GetByTitle(title);
        }
    }
}

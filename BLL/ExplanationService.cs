using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model.reception;

namespace BLL
{
    public class ExplanationService
    {
        private readonly ExplanationManager em = new ExplanationManager();
        public int Add(Explanation explanation)
        {
            return em.Add(explanation);
        }
        public int Edit(Explanation explanation)
        {
            return em.Edit(explanation);
        }
        public int Delet(Guid id)
        {
            return em.Delet(id);
        }
        public IList<Explanation> GetAll()
        {
            return em.GetAll();

        }
    }
}

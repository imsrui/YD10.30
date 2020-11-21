using Model.reception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ExplanationManager
    {
        public int Add(Explanation explanation)
        {
            string sql = "insert into Explanation(Explanation_Id ,LoanType_Id ,Explanation_Detail,Explanation_DeleteId,Explanation_CreateTime,Explanation_UpdateTime) values(@Explanation_Id ,@LoanType_Id ,@Explanation_Detail,@Explanation_DeleteId,@Explanation_CreateTime,@Explanation_UpdateTime) ";
            return SqlHelper<Explanation>.ExecuteNonQuery(sql, explanation);
        }
        public int Edit(Explanation explanation)
        {
            string sql = "update Explanation set LoanType_Id =@LoanType_Id,Explanation_Detail=@Explanation_Detail,Explanation_UpdateTime=@Explanation_UpdateTime where Explanation_Id=@Explanation_Id";
            return SqlHelper<Explanation>.ExecuteNonQuery(sql, explanation);
        }
        public int Delet(Guid id)
        {
            string sql = "delete from Explanation where Explanation_Id=@Explanation_Id ";
            return SqlHelper<Explanation>.ExecuteNonQuery(sql, new Explanation() { Explanation_Id = id });
            
                }
        public IList<Explanation> GetAll() { string sql = "select *from Explanation ";
            return SqlHelper<Explanation>.Query(sql, null);
        }
    }
}

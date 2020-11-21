using Model.reception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class Order1Manager
    {
        public int Add(Order1 order1) {
            string sql = "insert into Order1(Order_Id,Order_Name,Order_Price,Order_Content,Order_WebMenusId,Order_CreateTime,Order_UpdateTime) values(@Order_Id,@Order_Name,@Order_Price,@Order_Content,@Order_WebMenusId,@Order_CreateTime,@Order_UpdateTime)";
            return SqlHelper<Order1>.ExecuteNonQuery(sql,order1);
        
        }
        public int Edit(Order1 order1)
        {
            string sql = "update Order1 set Order_Name=@Order_Name,Order_Price=@Order_Price,Order_Content=@Order_Content,Order_WebMenusId=@Order_WebMenusId where Order_Id=@Order_Id";
            return SqlHelper<Order1>.ExecuteNonQuery(sql, order1);

        }
        public int Delete(Guid id)
        {
            string sql = "Delete from Order1 where Order_Id=@Order_Id";
            return SqlHelper<Order1>.ExecuteNonQuery(sql, new Order1() { Order_Id =id });

        }
        public IList<Order1> GetAll() {

            string sql = "select * from Order1";
            return SqlHelper<Order1>.Query(sql,null);
        }
        public IList<Order1> GetByName(string name)
        {

            string sql = "select * from Order1 where Order_Name like @Order_Name";
            return SqlHelper<Order1>.Query(sql, new Order1() { Order_Name = name });
        }

    }
}

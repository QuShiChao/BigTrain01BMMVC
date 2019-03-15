using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //借还图书记录表
    public class ReaderOperateRecord
    {
        public int Id { get; set; }
        public int Rid { get; set; }
        public string Rname { get; set; }//读者姓名
        public int Bid { get; set; }
        public string Bname { get; set; }
        public int Num { get; set; }
        public DateTime BorrowTime { get; set; }//--借书时间
        public int Aid { get; set; }//--可借时间
        public DateTime ReturnTime { get; set; }//--还书时间
        public int Status { get; set; }//0借书中 超时未还1 超时已还2 已还3 破损4 丢失5 
    }
}

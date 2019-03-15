using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //图书表
    public class BookInfo
    {
        public int Bid { get; set; }
        public string Bname { get; set; }//书名
        public double Bprice { get; set; }//价格
        public int Cid { get; set; }//类别ID
        public string Cname { get; set; }//类别名称
        public int Lid_1 { get; set; }//柜
        public string Lname1 { get; set; }
        public int Lid_2 { get; set; }//左右排数
        public string Lname2 { get; set; }
        public int Lid_3 { get; set; }//列数
        public string Lname3 { get; set; }
        public string BookDescription { get; set; }//书籍描述
        public int Inventory { get; set; }//库存
        public int Status { get; set; }//上下架 默认下架0 上架1
    }
}

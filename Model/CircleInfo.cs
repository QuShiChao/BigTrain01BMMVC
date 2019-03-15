using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CircleInfo
    {
        public int Id { get; set; }
        public int Rid { get; set; }//读者ID
        public string Rname { get; set; }//读者名称
        public ReaderInfo Reader { get; set; }//读者对象
        public string Comment { get; set; }//评论
        public DateTime PublishTime { get; set; }//发表时间
        public int Status { get; set; }//--0未审核，1审核通过，2审核失败

    }
}

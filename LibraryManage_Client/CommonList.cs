using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Newtonsoft.Json;

namespace LibraryManage_Client
{
    public class CommonList<T>
    {
        public static List<T> GetList()
        {
            Type type = typeof(T);
            string url = "";
            switch (type.Name)
            {
                case "AdminInfo":
                    url = "api/LibraryManage/GetAdmin";
                    break;
                case "BookCategory":
                    url = "api/LibraryManage/GetCategory";
                    break;
                case "BookInfo":
                    url = "api/LibraryManage/GetBook";
                    break;
                case "BookLocation":
                    url = "api/LibraryManage/GetLocation";
                    break;
                case "BorrowTimeArea":
                    url = "api/LibraryManage/GetTime";
                    break;
                case "CircleInfo":
                    url = "api/LibraryManage/GetCircle";
                    break;
                case "ReaderInfo":
                    url = "api/LibraryManage/GetReader";
                    break;
                case "ReaderOperateRecord":
                    url = "api/LibraryManage/GetOperateRecord";
                    break;
            }
            string json = HttpClientHelper.SendRequest(url,"get");
            List<T> list = JsonConvert.DeserializeObject<List<T>>(json.ToString());
            return list;
        }
    }
}

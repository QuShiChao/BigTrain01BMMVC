using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Model;

namespace LibraryManage_Client
{
    /// <summary>
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        //登录
        private void Btn_login_Click(object sender, RoutedEventArgs e)
        {
            List<AdminInfo> adminList = CommonList<AdminInfo>.GetList();
            string name = this.txt_userName.Text;
            string pwd = this.txt_Pwd.Password;
            AdminInfo admin = adminList.FirstOrDefault(a => a.Aname.Equals(name) && a.Apwd.Equals(pwd));
            if (admin == null)
            {
                MessageBox.Show("登录失败");
            }
            else
            {
                MessageBox.Show("登录成功");
            }
        }

        private void Btn_exit_Click(object sender, RoutedEventArgs e)
        {
            //关闭窗口
            this.Close();
            Environment.Exit(0);
        }
    }
}

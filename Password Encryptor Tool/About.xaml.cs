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

namespace Password_Encryptor_Tool
{
    /// <summary>
    /// About.xaml 的交互逻辑
    /// </summary>
    public partial class About : Window
    {
        public About()
        {
            InitializeComponent();
            contentText.Text = "Password Encryptor\r\n---------------------\r\n起源\r\n本软件源于iCloud云密钥串的一个高密码重复率的提示。这不得不让我重新思考如何去记忆密码。\r\n于是，Password Encryptor应运而生。\r\n\r\n注意：该项目尚处在测试阶段很多地方还不够成熟和完善。\r\n\r\n主要特性\r\n - 三段式密码记忆方式，把复杂的密码简化为容易记住的三段\r\n - 多层安全加密，让密码更安全\r\n - 16位复杂密码\r\n\r\n实验性特性\r\n - 字符加入，在密码中增添字符以更安全\r\n\r\n错误\r\n - 如若出现错误您可以通过提交issue的方法告知我\r\n - 您同样可以使用邮箱联系我：kucashu@droidbeta.com\r\n\r\n开源协议\r\n本项目采用GPL v3.0开源协议。\r\nGitHub：https://github.com/Kucashu/Password-Encryptor\r\n\r\n其他信息\r\n我的QQ：203377325\r\n博客：Kucashu.com\r\nQQ交流群：277211897";
        }


        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

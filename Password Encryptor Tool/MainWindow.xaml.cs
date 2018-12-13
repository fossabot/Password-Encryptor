using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Password_Encryptor_Tool
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /*
         * 
         * ███╗   ███╗██████╗ ███████╗    ███████╗███╗   ██╗ ██████╗██████╗ ██╗   ██╗██████╗ ████████╗
         * ████╗ ████║██╔══██╗██╔════╝    ██╔════╝████╗  ██║██╔════╝██╔══██╗╚██╗ ██╔╝██╔══██╗╚══██╔══╝
         * ██╔████╔██║██║  ██║███████╗    █████╗  ██╔██╗ ██║██║     ██████╔╝ ╚████╔╝ ██████╔╝   ██║   
         * ██║╚██╔╝██║██║  ██║╚════██║    ██╔══╝  ██║╚██╗██║██║     ██╔══██╗  ╚██╔╝  ██╔═══╝    ██║   
         * ██║ ╚═╝ ██║██████╔╝███████║    ███████╗██║ ╚████║╚██████╗██║  ██║   ██║   ██║        ██║   
         * ╚═╝     ╚═╝╚═════╝ ╚══════╝    ╚══════╝╚═╝  ╚═══╝ ╚═════╝╚═╝  ╚═╝   ╚═╝   ╚═╝        ╚═╝   
         * 
         */
        public static string MD5_16LEncrypt(string ConvertString) // 16位大写
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            string t2 = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(ConvertString)), 4, 8);
            t2 = t2.Replace("-", "");
            return t2;
        }
        public static string MD5_16BEncrypt(string ConvertString) // 16位小写
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            string t2 = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(ConvertString)), 4, 8);
            t2 = t2.Replace("-", "");
            t2 = t2.ToLower();
            return t2;
        }
        public string MD5_32LEncrypt(string ConvertString) // 32位大写
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            string t2 = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(ConvertString)));
            t2 = t2.Replace("-", "");
            return t2;
        }
        public string MD5_32BEncrypt(string ConvertString) // 32位小写
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            string t2 = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(ConvertString)));
            t2 = t2.Replace("-", "");
            return t2.ToLower();
        }

        /*
         * 
         * ███████╗██╗  ██╗ █████╗      ██╗  ██╗    ███████╗███╗   ██╗ ██████╗██████╗ ██╗   ██╗██████╗ ████████╗
         * ██╔════╝██║  ██║██╔══██╗     ╚██╗██╔╝    ██╔════╝████╗  ██║██╔════╝██╔══██╗╚██╗ ██╔╝██╔══██╗╚══██╔══╝
         * ███████╗███████║███████║█████╗╚███╔╝     █████╗  ██╔██╗ ██║██║     ██████╔╝ ╚████╔╝ ██████╔╝   ██║   
         * ╚════██║██╔══██║██╔══██║╚════╝██╔██╗     ██╔══╝  ██║╚██╗██║██║     ██╔══██╗  ╚██╔╝  ██╔═══╝    ██║   
         * ███████║██║  ██║██║  ██║     ██╔╝ ██╗    ███████╗██║ ╚████║╚██████╗██║  ██║   ██║   ██║        ██║   
         * ╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝     ╚═╝  ╚═╝    ╚══════╝╚═╝  ╚═══╝ ╚═════╝╚═╝  ╚═╝   ╚═╝   ╚═╝        ╚═╝   
         * 
         */


        public static string SHA512Encrypt(string source)
        {
            string result = "";
            byte[] buffer = Encoding.UTF8.GetBytes(source);// UTF-8 编码

            //64字节,512位
            SHA512CryptoServiceProvider SHA512 = new SHA512CryptoServiceProvider();
            byte[] h5 = SHA512.ComputeHash(buffer);

            result = BitConverter.ToString(h5).Replace("-", string.Empty);

            return result.ToLower();
        }
        /*
         * 
         *  ██████╗ ██████╗ ██████╗ ███████╗██████╗  ██████╗ ██╗  ██╗
         * ██╔════╝██╔═══██╗██╔══██╗██╔════╝██╔══██╗██╔═══██╗╚██╗██╔╝
         * ██║     ██║   ██║██║  ██║█████╗  ██████╔╝██║   ██║ ╚███╔╝ 
         * ██║     ██║   ██║██║  ██║██╔══╝  ██╔══██╗██║   ██║ ██╔██╗ 
         * ╚██████╗╚██████╔╝██████╔╝███████╗██████╔╝╚██████╔╝██╔╝ ██╗
         *  ╚═════╝ ╚═════╝ ╚═════╝ ╚══════╝╚═════╝  ╚═════╝ ╚═╝  ╚═╝
         *  
         */
        private void CodeON_Checked(object sender, RoutedEventArgs e)
        {
            codeBox.IsEnabled = true;
            // diffCode.IsEnabled = true;
        }



        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Encrypt_Click(object sender, RoutedEventArgs e)
        {
            int flag = 1;
            string finalPass = null;
            bool errorStatus = false;
            string unencryName, unencryPlatform, unencryCode;
            string[] encrypool = new string[20];
            // 加密池

            unencryName = Name.Text.Trim();
            unencryName = unencryName.ToLower();
            unencryPlatform = Platform.Text.Trim();
            unencryPlatform = unencryPlatform.ToUpper();
            unencryCode = codeBox.Text.Trim();
            if (unencryName == null || unencryName.Length == 0 || unencryName == "")
            {
                MessageBox.Show("错误的姓名参数!", "错误", MessageBoxButton.OK, MessageBoxImage.Error);
                errorStatus = true;
            }
            if (unencryPlatform == null || unencryPlatform.Length == 0 || unencryPlatform == "")
            {
                MessageBox.Show("错误的平台参数！", "错误", MessageBoxButton.OK, MessageBoxImage.Error);
                errorStatus = true;
            }
            if (CodeON.IsChecked==true)
            {
                if (unencryPlatform == null || unencryPlatform.Length == 0 || unencryPlatform == "")
                {
                    MessageBox.Show("错误的加密参数！", "错误", MessageBoxButton.OK, MessageBoxImage.Error);
                    errorStatus = true;
                }
            }
            else
            {
                unencryPlatform = "DefaultCode";
            }
            if (errorStatus == true)
            {
                MessageBox.Show("程序初始化错误！", "错误", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                encrypool[1] = SHA512Encrypt(unencryName);
                encrypool[2] = SHA512Encrypt(unencryPlatform);
                encrypool[3] = SHA512Encrypt(unencryCode);
                encrypool[4] = encrypool[1] + encrypool[2];
                encrypool[1] = SHA512Encrypt(encrypool[4]);
                encrypool[5] = encrypool[2] + encrypool[3];
                encrypool[2] = MD5_32LEncrypt(encrypool[5]);
                encrypool[6] = encrypool[1] + encrypool[3];
                encrypool[3] = SHA512Encrypt(encrypool[6]);
                encrypool[10] = SHA512Encrypt(encrypool[1] + encrypool[2] + encrypool[3]);
                encrypool[11] = SHA512Encrypt(encrypool[3] + encrypool[2] + encrypool[1]);
                encrypool[12] = SHA512Encrypt(encrypool[3] + encrypool[1] + encrypool[3]);
                encrypool[13] = SHA512Encrypt(encrypool[2] + encrypool[3] + encrypool[2]);
                encrypool[14] = MD5_32BEncrypt(encrypool[10]) + MD5_32LEncrypt(encrypool[11]) + MD5_32BEncrypt(encrypool[12]) + MD5_32LEncrypt(encrypool[13]);
                char[] encryChar = encrypool[14].ToCharArray();
                char[] passChar = new char[20];
                for (int loop = 1; loop <= 128; loop += 8)
                {
                    passChar[flag] = encryChar[loop-1];
                    flag++;
                }

                if (diffCode.IsChecked == true)
                {
                    int modSum_1 = (int)encryChar[0] % 7;
                    int modSum_2 = (int)encryChar[1] % 15;
                    int modSum_3 = (int)encryChar[2] % 15;
                    int modChar_1 = (int)encryChar[0] % 9;
                    int modChar_2 = (int)encryChar[1] % 6;
                    int modChar_3 = (int)encryChar[2] % 5;
                    char[] charpool_1 = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')' }; // 10位
                    char[] charpool_2 = { '-', '=', '+', '{', '}', '[', ']' }; //7位
                    char[] charpool_3 = { ':', ';', '/', '?', '<', '>' }; //6位
                    passChar[modSum_1] = charpool_1[modChar_1];
                    passChar[modSum_2] = charpool_2[modChar_2];
                    passChar[modSum_3] = charpool_3[modChar_3];

                }

                    for (int loop = 1; loop <= 16; loop += 1)
                {
                    finalPass += passChar[loop];
                }

                Clipboard.SetDataObject(finalPass, true);
                MessageBox.Show("生成的密码为：" + finalPass + "\r\n密码结果已复制入剪切板。","结果", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }

        private void DiffCode_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}
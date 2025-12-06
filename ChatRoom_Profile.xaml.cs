using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CatTalk
{
    /// <summary>
    /// UserControl1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ChatRoom_Profile : UserControl
    {
        public int id = -1;
        public ChatRoom_Profile()
        {
            InitializeComponent();
        }

        public string NickName
        {
            get
            {
                return profile_nickname.Text;
            }
            set
            {
                profile_nickname.Text = value;
            }
        }

        public string Time
        {
            get
            {
                return profile_time.Text;
            }
            set
            {
                profile_time.Text = value;
            }
        }

        public string LastContent
        {
            get
            {
                return profile_last_content.Text;
            }
            set
            {
                profile_last_content.Text = value;
            }
        }

        private void UserControl_MouseEnter(object sender, MouseEventArgs e)
        {
            BG.Background = new SolidColorBrush(Color.FromRgb(248, 248, 248));
        }

        private void UserControl_MouseLeave(object sender, MouseEventArgs e)
        {
            BG.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }
    }
}

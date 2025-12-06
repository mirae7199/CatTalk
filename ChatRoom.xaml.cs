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
using System.Windows.Shapes;

namespace CatTalk
{
    /// <summary>
    /// ChatRoom.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ChatRoom : Window
    {
        public List<Message> messages = new List<Message>();
        public ChatRoom()
        {
            InitializeComponent();
        }

        void SenderOpacity(object sender, double opacity)
        {
            (sender as FrameworkElement).Opacity = opacity;
        }

        private void TopGrid_CloseButton_MouseEnter(object sender, MouseEventArgs e)
        {
            DragMove();
        }

        private void TopGrid_CloseButton_MouseLeave(object sender, MouseEventArgs e)
        {
            SenderOpacity(sender, 1);
        }

        private void TopGrid_CloseButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        void Send_Message()
        {
            int n = messages.Count;
            messages.Add(new Message());
            messages[n].isMe = true;
            messages[n].Text = Send_TextBox.Text;
            Send_TextBox.Text = "";

            messages[n].VerticalAlignment = VerticalAlignment.Top;
            messages[n].HorizontalAlignment = HorizontalAlignment.Right;
            double sum_y = 0;
            try
            {
                sum_y = messages[n - 1].Margin.Top + messages[n - 1].Height - 5;
            }
            catch
            {
                sum_y = 0;
            }

            messages[n].Margin = new Thickness(0, sum_y + 10, 0, 0);
            ChatGrid.Children.Add(messages[n]);
        }

        void Recive
    }
}

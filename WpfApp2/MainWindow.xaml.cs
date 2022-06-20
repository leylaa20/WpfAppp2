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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            chats = new List<Button> { a, ma, e, o, mb, np, dj };
        }

        public List<Button> chats { get; set; }

        private void send_Click(object sender, RoutedEventArgs e)
        {
            tchat.Text = tbox_write.Text;
            //var c = tchat.Text.ToList();
            //c.AddRange(tbox_write.Text);
            tbox_write.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                tbox_online.Text = (string)btn.Content;
            }
        }

        private void tbox_search_MouseEnter(object sender, MouseEventArgs e)
        {
            foreach (var chat in chats)
            {
                if (chat.Content.ToString().Contains(tbox_search.Text))
                {
                    MessageBox.Show(chat.Content.ToString());

                }
            }



        }
    }
}

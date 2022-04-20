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

namespace WpfApp9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd1_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ZBox1.Text) && !ZList1.Items.Contains(ZBox1.Text))
            {
                ZList1.Items.Add(ZBox1.Text);
                ZBox1.Clear();
            }
        }

        private void btnAdd2_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ZBox2.Text) && !ZList2.Items.Contains(ZBox2.Text))
            {
                ZList2.Items.Add(ZBox2.Text);
                ZBox2.Clear();
            }
        }
        
       private void btnAdd3_Click(object sender, EventArgs e)
        {
            int n = ZList1.Items.Count;
            ZBox1_Copy.Text = n.ToString();
        }
    }
}


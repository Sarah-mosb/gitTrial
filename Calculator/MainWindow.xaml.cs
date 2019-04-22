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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int? x;
        int? y;
        string operand;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void GetElement(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void GetElement(object sender, MouseEventArgs e)
        {
            Button btn = ((Button)e.OriginalSource);
            string val= btn.Content.ToString();
          
            if(val=="*"||val=="/"||val=="+"||val=="_")
            {
                operand = val;
                x = int.Parse(txtBox.Text);
                txtBox.Text = "";
            }
            else if(val=="=")
            {
                y = int.Parse(txtBox.Text);
                if(x!= null &&  y!=null && operand != null)
                {
                    switch (operand)
                    {
                        case "*":
                            txtBox.Text = (x * y).ToString();
                            break;
                        case "/":
                            txtBox.Text = (x /y).ToString();
                            break;
                        case "+":
                            txtBox.Text = (x + y).ToString();
                            break;
                        case "_":
                            txtBox.Text = (x - y).ToString();
                            break;

                    }
                }
                else
                {
                    MessageBox.Show("An operation is missing");
                }
               
            }
            else
            {
                txtBox.Text += val;
            }
            
        
        }

        private void Subtract(object sender, RoutedEventArgs e)
        {
         
        }
    }
}

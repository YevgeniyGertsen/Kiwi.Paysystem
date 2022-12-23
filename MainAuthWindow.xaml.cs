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

namespace Kiwi.Paysystem
{
    /// <summary>
    /// Логика взаимодействия для MainAuthWindow.xaml
    /// </summary>
    public partial class MainAuthWindow : Window
    {
        public MainAuthWindow()
        {
            InitializeComponent();           
        }
      
        private void miOperatorList_Click(object sender, RoutedEventArgs e)
        {
            frameMain.Source = new Uri("pageOperatorList.xaml", 
                UriKind.RelativeOrAbsolute);
        }

        private void miClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void miAddOperatorList_Click(object sender, RoutedEventArgs e)
        {

        }
    }
  
}

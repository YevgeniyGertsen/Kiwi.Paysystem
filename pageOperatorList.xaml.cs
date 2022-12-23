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
using Kiwi.Paysystem.lib;

namespace Kiwi.Paysystem
{
    /// <summary>
    /// Логика взаимодействия для pageOperatorList.xaml
    /// </summary>
    public partial class pageOperatorList : Page
    {
        public pageOperatorList()
        {
            InitializeComponent();

            OperatorService operatorService = new OperatorService();
            lvOperatorList.ItemsSource = operatorService.GetOperators();
        }

        private void btnEditData_Click(object sender, RoutedEventArgs e)
        {
            Operators data = (Operators)lvOperatorList.SelectedItem;

            _pageAddOperator pad = new _pageAddOperator(data);

            MainAuthWindow._frameMain.Navigate(pad);
            
            //= 
            //    new Uri("_pageAddOperator.xaml",
            //    UriKind.RelativeOrAbsolute);
        }

    }
}

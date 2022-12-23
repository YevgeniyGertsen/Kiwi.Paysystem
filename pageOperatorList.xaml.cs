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

            //List<Operator> operators = new List<Operator>();
            //operators.Add(new Operator()
            //{
            //    OperatorId = 1,
            //    Prefix = "+7 777",
            //    Logo = "https://beeline.kz/binaries/content/gallery/mainsite/app-logo.jpg",
            //    Name = "Beeline",
            //    Percent = 0.5
            //});

            // lvOperatorList.Items.Add(operators);
            OperatorService operatorService = new OperatorService();

            lvOperatorList.ItemsSource = operatorService.GetOperators();

            //WrapPanel wp = new WrapPanel();
            //wp.Children.Add(new Label() { Content="+7 777"});
            //wp.Children.Add(new Label() { Content = "logo" });
            //wp.Children.Add(new Label() { Content = "Beeline" });
            //wp.Children.Add(new Label() { Content = "0.5%" });

            //lbxOperatorList.Items.Add(wp);
            //lbxOperatorList.Items.Add("test");
        }

        private void btnEditData_Click(object sender, RoutedEventArgs e)
        {
            Operators data = (Operators)lvOperatorList.SelectedItem;
        }

    }
}

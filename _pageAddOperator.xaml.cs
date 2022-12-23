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
    /// Логика взаимодействия для _pageAddOperator.xaml
    /// </summary>
    public partial class _pageAddOperator : Page
    {
        private Operators _operators { get; set; }
        private OperatorService _operatorService { get; set; }
        public _pageAddOperator() :this(null)
        {

        }
        public _pageAddOperator(Operators operators)
        {
            InitializeComponent();
            if (operators == null)
            {
                btnAdd.Content = "Add";
            }
            else
            {
                btnAdd.Content = "Edit";
                tbxLogo.Text = operators.Logo;
                tbxName.Text = operators.Name;
                tbxPhone.Text = operators.Phone;
                tbxPrecent.Text = operators.Precent.ToString();
            }

            _operators = operators;
        }
        
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if(_operators == null)
            {
                Operators op = new Operators();
                op.Logo = tbxLogo.Text;
                op.Name = tbxLogo.Text;
                op.Phone = tbxPhone.Text;
                op.Precent = Convert.ToDouble(tbxPrecent.Text);
                op.CreateDate = (DateTime)dpCreateDate.SelectedDate;
                if(_operatorService.AddOperator(op))
                {
                    MessageBox.Show("Added");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
               
            }

            pageOperatorList pad = new pageOperatorList();
            MainAuthWindow._frameMain.Navigate(pad);
        }
    }
}

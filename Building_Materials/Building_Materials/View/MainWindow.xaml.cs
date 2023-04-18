using Building_Materials.ViewModel;
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

namespace Building_Materials
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppData.db = new BaseModel.Building_MaterialsTradeEntities();
           
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = AppData.db.User.FirstOrDefault(x => x.UserLogin == txbLogin.Text && x.UserPassword == txPassword.Password);
                if (userObj == null)
                {
                    MessageBox.Show("Данные неверны, введите капчу");
                    var newForm = new Captcha(); //create your new form.
                    newForm.Show(); //show the new form.
                    this.Close(); //only if you want to close the current form.

                }
                else
                {

                    MessageBox.Show("Вы вошли в систему");


                }
            }
            catch (Exception EX)
            {

                MessageBox.Show("Ошибка");
            }
        }
    }
}


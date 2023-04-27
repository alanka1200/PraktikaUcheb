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
using System.Xml.Linq;

namespace PRATIKATEOR.Pages
{
    /// <summary>
    /// Interaction logic for CustomerPage.xaml
    /// </summary>
    public partial class CustomerPage : Page
    {
        public CustomerPage()
        {
            InitializeComponent();
            List<User> users = new List<User>();
            users.Add(new User(1, "Иванов", "Саня", 29, "Москва"));
            users.Add(new User(2, "Ничепоренко", "Олег", 39, "Барселона"));
            users.Add(new User(3, "Сосунков", "Глеб", 19, "Екатиренбург"));
            UserList.ItemsSource = users;
        }
    }
}

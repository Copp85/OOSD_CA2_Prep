using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace CA2_prep
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

        string[] firstnames = { "MARY", "PATRICIA", "LINDA", "BARBARA", "ELIZABETH", "JENNIFER", "MARIA", "SUSAN", "MARGARET",
            "DOROTHY", "LISA", "JAMES", "JOHN", "ROBERT", "MICHAEL", "WILLIAM", "DAVID", "RICHARD", "CHARLES", "JOSEPH", "THOMAS", };

        string[] lastnames = { "SMITH", "JOHNSON", "WILLIAMS", "JONES", "BROWN", "DAVIS", "MILLER", "WILSON", "MOORE", "TAYLOR",
            "ANDERSON", "THOMAS", "JACKSON", "WHITE", "HARRIS", "MARTIN", "THOMPSON", "ROBINSON", "CLARK", "LEWIS", "LEE", };

        public MainWindow()
        {
            InitializeComponent();
        }

        private Employee GetRandomEmployee(Random randomFactory)
        {
            Random rf = new Random();

            int randomNumberName = randomFactory.Next(0, firstnames.Count());
            string randomFName = firstnames[randomNumberName];

            int randomNumberSurname = randomFactory.Next(0, lastnames.Count());
            string randomSName = firstnames[randomNumberSurname];

            decimal randomSalary = (decimal)randomFactory.Next(1, 100000);

            Employee randomEmployee = new Employee(randomFName, randomSName, randomSalary);

            return randomEmployee;
        }
    }
}

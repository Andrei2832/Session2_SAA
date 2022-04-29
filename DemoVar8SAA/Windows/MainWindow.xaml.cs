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
using DemoVar8SAA.Entity;

namespace DemoVar8SAA
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
        public List<String> sortItem = new List<string>();
        public List<String> filterItem = new List<string>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string[] listSort = { "Сортировка", "наименование", "размер скидки", "размер скидки" };
            sortItem.AddRange(listSort);
            sort.ItemsSource = sortItem;
            sort.SelectedIndex = 0;

            filterItem.Add("Фильтрация");
            List<String> listFilter = AppData.context.AgentType.Select(i => i.Title).ToList();
            filterItem.AddRange(listFilter);
            filter.ItemsSource = filterItem;
            filter.SelectedIndex = 0;

        }
        private void search_GotFocus(object sender, RoutedEventArgs e)
        {
            if (search.Text == "Введите для поиска")
            {
                search.Text = "";
            }
        }

        private void search_LostFocus(object sender, RoutedEventArgs e)
        {
            if (search.Text == "" || search.Text.Trim() == "")
            {
                search.Text = "Введите для поиска";
            }
        }
    }
}

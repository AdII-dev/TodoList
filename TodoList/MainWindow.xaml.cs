using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TodoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();


        }


        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Ha valóban ki szeretne lépni, nyomja meg az 'Ok' gombot.");
            Application.Current.Shutdown();
        }
        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Megakadályozzuk az ablak bezárását
            e.Cancel = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Lista.Items.Clear();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Item hozzáadása a listához
            string newItem = Feladat.Text;
            if (!string.IsNullOrEmpty(newItem))
            {
                Lista.Items.Add(newItem); 
                Feladat.Text = ""; 
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            // Ellenőrizzük, hogy van-e kijelölt elem a ListBox-ban
            if (Lista.SelectedIndex != -1)
            {
                // Töröljük az elemet az ObservableCollection-ból a kijelölt index alapján
                Lista.Items.RemoveAt(Lista.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Válasszon ki egy elemet a törléshez!");
            }
        }
    }
}
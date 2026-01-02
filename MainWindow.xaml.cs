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

namespace PRODIGY_SD_03
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
        private void OnlyNumbers(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, out _);
        }

        private void deletebnt_Click(object sender, RoutedEventArgs e)
        {
            if (ContactGrid.SelectedItem == null)
            {
                MessageBox.Show("Please select Contact to delete");
                return;
            }
            ContactGrid.Items.Remove(ContactGrid.SelectedItem);
        }

        private void Addbnt_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameBox.Text) || string.IsNullOrWhiteSpace(PhoneBox.Text) || string.IsNullOrWhiteSpace(EmailBox.Text))
            {
                MessageBox.Show("Enter all fields");
                return;
            }

            var contact = new Contact
            {
                Name = NameBox.Text,
                Phone = PhoneBox.Text,
                Email = EmailBox.Text

            };

            ContactGrid.Items.Add(contact);
            NameBox.Clear();
            PhoneBox.Clear();
            EmailBox.Clear();

        }
    }
}

using SmartComponents;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace OpenSilverWithSmartComponents
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // Enter construction logic here...
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Name: {txtName.Text}, Email: {txtEmail.Text}, Password: {txtPassword.Password}");
        }
    }
}

using System;
using System.Windows;
using System.Windows.Controls;

namespace vboy
{
    public partial class Dashboard : System.Windows.Controls.UserControl
    {
        
        public Dashboard()
        {
            InitializeComponent();
        }
        private void Home_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("foo bar");
        
        }
        private void Edit_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("foo bar");
        
        }
        private void Project_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("foo bar");
        
        }
        private void Settings_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("foo bar");
        
        }
        private void Quit_Click(object sender, RoutedEventArgs e) {
            Application.Current.Shutdown();
        
        }
    }
}
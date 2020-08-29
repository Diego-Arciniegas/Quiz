using System;
using System.Collections.Generic;
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

namespace Quiz_Arciniegas_Diego
{
    /// <summary>
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string WeaponName = txtWeaponName.Text;
            string RarityOfTheWeapon = lblRarityOfTheWeapon.Content.ToString();
            string Category = cbxCategory.Text;
            string Level = srLevel.Value.ToString();
            txtResults.Text = "-WeaponName: " + WeaponName + "\n"+ "-RarityOfTheWeapon: " + RarityOfTheWeapon + "\n"+ "-Category: " + Category + "\n"+ "-Level: " + Level;

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.IsChecked.Value)
            {
                lblRarityOfTheWeapon.Content = rb.Content.ToString();
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.IsChecked.Value)
            {
                lblRarityOfTheWeapon.Content = rb.Content.ToString();
            }
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.IsChecked.Value)
            {
                lblRarityOfTheWeapon.Content = rb.Content.ToString();
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.frameMain.NavigationService.Navigate(new Login());
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblLevel.Content = "-Level: " + srLevel.Value.ToString();
        }
    }
}
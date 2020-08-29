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
            string CharacterName = txtCharacterName.Text;
            string CharacterRarity = lblCharacterRarity.Content.ToString();
           
            txtResults.Text = CharacterName +","+ CharacterRarity; 
            
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if(rb.IsChecked.Value)
            {
                lblCharacterRarity.Content = rb.Content.ToString(); 
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.IsChecked.Value)
            {
                lblCharacterRarity.Content = rb.Content.ToString();
            }
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.IsChecked.Value)
            {
                lblCharacterRarity.Content = rb.Content.ToString();
            }
        }
    }
}

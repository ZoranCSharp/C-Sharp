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

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        public int MyProperty
        {
            get { return (int)GetValue(myDependencyProperty); }
            set { SetValue(myDependencyProperty, value); }
        }

        public static readonly DependencyProperty myDependencyProperty = 
            DependencyProperty.Register("MyProperty", typeof(int), typeof(MainWindow), new PropertyMetadata(0));

        public Sum SumObj { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            //MySlider.Value = 30;
            //MyTextBox.Text = MySlider.Value.ToString();

            //SumObj = new Sum { Num1 = "1", Num2 = "3" };
            //this.DataContext = SumObj;

            List<Match> matches = new List<Match>();
            matches.Add(new Match() { Team1 = "Bayern Munich", Team2 = "Real Madrid", Score1 = 3, Score2 = 2, Completion = 85 });
            matches.Add(new Match() { Team1 = "Team 1", Team2 = "Team 4", Score1 = 1, Score2 = 2, Completion = 85 });
            matches.Add(new Match() { Team1 = "Tema 2", Team2 = "Team 5", Score1 = 3, Score2 = 0, Completion = 50 });
            matches.Add(new Match() { Team1 = "Team 3", Team2 = "Team 6", Score1 = 1, Score2 = 1, Completion = 25 });
            //lbMatches.ItemsSource = matches;

            //comboBoxColors.ItemsSource = typeof(Colors).GetProperties();
            //rbMaybe.IsChecked = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thanks for clicking me!");
        }

        private void Button_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Mouse Up - Bubble Event!");
        }

        private void Button_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Preview Mouse Up - Tunneling Event!");
        }

        private void Button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Preview Mouse Left Button Down - Tunneling Event!");
        }

        private void Button_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Preview Mouse Right Button Up - Tunneling Event!");
        }

        public class Match
        {
            public int Score1 { get; set; }
            public int Score2 { get; set; }

            public string Team1 { get; set; }
            public string Team2 { get; set; }

            public int Completion { get; set; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        //    if(lbMatches.SelectedItem != null)
        //    {
        //        MessageBox.Show("Selected Match: " + (lbMatches.SelectedItem as Match).Team1 + " " 
        //            + (lbMatches.SelectedItem as Match).Score1 + " " 
        //            + (lbMatches.SelectedItem as Match).Score2 + " " 
        //            + (lbMatches.SelectedItem as Match).Team2);
        //    }
        }

        private void CbAllTopings_Checked(object sender, RoutedEventArgs e)
        {
            //bool newVal = (cbAllTopings.IsChecked == true);
            //cbSalami.IsChecked = newVal;
            //cbMozarella.IsChecked = newVal;
            //cbMushrooms.IsChecked = newVal;
        }

        private void CbSalami_Checked(object sender, RoutedEventArgs e)
        {
            //cbAllTopings.IsChecked = null;
            //if((cbSalami.IsChecked == true) && (cbMozarella.IsChecked == true) && (cbMushrooms.IsChecked == true))
            //{
            //    cbAllTopings.IsChecked = true;
            //}
            //if ((cbSalami.IsChecked == false) && (cbMozarella.IsChecked == false) && (cbMushrooms.IsChecked == false))
            //{
            //    cbAllTopings.IsChecked = false;
            //}
        }

        private void No_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please say yes!");
        }

        private void Maybe_Checked(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Please say yes!");
        }

        private void Yes_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank You!");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Welcome {tbUsername}");
        }
    }
}

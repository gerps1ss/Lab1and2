using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab1and2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //CheckBox checkBox = new CheckBox() { Content = "Новый флажок", MinHeight = 20, IsChecked = true };
            //checkBox.Checked += checkBox1_Checked;
            //stackPanel.Children.Add(checkBox);


            //RadioButton rb = new RadioButton() { IsChecked = true, GroupName = "Boot", Content="Boot4" };
            //rb.Checked += Rb_Checked;
            //stackPanel.Children.Add(rb);

        }
        private void Rb_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            MessageBox.Show(rb.Content.ToString());
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            MessageBox.Show(chBox.Content.ToString() + " отмечен");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Кнопка нажата");
        }

        private void escButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Состояние кнопки: " + (sender as ToggleButton).IsChecked);
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        //private void checkBox_Checked(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show(checkBox.Content.ToString() + " отмечен");
        //}

        //private void checkBox_Unchecked(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show(checkBox.Content.ToString() + " не отмечен");
        //}

        //private void checkBox_Indeterminate(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show(checkBox.Content.ToString() + " в неопределённом состоянии");
        //}


        //private void RadioButton_Checked(object sender, RoutedEventArgs e)
        //{
        //    if (RadioButton_Boot1.IsChecked == true)
        //        MessageBox.Show(RadioButton_Boot1.Content.ToString());
        //    else if (RadioButton_Boot2.IsChecked == true)
        //        MessageBox.Show(RadioButton_Boot2.Content.ToString());
        //    else if (RadioButton_Boot3.IsChecked == true)
        //        MessageBox.Show(RadioButton_Boot3.Content.ToString());
        //}
    }
}

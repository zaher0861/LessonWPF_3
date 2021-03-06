using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace LessonWPF_3
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

        //private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    string fontName = (sender as ComboBox).SelectedItem as string;
        //    if (textBox != null)
        //    {
        //        textBox.FontFamily = new FontFamily(fontName);
        //    }
        //}

        //private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        //{
        //    string fontHeight = (sender as ComboBox).SelectedItem as string;
        //    if (textBox != null)
        //    {
        //        textBox.FontSize = Convert.ToDouble(fontHeight);
        //    }
        //}

        //private void BoldExecuted(object sender, RoutedEventArgs e)
        //{
        //    if (textBox != null)
        //    {
        //        textBox.FontWeight = FontWeights.Bold;
        //    }
        //}

        private void ItalicExecuted(object sender, RoutedEventArgs e)
        {
            if (textBox!= null)
            {
                textBox.FontStyle = FontStyles.Italic;
            }
        }

        private void UnderlineExecuted(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.TextDecorations = TextDecorations.Underline;
            }
        }

        private void BlackExecuted(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Black;
            }
        }

        private void RedExecuted(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Red;
            }
        }

        private void OpenExecuted(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog()==true)
            {
                textBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void SaveExecuted(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog()==true)
            {
                File.WriteAllText(saveFileDialog.FileName, textBox.Text);
            }
        }

        private void ExitExecuted(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void LightStyleExecuted(object sender, RoutedEventArgs e)
        {
            Uri uriLight = new Uri("Light.xaml", UriKind.Relative);
            ResourceDictionary resourceLight = Application.LoadComponent(uriLight) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceLight);
            DarkMenu.IsChecked = false;
        }
        private void DarkStyleExecuted(object sender, RoutedEventArgs e)
        {
            Uri uriDark = new Uri("Dark.xaml", UriKind.Relative);
            ResourceDictionary resourceDark = Application.LoadComponent(uriDark) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDark);
            LightMenu.IsChecked = false;
        }
    }
}

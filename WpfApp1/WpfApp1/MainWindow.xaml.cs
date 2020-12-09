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
using System.ComponentModel;

using System.Runtime.CompilerServices;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string m_text;
        private Model m_model;
        public MainWindow()
        {
            InitializeComponent();
            m_model = new Model();
            var vm = new ViewModel();
            this.DataContext = new { StringX = m_model.m_stringX ,FreeText = vm.Message};
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CDCT.Models;

namespace CDCT
{
    /// <summary>
    /// Lógica de interacción para Inicio.xaml
    /// </summary>
    public partial class Inicio : INotifyPropertyChanged
    {
        public Inicio()
        {
            DataContext = this;
            InitializeComponent();

            title = NavigationMenuListBox.SelectedValue.ToString();
            Exit.Click += (s, e) => winmgr.cerrar(Application.Current);
            Exit.MouseEnter += (s, e) => Exit.Foreground = Brushes.Black;
            Exit.MouseLeave += (s, e) => Exit.Foreground = Brushes.White;
            Minimice.Click += (s, e) => WindowState = WindowState.Minimized;
            Minimice.MouseEnter += (s, e) => Minimice.Foreground = Brushes.Black;
            Minimice.MouseLeave += (s, e) => Minimice.Foreground = Brushes.White;
            
        }

        winmgr winmgr = new winmgr();

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string _title;
        public string title { 
            get { return _title; }
            set 
            { 
                if(_title != value)
                {
                    _title = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _Whidt;
        public int Whidt
        {
            get { return _Whidt; }
            set
            {
                if (_Whidt != value)
                {
                    _Whidt = value;
                    OnPropertyChanged();
                }
            }
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void NavigationMenuListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            title = NavigationMenuListBox.SelectedValue.ToString();
        }
    }
}

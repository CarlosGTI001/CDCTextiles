using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
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

namespace CDCT.Views
{
    /// <summary>
    /// Lógica de interacción para PedidosReceptor.xaml
    /// </summary>
    public partial class PedidosReceptor : UserControl
    {
        
        public PedidosReceptor()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Etiqueta etiqueta = new Etiqueta();
            etiqueta.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == true)
                picture2.Source = new BitmapImage(new Uri(open.FileName));
        }
    }
}

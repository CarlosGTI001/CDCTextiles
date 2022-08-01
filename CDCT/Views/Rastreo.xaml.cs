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

namespace CDCT.Views
{
    /// <summary>
    /// Lógica de interacción para Rastreo.xaml
    /// </summary>
    public partial class Rastreo : UserControl
    {
        public Rastreo()
        {
            InitializeComponent();
            BarraEstatus.Value = 100;
        }

        private void BarraEstatus_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //hacer que los estatus que no esten completos, se pongan de color gris y viseversa
            if (e.NewValue == 20)
            {
                BarraEstatus.Foreground = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFFF0000");
            }

            if (e.NewValue == 50)
            {
                BarraEstatus.Foreground = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFD97C0F");
            }
            if (e.NewValue == 82)
            {
                BarraEstatus.Foreground = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFB7C617");
            }
            if (e.NewValue == 100)
            {
                BarraEstatus.Foreground = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF008000");

            }
        }
    }
}

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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CDCT.Models;

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

            detalle.RastreoID = "CDC0001";
            detalle.RastreoEstatus = "Generado";
            detalle.RastreoFecha = new DateTime(2022, 07, 22, 07, 10, 00);
            detalle.Firma = "Carlos Toribio";
            detalleRastreo.Add(detalle);

            //detalle1.RastreoID = "CDC0001";
            //detalle1.RastreoEstatus = "Procesado";
            //detalle1.RastreoFecha = new DateTime(2022, 07, 23, 08, 10, 00);
            //detalle1.Firma = "Carlos Toribio";
            //detalleRastreo.Add(detalle1);

            //detalle2.RastreoID = "CDC0001";
            //detalle2.RastreoEstatus = "Enviado";
            //detalle2.RastreoFecha = new DateTime(2022, 07, 24, 09, 10, 00);
            //detalle2.Firma = "Carlos Toribio";
            //detalleRastreo.Add(detalle2);

            //detalle3.RastreoID = "CDC0001";
            //detalle3.RastreoEstatus = "Entregado";
            //detalle3.RastreoFecha = new DateTime(2022, 07, 24, 10, 10, 00);
            //detalle3.Firma = "Carlos Toribio";
            //detalleRastreo.Add(detalle3);

            detalle0.RastreoID = "CDC0002";
            detalle0.RastreoEstatus = "Generado";
            detalle0.RastreoFecha = new DateTime(2022, 07, 25, 11, 10, 00);
            detalle0.Firma = "Carlos Toribio";
            detalleRastreo.Add(detalle0);

            detalle10.RastreoID = "CDC0002";
            detalle10.RastreoEstatus = "Procesado";
            detalle10.RastreoFecha = new DateTime(2022, 07, 26, 12, 10, 00);
            detalle10.Firma = "Carlos Toribio";
            detalleRastreo.Add(detalle10);

            detalle20.RastreoID = "CDC0002";
            detalle20.RastreoEstatus = "Enviado";
            detalle20.RastreoFecha = new DateTime(2022, 07, 27, 10, 10, 00);
            detalle20.Firma = "Carlos Toribio";
            detalleRastreo.Add(detalle20);

            detalle00.RastreoID = "CDC0003";
            detalle00.RastreoEstatus = "Generado";
            detalle00.RastreoFecha = new DateTime(2022, 07, 28, 11, 10, 00);
            detalle00.Firma = "Carlos Toribio";
            detalleRastreo.Add(detalle00);

            detalle100.RastreoID = "CDC0003";
            detalle100.RastreoEstatus = "Procesado";
            detalle100.RastreoFecha = new DateTime(2022, 07, 29, 12, 10, 00);
            detalle100.Firma = "Carlos Toribio";
            detalleRastreo.Add(detalle100);

            detalle000.RastreoID = "CDC0004";
            detalle000.RastreoEstatus = "Generado";
            detalle000.RastreoFecha = new DateTime(2022, 07, 31, 11, 10, 00);
            detalle000.Firma = "Carlos Toribio";
            detalleRastreo.Add(detalle000);
            var d = Nombre.Content;
            var f = Apellido.Content;
           
        }
        List <DetalleRastreo> detalleRastreo = new List<DetalleRastreo>();
        DetalleRastreo detalle = new DetalleRastreo();
        DetalleRastreo detalle1 = new DetalleRastreo();
        DetalleRastreo detalle2 = new DetalleRastreo();
        DetalleRastreo detalle3 = new DetalleRastreo();
        DetalleRastreo detalle0 = new DetalleRastreo();
        DetalleRastreo detalle10 = new DetalleRastreo();
        DetalleRastreo detalle20 = new DetalleRastreo();
        DetalleRastreo detalle30 = new DetalleRastreo();
        DetalleRastreo detalle00 = new DetalleRastreo();
        DetalleRastreo detalle100 = new DetalleRastreo();
        DetalleRastreo detalle000 = new DetalleRastreo();
        RastreoPedido rastreo = new RastreoPedido();
        


        
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (RastreoCode.Text == "CDC0001")
            {
                rastreo = new RastreoPedido { ClienteNombre = "Juan", ClienteApellido = "Perez", ClienteID = "CDC-010101", RastreoID = "CDC0001", ClienteTelefono = "8091234567", DetalleRastreos = detalleRastreo };
                this.DataContext = rastreo;
            }
            if (RastreoCode.Text == "CDC0002")
            {
                rastreo = new RastreoPedido { ClienteNombre = "Mario", ClienteApellido = "Santana", ClienteID = "CDC-020202", RastreoID = "CDC0001", ClienteTelefono = "8091234567", DetalleRastreos = detalleRastreo };
                this.DataContext = rastreo;
            }
            if (RastreoCode.Text == "CDC0003")
            {
                rastreo = new RastreoPedido { ClienteNombre = "Maria", ClienteApellido = "Alvarez", ClienteID = "CDC-030303", RastreoID = "CDC0001", ClienteTelefono = "8091234567", DetalleRastreos = detalleRastreo };
                this.DataContext = rastreo;
            }
            if (RastreoCode.Text == "CDC0004")
            {
                rastreo = new RastreoPedido { ClienteNombre = "Marcos", ClienteApellido = "Polanco", ClienteID = "CDC-040404", RastreoID = "CDC0001", ClienteTelefono = "8091234567", DetalleRastreos = detalleRastreo };
                this.DataContext = rastreo;
            }

            ListaEstatus.ItemsSource = detalleRastreo.Where(a => a.RastreoID == RastreoCode.Text);
            if (detalleRastreo.Where(a=>a.RastreoID == RastreoCode.Text).Count() == 1)
            {
                //BarraEstatus.Value = 20;
                BarraEstatus.Foreground = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFFF0000");
                Duration duration = new Duration(TimeSpan.FromSeconds(1));
                DoubleAnimation doubleAnimation = new DoubleAnimation(20, duration);
                BarraEstatus.BeginAnimation(ProgressBar.ValueProperty, doubleAnimation);
            }

            if (detalleRastreo.Where(a => a.RastreoID == RastreoCode.Text).Count() == 2)
            {
                //BarraEstatus.Value = 50;
                
                Duration duration = new Duration(TimeSpan.FromSeconds(1));
                DoubleAnimation doubleAnimation = new DoubleAnimation(50, duration);
                BarraEstatus.BeginAnimation(ProgressBar.ValueProperty, doubleAnimation);
                BarraEstatus.Foreground = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFD97C0F");
            }
            if (detalleRastreo.Where(a => a.RastreoID == RastreoCode.Text).Count() == 3)
            {
                //BarraEstatus.Value = 82;
                Duration duration = new Duration(TimeSpan.FromSeconds(1));
                DoubleAnimation doubleAnimation = new DoubleAnimation(82, duration);

                BarraEstatus.BeginAnimation(ProgressBar.ValueProperty, doubleAnimation);
                BarraEstatus.Foreground = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFB7C617");

            }
            if (detalleRastreo.Where(a => a.RastreoID == RastreoCode.Text).Count() == 4)
            {
                //BarraEstatus.Value = 100;
                Duration duration = new Duration(TimeSpan.FromSeconds(1));
                DoubleAnimation doubleAnimation = new DoubleAnimation(100, duration);
                BarraEstatus.BeginAnimation(ProgressBar.ValueProperty, doubleAnimation); 
                BarraEstatus.Foreground = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF008000");

            }
        }
    }
}

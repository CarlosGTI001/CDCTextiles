using System;
using System.Collections;
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
using System.Windows.Shapes;
using CDCT.Models;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using LiveCharts.Wpf.Charts.Base;

namespace CDCT.Views
{
    /// <summary>
    /// Lógica de interacción para Dashboard.xaml
    /// </summary>
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            UltimasActualizaciones.ItemsSource = CargarPedidos24H();
            
        }

        private List<PedidosDetalle> CargarPedidos24H()
        {
            List<PedidosDetalle> pedidosDetalles = new List<PedidosDetalle>();
            pedidosDetalles.Add(new PedidosDetalle()
            {
                codigoRastreo = "CDC0001",
                estadoPedido = "Enviado",
                tipoPedido = "Tela #1",
                fechaActualizado = DateTime.Now
            });
            pedidosDetalles.Add(new PedidosDetalle()
            {
                codigoRastreo = "CDC0002",
                estadoPedido = "Entregado",
                tipoPedido = "Tela #1",
                fechaActualizado = DateTime.Now
            });
            pedidosDetalles.Add(new PedidosDetalle()
            {
                codigoRastreo = "CDC0003",
                estadoPedido = "Procesando",
                tipoPedido = "Tela #1",
                fechaActualizado = DateTime.Now
            });
            pedidosDetalles.Add(new PedidosDetalle()
            {
                codigoRastreo = "CDC0004",
                estadoPedido = "Facturados",
                tipoPedido = "Tela #1",
                fechaActualizado = DateTime.Now
            });
            pedidosDetalles.Add(new PedidosDetalle()
            {
                codigoRastreo = "CDC0005",
                estadoPedido = "Facturados",
                tipoPedido = "Tela #1",
                fechaActualizado = DateTime.Now
            });
            pedidosDetalles.Add(new PedidosDetalle()
            {
                codigoRastreo = "CDC0006",
                estadoPedido = "Entregados",
                tipoPedido = "Tela #1",
                fechaActualizado = DateTime.Now
            });
            pedidosDetalles.Add(new PedidosDetalle()
            {
                codigoRastreo = "CDC0007",
                estadoPedido = "Enviado",
                tipoPedido = "Tela #1",
                fechaActualizado = DateTime.Now
            });
            pedidosDetalles.Add(new PedidosDetalle()
            {
                codigoRastreo = "CDC0008",
                estadoPedido = "Entregado",
                tipoPedido = "Tela #1",
                fechaActualizado = DateTime.Now
            });
            pedidosDetalles.Add(new PedidosDetalle()
            {
                codigoRastreo = "CDC0009",
                estadoPedido = "Procesando",
                tipoPedido = "Tela #1",
                fechaActualizado = DateTime.Now
            });
            pedidosDetalles.Add(new PedidosDetalle()
            {
                codigoRastreo = "CDC0010",
                estadoPedido = "Facturados",
                tipoPedido = "Tela #1",
                fechaActualizado = DateTime.Now
            });
            pedidosDetalles.Add(new PedidosDetalle()
            {
                codigoRastreo = "CDC0011",
                estadoPedido = "Facturados",
                tipoPedido = "Tela #1",
                fechaActualizado = DateTime.Now
            });
            pedidosDetalles.Add(new PedidosDetalle()
            {
                codigoRastreo = "CDC0012",
                estadoPedido = "Entregados",
                tipoPedido = "Tela #1",
                fechaActualizado = DateTime.Now
            });
            pedidosDetalles.Add(new PedidosDetalle()
            {
                codigoRastreo = "CDC0013",
                estadoPedido = "Enviado",
                tipoPedido = "Tela #1",
                fechaActualizado = DateTime.Now
            });
            pedidosDetalles.Add(new PedidosDetalle()
            {
                codigoRastreo = "CDC0014",
                estadoPedido = "Entregado",
                tipoPedido = "Tela #1",
                fechaActualizado = DateTime.Now
            });
            pedidosDetalles.Add(new PedidosDetalle()
            {
                codigoRastreo = "CDC0015",
                estadoPedido = "Procesando",
                tipoPedido = "Tela #1",
                fechaActualizado = DateTime.Now
            });
            pedidosDetalles.Add(new PedidosDetalle()
            {
                codigoRastreo = "CDC0016",
                estadoPedido = "Facturados",
                tipoPedido = "Tela #1",
                fechaActualizado = DateTime.Now
            });
            pedidosDetalles.Add(new PedidosDetalle()
            {
                codigoRastreo = "CDC0017",
                estadoPedido = "Facturados",
                tipoPedido = "Tela #1",
                fechaActualizado = DateTime.Now
            });
            pedidosDetalles.Add(new PedidosDetalle()
            {
                codigoRastreo = "CDC0018",
                estadoPedido = "Entregados",
                tipoPedido = "Tela #1",
                fechaActualizado = DateTime.Now
            });
            return pedidosDetalles;
        }

        private void UltimasActualizaciones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

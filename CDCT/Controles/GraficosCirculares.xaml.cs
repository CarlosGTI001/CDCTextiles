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
using System.Windows.Shapes;
using CDCT.Models;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using LiveCharts.Wpf.Charts.Base;

namespace CDCT.Controles
{
    /// <summary>
    /// Lógica de interacción para GraficosCirculares.xaml
    /// </summary>
    public partial class GraficosCirculares : UserControl
    {
        public GraficosCirculares()
        {
            InitializeComponent();

            PointLabel = chartPoint =>
                  string.Format("({0}-{1:P})", chartPoint.Y, chartPoint.Participation);
            _Facturados = facturados => 1;
            _Procesando = facturados => 1;
            _Entregados = facturados => 1;
            _Enviado = facturados => 1;
            //ChartValues<int> entregados = new LiveCharts.ChartValues<int>();
            //entregados.Add(_Entregados());
            //Entregados.Values = entregados;
            //ChartValues<int> facturados = new LiveCharts.ChartValues<int>();
            //facturados.Add(_Facturados());
            //Facturados.Values = facturados;
            //ChartValues<int> enviados = new LiveCharts.ChartValues<int>();
            //enviados.Add(_Enviado());
            //Enviados.Values = enviados;
            //ChartValues<int> procesando = new LiveCharts.ChartValues<int>();
            //procesando.Add(_Procesando());
            //Procesando.Values = procesando;

            DataContext = this;
        }

        public Func<ChartPoint, string> PointLabel { get; set; }

        public Func<int, int> _Facturados { get; set; }
        public Func<int, int> _Procesando { get; set; }
        public Func<int, int> _Entregados { get; set; }
        public Func<int, int> _Enviado { get; set; }

        private void Chart_OnDataClick(object sender, ChartPoint chartpoint)
        {
            var chart = (LiveCharts.Wpf.PieChart)chartpoint.ChartView;

            foreach (PieSeries series in chart.Series)
                series.PushOut = 0;

            var selectedSeries = (PieSeries)chartpoint.SeriesView;
            selectedSeries.PushOut = 8;
        }

        

    }
}

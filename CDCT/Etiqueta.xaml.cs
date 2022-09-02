using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CDCT
{
    /// <summary>
    /// Lógica de interacción para Etiqueta.xaml
    /// </summary>
    public partial class Etiqueta : Window
    {
        string Filename;
        public Etiqueta()
        {
            InitializeComponent();
            
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Filename = picture3.Source.ToString().Replace("file:///", string.Empty);
            PrintDocument cred = new PrintDocument();
            
            System.Drawing.Image img = System.Drawing.Image.FromFile(Filename);
            cred.PrintPage += (s, a) =>
            {
                System.Drawing.Point point = new System.Drawing.Point(-5, -10);
                a.Graphics.DrawImage(img, point);
                
            };

            cred.PrinterSettings.PrintToFile = true;
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.ShowDialog().ToString();
            string file = fileDialog.FileName;
            cred.PrinterSettings.PrintFileName = file;
            cred.PrinterSettings.PrinterName = "Microsoft Print To Pdf";
            cred.Print();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

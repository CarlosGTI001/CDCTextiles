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

namespace CDCT
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        string usuario;
        string contrasena;
        bool mouseDownPass = false, mouseDownUser = false;
        public Login()
        {
            InitializeComponent();
            Cancelar.Click += (s, e) => winmgr.cerrar(Application.Current);
            iniciar.MouseEnter += (s, e) => iniciar.Foreground = Brushes.Black;
            iniciar.MouseLeave += (s, e) => iniciar.Foreground = Brushes.White;
            Cancelar.MouseEnter += (s, e) => Cancelar.Foreground = Brushes.Black;
            Cancelar.MouseLeave += (s, e) => Cancelar.Foreground = Brushes.White;
            
            User.PreviewMouseDown += (s, e) =>
            {
                if (mouseDownUser == false)
                {
                    User.Clear();
                    mouseDownUser = true;
                }
            };
            Pass.PreviewMouseDown += (s, e) =>
            {
                if (mouseDownPass == false)
                {
                    Pass.Clear();
                    mouseDownPass = true;
                }
            };

            iniciar.Click += login;
        }
        winmgr winmgr = new winmgr();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Precionaste un boton");
        }

        private void login(object sender, EventArgs e)
        {
            if(usuario == "Carlos" && contrasena == "Carlos")
            {
                MessageBox.Show("Ingresaste correctamente");
            }
            else
            {
                Inicio inicio = new Inicio();
                inicio.Show();
                this.Close();
            }
        }
    }
}

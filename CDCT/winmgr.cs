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
    internal class winmgr
    {
        public void cerrar(Application application)
        {
            application.Shutdown();
        }

        public void Minimizar(WindowState windowState)
        {
            windowState = WindowState.Minimized;
        }

        public void Maximizar(WindowState windowState)
        {
            windowState = WindowState.Maximized;
        }
    }
}

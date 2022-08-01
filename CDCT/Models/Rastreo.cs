using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDCT.Models
{
    public class RastreoPedido : INotifyPropertyChanged
    {
        private string nombre, apellido, rastreoid, clienteid, telefono;
        private List<DetalleRastreo> detalleRastreos;

        public string RastreoID { get { return rastreoid; } set { rastreoid = value; } }
        public string ClienteID { get { return clienteid; } set { clienteid = value; } }
        public string ClienteNombre { get { return nombre; } set { nombre = value; } }
        public string ClienteApellido { get { return apellido; } set { apellido = value; } }
        public string ClienteTelefono { get { return telefono; } set { telefono = value; } }
        public List <DetalleRastreo> DetalleRastreos { get { return detalleRastreos; } set { detalleRastreos = value; } }

        public RastreoPedido()
        {
            detalleRastreos = new List<DetalleRastreo>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }

    public class DetalleRastreo 
    { 
        public string RastreoID { get; set; }
        public string RastreoEstatus { get; set; }
        public DateTime RastreoFecha { get; set; }
        public string Firma { get; set; }
        public override string ToString()
        {
            return this.RastreoEstatus.ToString() + " " + this.RastreoFecha.ToString("dd/MM/yyyy hh:mm");
        }
    }
}

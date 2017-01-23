using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class clsN_Factura
    {
        clsD_Factura objD_Factura = new clsD_Factura();
        public DateTime fechaFactura { get; set; }
        public decimal valorCita { get; set; }
        public decimal totalProm { get; set; }
        public decimal subTotal { get; set; }
        public decimal total { get; set; }
        public string idUsuario { get; set; }
        public int idCita { get; set; }

        public DataSet obtenerId()
        {
            return (objD_Factura.consultarid());
        }

        public bool agregarFactura(DateTime fechaFactura, decimal valorCita, decimal totalProm, decimal subTotal, decimal total, string idUsuario, int idCita)
        {
            this.fechaFactura = fechaFactura;
            this.valorCita = valorCita;
            this.totalProm = totalProm;
            this.total = total;
            this.idUsuario = idUsuario;
            this.idCita = idCita;
            return (objD_Factura.agregarFactura(this.fechaFactura, this.valorCita, this.totalProm, this.subTotal, this.total, "AC", this.idUsuario, this.idCita));
        }
    }
}

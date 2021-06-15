using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Seguros_Maria_Rengel_Casimiro
{
    class Poliza
    {
        /*ATRIBUTOS DE LA CLASE*/
        private int num_poliza;
        private double importe;
        private String fecha_poliza;
        private String estado;
        private String observaciones;
        private String DNI_cliente;

        private String tablaPolizas;

        /*CONSTRUCTORES DE LA CLASE*/

        public Poliza()
        {
            this.TablaPolizas = $"SELECT Num_poliza AS 'Nº Poliza', Importe, Fecha_poliza AS Fecha, Estado, " +
                $"Observaciones, DNI_cliente AS DNI FROM poliza";
        }

        public Poliza(int nPoli, int imp, String fPoli, String est, String obs, String dni)
        {
            this.num_poliza = nPoli;
            this.importe = imp;
            this.fecha_poliza = fPoli;
            this.estado = est;
            this.observaciones = obs;
            this.DNI_cliente = dni;

            this.TablaPolizas = $"SELECT Num_poliza AS 'Nº Poliza', Importe, Fecha_poliza AS Fecha, Estado, " +
                $"Observaciones, DNI_cliente AS DNI FROM poliza";
        }

        /*MÉTODOS DE LA CLASE*/
        public void insertarPoliza(MySqlConnection con)
        {

        }

        public String obtenerPolizasCliente(String dni)
        {
            String consulta = this.TablaPolizas + " WHERE DNI_cliente = '" + dni + "';";

            return consulta;
        }

        public String orderByFechaDesc()
        {
            String consulta = this.TablaPolizas +  " ORDER BY Fecha_poliza DESC";

            return consulta;
        }


        /*GETTERS Y SETTERS*/
        public int Num_poliza { get => num_poliza; set => num_poliza = value; }
        public double Importe { get => importe; set => importe = value; }
        public string Fecha_poliza { get => fecha_poliza; set => fecha_poliza = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public string DNI_cliente1 { get => DNI_cliente; set => DNI_cliente = value; }
        public string TablaPolizas { get => tablaPolizas; set => tablaPolizas = value; }
    }
}

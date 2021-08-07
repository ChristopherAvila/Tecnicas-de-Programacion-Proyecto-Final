using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_Tecnicas_de_Programacion_Christopher_Ávila_Castillo_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[,] ListaVentas = new string[8, 200];
        int fila = 0;
        int palco ;
        int  sombra;
        int suma;
        private void btn_cargarlista_Click(object sender, EventArgs e)
        {
            try {


                if (txt_nombre.Text != "" && txt_cedula.Text != ""&& txt_palco.Text != "" && txt_sombra.Text != "" )
                {
                    ListaVentas[fila, 0] = txt_nombre.Text;
                    ListaVentas[fila, 1] = txt_cedula.Text;
                    ListaVentas[fila, 2] = txt_palco.Text;
                    ListaVentas[fila, 3] = txt_sombra.Text;
                    ListaVentas[fila, 4] = (int.Parse(txt_palco.Text) * 5000).ToString(); ;
                    ListaVentas[fila, 5] = (int.Parse(txt_sombra.Text)* 12000).ToString();
                    palco = int.Parse(ListaVentas[fila, 4]);
                    sombra = int.Parse(ListaVentas[fila, 5]);
                    suma = (palco + sombra);
                    lbl_monto.Text = (suma).ToString();
                    lbl_montomasiva.Text = (suma*0.13).ToString();
                    ListaVentas[fila, 6] = (int.Parse(lbl_monto.Text) ).ToString(); ;
                    ListaVentas[fila, 7] = (int.Parse(lbl_montomasiva.Text)).ToString();
                    dg_lista.Rows.Add(ListaVentas[fila, 0], ListaVentas[fila, 1], ListaVentas[fila, 2], ListaVentas[fila, 3] ,ListaVentas[fila, 4], ListaVentas[fila, 5], ListaVentas[fila, 6], ListaVentas[fila, 7]);

                    fila++;
                    txt_nombre.Text = txt_cedula.Text = txt_palco.Text = txt_sombra.Text = "";






                }


            } catch{ 
                
                
                
                
                
                
                
                throw; }
        }

        private void btn_factura_Click(object sender, EventArgs e)
        {
            clsFuncion.CreaTicket Ticket1 = new clsFuncion.CreaTicket();

            Ticket1.TextoCentro("Estadio Nacional"); //imprime una linea de descripcion
            Ticket1.TextoCentro("**********************************");

            Ticket1.TextoIzquierda("Dirc: Parque Metropolitano La Sabana");
            Ticket1.TextoIzquierda("Tel: +506 2549 0700 ");
            Ticket1.TextoIzquierda("");
            Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
            Ticket1.TextoIzquierda("Nombre Cliente:" + txt_nombre.Text);
            Ticket1.TextoIzquierda("Cedula Cliente:" + txt_cedula.Text);
            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("Le Atendio: xxxx");
            Ticket1.TextoIzquierda("");
            Ticket1.TextoIzquierda("Precio Palco: ₡5000");
            Ticket1.TextoIzquierda("Precio Graderia(Sombra): ₡12000");
            clsFuncion.CreaTicket.LineasGuion();

            clsFuncion.CreaTicket.EncabezadoVenta();
            clsFuncion.CreaTicket.LineasGuion();
            
                // Articulo                     //Nombre                                   Palco                          Sombra                                         Monto
                Ticket1.AgregaArticulo(txt_nombre.Text, int.Parse(txt_palco.Text), int.Parse(txt_sombra.Text), int.Parse(lbl_monto.Text)); //imprime una linea de descripcion
            


            clsFuncion.CreaTicket.LineasGuion();
            Ticket1.TextoIzquierda(" ");
            Ticket1.TextoIzquierda("Total : " + lbl_monto.Text); // imprime linea con total
            Ticket1.TextoIzquierda("iva:" + lbl_montomasiva.Text);
            Ticket1.TextoIzquierda(" ");


            // Ticket1.LineasTotales(); // imprime linea 

            Ticket1.TextoIzquierda(" ");
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoCentro("*     Gracias por preferirnos    *");

            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoIzquierda(" ");
            string impresora = "Microsoft XPS Document Writer";
            Ticket1.ImprimirTiket(impresora);

        }

        private void dg_lista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_seleccionarclientes_Click(object sender, EventArgs e)
        {
            txt_nombre.Text =  this.dg_lista.CurrentRow.Cells[0].Value.ToString();
            txt_cedula.Text =  this.dg_lista.CurrentRow.Cells[1].Value.ToString();
            txt_palco.Text  =  this.dg_lista.CurrentRow.Cells[2].Value.ToString();
            txt_sombra.Text =  this.dg_lista.CurrentRow.Cells[3].Value.ToString();
            lbl_monto.Text  =  this.dg_lista.CurrentRow.Cells[6].Value.ToString();
            lbl_montomasiva.Text= this.dg_lista.CurrentRow.Cells[7].Value.ToString();





        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = txt_cedula.Text = txt_palco.Text = txt_sombra.Text =  "";
            lbl_montomasiva.Text = lbl_monto.Text = "00.00";
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pasos para utilizar el programa" +"                                                            "+
                "1-Ingrese los datos que se piden Nombre,cedula......."+"                                 " +
                "2-Una vez rellenados todos los campos presione el botón de Cargar Lista" + "                                                                                                                  " +
                "3-Una vez realizado el paso anterior puede ingresar más clientes de la misma manera" + "                                                                                         " +
                "4-Cree una factura seleccionando con el cursor el nombre del cliente en la lista y presione seleccionar cliente" + "                                                              " +
                "5-Realizado el paso anterior presione el botón -Crear Factura-" + "                                                                        " +
                "","Información");
        }
    }

    

          
    }
    

    

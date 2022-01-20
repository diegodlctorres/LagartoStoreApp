using BusinessLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Utilitario
{
    public class Util
    {
        public static void Centrar(Control contenedor, Control control)
        {
            control.Location = new Point((contenedor.Width / 2) - (control.Width / 2), control.Location.Y);
        }

        public static void AjustarDataGridView(Control contenedor, DataGridView dataGridView)
        {
            //var b = dataGridView.VerticalScrollBar;

            //foreach(var a  in dataGridView.Controls.OfType<ScrollBar>())
            //{
            //    var b = a.Width;
            //}

            //var c = dataGridView.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width);           

            var a = dataGridView.Rows.Count > 19 ? 17 : 0;

            contenedor.Width = dataGridView.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width) + 23 + a;
            // 1 a cada lado y ¿21?
        }

        public static void CrearDatosAleatorios()
        {
            Random random = new Random();

            List<Colaborador> colaboradores = AppEngine.colaboradorDAL.GetAll();
            var totalColaboradores = colaboradores.Count;

            List<Cliente> clientes = AppEngine.clienteDAL.GetAll();
            var totalClientes = clientes.Count;

            List<Producto> productos = AppEngine.productoDAL.GetAll();
            var totalProductos = productos.Count;

            var fechaBase = new DateTime(2021, 1, 1);

            for (int i = 1; i <= 50; i++)
            {
                int aux = random.Next(1, totalClientes - 1);
                Cliente cliente = clientes.Where(x => x.Id == aux).First();

                aux = random.Next(0, 365);
                DateTime fechaAux = fechaBase.AddDays(aux);

                aux = random.Next(1, totalColaboradores);
                Colaborador colaborador = colaboradores.Where(x => x.Id == aux).First();
                AppEngine.compraDAL.Create(
                    new Compra(
                        i,
                        fechaAux,
                        colaborador,
                        cliente));

                Compra compra = AppEngine.compraDAL.GetByID(0, cliente.Id);

                int[] matrizDeProductos = new int[random.Next(1, 4)];
                for (int j = 0; j < matrizDeProductos.Length; j++)
                {
                    AppEngine.compraDAL.GenerateCompra(compra.Id, random.Next(1, totalProductos), random.Next(1, 3));
                }
            }
        }
    }
}

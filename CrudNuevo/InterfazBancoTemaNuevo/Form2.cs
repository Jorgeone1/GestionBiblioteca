using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using Mysqlx.Session;
using static System.Net.Mime.MediaTypeNames;

namespace Interfaz2
{

    public partial class Form2 : Form
    {


        Conectar connect = new Conectar();
        /// <summary>
        /// crea el constructor conecta con la base de datos y pone el ultimo id
        /// </summary>
        public Form2()
        {
            InitializeComponent();
            rellenarDatos();
            MySqlConnection conexion = connect.GetConnection();

            textID.Text = ponerID() + "";
            //pone los botones activos
            textID.Enabled = false;
            buttonCancelar.Enabled = false;
            buttonActualizar.Enabled = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Rellena el DataGridView con los datos del select
        /// </summary>
        public void rellenarDatos()
        {

            try
            {
                MySqlConnection conexion = connect.GetConnection();
                conexion.Open();
                String sqlQuery = "Select * from producto";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlQuery, conexion);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
                //crea botones de borrar y editar a cada dato.
                if (dataGridView1.Columns["Borrar"] == null)
                {

                    DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                    buttonColumn.Name = "Borrar";
                    buttonColumn.HeaderText = "Borrar";
                    buttonColumn.Text = "Borrar";
                    buttonColumn.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(buttonColumn);
                }

                if (dataGridView1.Columns["Editar"] == null)
                {
                    DataGridViewButtonColumn buttonEditar = new DataGridViewButtonColumn();
                    buttonEditar.Name = "Editar";
                    buttonEditar.HeaderText = "Editar";
                    buttonEditar.Text = "Editar";
                    buttonEditar.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(buttonEditar);
                }
            }
            catch (MySqlException ex) { }
        }
        /// <summary>
        /// coge el siguiente id
        /// </summary>
        /// <returns>devuelve el id</returns>
        private long ponerID()
        {
            try
            {
                long id = 0;
                MySqlConnection conexion = connect.GetConnection();
                conexion.Open();

                // Obtener el máximo valor actual de id_producto
                String sql = $"SHOW TABLE STATUS LIKE 'Producto';";
                MySqlCommand command = new MySqlCommand(sql, conexion);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = Convert.ToInt64(reader["Auto_increment"]);
                    }
                }
                conexion.Close();
                return id;
            }
            catch (MySqlException ex)
            {
                // Manejo de excepciones
                MessageBox.Show("Error de MySQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejo de otras excepciones
                MessageBox.Show("Error: " + ex.Message);
            }

            return 0;
        }
        private void buttonCrear_Click(object sender, EventArgs e)
        {
            añadir();
        }
        /// <summary>
        /// añade a la base de datos y comprueba que todos esten bien
        /// </summary>
        private void añadir()
        {
            try
            {
                int iva;

                if (int.TryParse(textIVA.Text, out iva))
                {
                    double precio;
                    if (double.TryParse(textPrecio.Text, out precio))
                    {
                        if (textNombre.Text.Trim().Length != 0)
                        {
                            if (textDescripcion.Text.Trim().Length != 0)
                            {
                                MySqlConnection conexion = connect.GetConnection();
                                conexion.Open();
                                String sql = "insert into producto(nombre,descripcion,precio,iva) values('" + textNombre.Text + "','" + textDescripcion.Text + "'," + textPrecio.Text + "," + textIVA.Text + ");";
                                using (MySqlCommand command = new MySqlCommand(sql, conexion))
                                {

                                    // Ejecuta la consulta de inserción
                                    int rowsAffected = command.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Se inserto correctamente");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error se inserto mal");
                                    }
                                }
                                conexion.Close();
                                rellenarDatos();
                                textID.Text = ponerID() + "";
                                borrarText();
                            }
                            else
                            {
                                MessageBox.Show("No puede estar vacio Descripcion");
                                textDescripcion.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No puede estar vacio el Nombre");
                            textNombre.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tiene que ser un numero el precio.");
                        textPrecio.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Tiene que ser un numero entero el IVA.");
                    textIVA.Focus();
                }
            }
            catch (MySqlException es)
            {
                MessageBox.Show("Error de MySQL: " + es.Message);
            }

        }
        /// <summary>
        /// Cada vez que le de al click de borrar o editar haran sus funciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Borrar"].Index && e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int idToDelete = Convert.ToInt32(selectedRow.Cells["id_producto"].Value); // Ajusta "ID" al nombre de tu columna
                try
                {
                    MySqlConnection conexion = connect.GetConnection();
                    conexion.Open();
                    String sql = "Delete from producto where id_producto = " + idToDelete;
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas Borrarlo?", "Confirmación", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        using (MySqlCommand command = new MySqlCommand(sql, conexion))
                        {

                            int rowAffected = command.ExecuteNonQuery();
                            if (rowAffected < 0)
                            {
                                MessageBox.Show("Error al borrar");
                            }
                        }
                        dataGridView1.Rows.Remove(selectedRow);
                    }
                }
                catch (MySqlException es)
                {

                }
                // Aquí puedes realizar la lógica para eliminar la fila, por ejemplo:

            }
            if (e.ColumnIndex == dataGridView1.Columns["Editar"].Index && e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int idToEdit = Convert.ToInt32(selectedRow.Cells["id_producto"].Value);
                //imprime los datos a los textbox
                textNombre.Text = Convert.ToString(selectedRow.Cells["nombre"].Value);
                textDescripcion.Text = Convert.ToString(selectedRow.Cells["descripcion"].Value);
                textPrecio.Text = Convert.ToDecimal(selectedRow.Cells["precio"].Value) + "";
                textIVA.Text = Convert.ToInt32(selectedRow.Cells["IVA"].Value) + "";
                textID.Text = idToEdit + "";
                buttonCancelar.Enabled = true;
                buttonActualizar.Enabled = true;
                buttonCrear.Enabled = false;
            }
        }
        /// <summary>
        /// limpia los textField
        /// </summary>
        private void borrarText()
        {
            textNombre.Text = "";
            textDescripcion.Text = "";
            textPrecio.Text = "";
            textIVA.Text = "";
        }
        /// <summary>
        /// actualiza los datos y activa confirmar otra vez
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonActualizar_Click(object sender, EventArgs e)
        {

            try
            {
                int iva;

                if (int.TryParse(textIVA.Text, out iva))
                {
                    double precio;
                    if (double.TryParse(textPrecio.Text, out precio))
                    {
                        if (textNombre.Text.Trim().Length != 0)
                        {
                            if (textDescripcion.Text.Trim().Length != 0)
                            {
                                try
                                {
                                    MySqlConnection conexion = connect.GetConnection();
                                    conexion.Open();
                                    String sql = $"Update Producto set nombre = '{textNombre.Text}',descripcion ='{textDescripcion.Text}',precio = {textPrecio.Text}, iva = {textIVA.Text} where id_producto={textID.Text}";
                                    using (MySqlCommand command = new MySqlCommand(sql, conexion))
                                    {

                                        int rowAffected = command.ExecuteNonQuery();
                                        if (rowAffected < 0)
                                        {
                                            MessageBox.Show("Error al borrar");
                                        }

                                    }
                                    buttonCancelar.Enabled = false;
                                    buttonActualizar.Enabled = false;
                                    buttonCrear.Enabled = true;
                                    rellenarDatos();
                                    borrarText();
                                    textID.Text = ponerID() + "";
                                }
                                catch (MySqlException es)
                                {

                                }
                            }
                            else
                            {
                                MessageBox.Show("No puede estar vacio Descripcion");
                                textDescripcion.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No puede estar vacio el Nombre");
                            textNombre.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tiene que ser un numero el precio.");
                        textPrecio.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Tiene que ser un numero entero el IVA.");
                    textIVA.Focus();
                }
            }
            catch (MySqlException es)
            {

            }
        }
        /// <summary>
        /// cancela la actualizacion-
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            buttonCancelar.Enabled = false;
            buttonActualizar.Enabled = false;
            buttonCrear.Enabled = true;
            rellenarDatos();
            borrarText();
            textID.Text = ponerID() + "";
        }
    }
}

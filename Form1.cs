using System.Data.SqlClient;

namespace Rubrica
{
    public partial class Form1 : Form
    {

        string connString = @"Server=DESKTOP-R7JUVDU\SQLEXPRESS03;Database=RubricaDb;Trusted_Connection=True;";


        List<String> items = new List<String>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Nuovo_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                String nominativo = form2.GetNominativo();
                String telefono = form2.GetTelefono();
                listBox1.Items.Add(nominativo + "," + telefono);
                NuovoRecord(nominativo, telefono);
            }
        }


        private void NuovoRecord(String nominativo, String numeroTelefonico)
        {
            //salva in db
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "INSERT INTO Contatti (Nominativo, NumeroTelefonico) VALUES (@nominativo, @numerotelefonico)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nominativo", nominativo);
                    cmd.Parameters.AddWithValue("@numerotelefonico", numeroTelefonico);
                    cmd.ExecuteNonQuery();
                }
            }
            CaricaDati(); // Aggiorna la listBox
        }




        private void CaricaDati()
        {
            listBox1.Items.Clear();

            try
            {

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT Id, Nominativo, NumeroTelefonico FROM Contatti";
                    using (SqlCommand cmd = new SqlCommand(query, conn))

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        listBox1.Items.Clear();
                        while (reader.Read())
                        {
                            string id = reader.GetInt32(0).ToString();
                            string nominativo = reader.GetString(1).Trim();
                            string telefono = reader.GetString(2).Trim();
                            listBox1.Items.Add(id + "," + nominativo + "," + telefono);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            CaricaDati();
        }





        private void Modifica_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (listBox1.SelectedIndex > -1)
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                string[] parts = selectedItem.Split(',');


                form2.SetNominativo(parts[1]);
                form2.SetTelefono(parts[2]);


                if (form2.ShowDialog() == DialogResult.OK)
                {
                    String nominativo = form2.GetNominativo();
                    String telefono = form2.GetTelefono();

                    //listBox1.Items[listBox1.SelectedIndex] = nominativo + "," + telefono;
                    ModificaRecord(int.Parse(parts[0]), nominativo, telefono);
                }
            }
            else
            {
                MessageBox.Show("Seleziona un contatto da modificare.");
                return;
            }
        }

        private void ModificaRecord(int id, string nuovoNominativo, string nuovoNumero)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "UPDATE Contatti SET Nominativo = @nominativo, NumeroTelefonico = @numerotelefonico WHERE Id = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nominativo", nuovoNominativo.Trim());
                    cmd.Parameters.AddWithValue("@numerotelefonico", nuovoNumero.Trim());
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            CaricaDati();
        }

        private void Elimina_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleziona un contatto da eliminare.");
            }
            else
            {
                int id = int.Parse(listBox1.SelectedItem.ToString().Split(",")[0]);
                EliminaRecord(id);
                CaricaDati();
            }
        }

        private void EliminaRecord(int Id)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "DELETE FROM Contatti WHERE Id=@Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                }
            }
            CaricaDati();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                string[] parts = selectedItem.Split(',');
                label1.Text = "Nominativo: " + parts[0];
                label2.Text = "Telefono: " + parts[1];
            }
            else
            {
                label1.Text = "Nominativo";
                label2.Text = "Telefono";
            }
        }

        private void Ricerca_TextChanged(object sender, EventArgs e)
        {
            String filtro = textBox1.Text.ToLower();

            for (int k = 0; k < listBox1.Items.Count; k++)
            {
                if (listBox1.Items[k].ToString().ToLower().Contains(filtro))
                {
                    listBox1.SelectedIndex = k;
                    break;
                }
            }
        }
    }
}


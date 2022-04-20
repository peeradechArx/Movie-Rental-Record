using System.Text;

namespace movie_rental_record
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);
                string readAllText = File.ReadAllText(openFileDialog.FileName);

                for (int i = 0; i < readAllLine.Length; i++)
                {
                    string ClassCDRAW = readAllLine[i];
                    string[] ClassCDSplited = ClassCDRAW.Split(',');
                    ClassCD classCD = new ClassCD(ClassCDSplited[0], ClassCDSplited[1], ClassCDSplited[2], ClassCDSplited[3]);
                    addDataToGridView(ClassCDSplited[0], ClassCDSplited[1], ClassCDSplited[2], ClassCDSplited[3]);
                }
            }
            void addDataToGridView(string num, string name, string Day, string Month)
            {
                this.dataGridView1.Rows.Add(new string[] { num, name, Day, Month});
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filepath = string.Empty;
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV(*.csv)|*.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string columnNames = "";
                            string[] outputCSV = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCSV[0] += columnNames;
                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCSV[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            File.WriteAllLines(sfd.FileName, outputCSV, Encoding.UTF8);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            }

        private void buttonADDMovie_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = textBoxNum.Text;
            dataGridView1.Rows[n].Cells[1].Value = textBoxNamemoive.Text;
            dataGridView1.Rows[n].Cells[2].Value = comboBoxDay.Text;
            dataGridView1.Rows[n].Cells[3].Value = comboBoxMonth.Text ;
            textBoxNum.Text = "";
            textBoxNamemoive.Text = "";
            comboBoxDay.Text = "";
            comboBoxMonth.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Visible = false;
            Form1 form1 = new Form1();
            form1.Visible = true;
        }
    }
}
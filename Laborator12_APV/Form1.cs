using Laborator12_APV.Entities;

namespace Laborator12_APV
{
    public partial class Form1 : Form
    {
        private readonly DataBaseContext _db;
        public Form1()
        {
            _db = new DataBaseContext();
            InitializeComponent();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee()
            {
                first_name = textBoxName.Text,
                last_name = textBoxPrenume.Text,
                email = textBoxEmail.Text,
                salary = int.Parse(textBoxSalariu.Text),
            };
            _db.Employees.Add(emp);
            ApplyChanges();
            ClearFields();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployeeList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewEmployeeList.SelectedRows[0];
                int employeeId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                Employee empToUpdate = _db.Employees.Find(employeeId);

                empToUpdate.first_name = textBoxName.Text;
                empToUpdate.last_name = textBoxPrenume.Text;
                empToUpdate.email = textBoxEmail.Text;
                empToUpdate.salary = int.Parse(textBoxSalariu.Text);

                ApplyChanges();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Selectati un angajat pentru editare !");
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {

        }
        private void dataGridViewEmployeeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewEmployeeList.Rows[e.RowIndex];

                textBoxName.Text = selectedRow.Cells["first_name"].Value.ToString();
                textBoxPrenume.Text = selectedRow.Cells["last_name"].Value.ToString();
                textBoxEmail.Text = selectedRow.Cells["email"].Value.ToString();
                textBoxSalariu.Text = selectedRow.Cells["salary"].Value.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewEmployeeList.DataSource = _db.Employees.ToList();
        }
        private void ApplyChanges()
        {
            _db.SaveChanges();
            dataGridViewEmployeeList.DataSource = _db.Employees.ToList();
        }
        private void ClearFields()
        {
            textBoxName.Text = "";
            textBoxPrenume.Text = "";
            textBoxEmail.Text = "";
            textBoxSalariu.Text = "";
        }
    }
}
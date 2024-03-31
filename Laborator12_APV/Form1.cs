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

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {

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
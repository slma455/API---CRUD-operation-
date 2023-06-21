using APIDAY2.Models;

namespace APIDAY2
{

    public partial class Form1 : Form
    {
        HttpClient client;

        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5173/api/");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HttpResponseMessage resp = client.GetAsync("Student").Result;
            if (resp.IsSuccessStatusCode)
            {
                List<StudentGet> sts = resp.Content.ReadAsAsync<List<StudentGet>>().Result;
                dgv_student.DataSource = sts;
            }
            HttpResponseMessage mess = client.GetAsync("department").Result;
            if (mess.IsSuccessStatusCode)
            {
                List<deptData> dept = mess.Content.ReadAsAsync<List<deptData>>().Result;
                cb_dept.DisplayMember = "dept_name";
                cb_dept.ValueMember = "dept_id";
                cb_dept.DataSource = dept;

            }
            HttpResponseMessage sv = client.GetAsync("superVisor").Result;
            if (sv.IsSuccessStatusCode)
            {
                List<SuperVisorData> super = sv.Content.ReadAsAsync<List<SuperVisorData>>().Result;
                cb_super.DisplayMember = "firstName";
                cb_super.ValueMember = "super_id";
                cb_super.DataSource = super;


            }

        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            StudentAdd sadd = new StudentAdd()
            {
                firstName = txt_Fname.Text,
                lastName = txt_Lname.Text,
                address = txt_Address.Text,
                age = int.Parse(txt_age.Text),
                dept_id = (int)cb_dept.SelectedValue,
                super_id = (int)cb_super.SelectedValue
            };
            HttpResponseMessage result = client.PostAsJsonAsync("Student", sadd).Result;
            if (result.IsSuccessStatusCode)
            {
                Form1_Load(null, null);
            }

        }
        public int id;


        private void Delete_Click(object sender, EventArgs e)
        {
            id = (int)dgv_student.SelectedRows[0].Cells[0].Value;
            HttpResponseMessage res = client.DeleteAsync($"Student/{id}").Result;
            if (res.IsSuccessStatusCode)
            {
                Form1_Load(null, null);
                txt_Fname.Text = txt_Lname.Text = txt_age.Text = txt_Address.Text = "";
            }



        }
        private void dgv_student_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_student.SelectedRows[0].Cells[0].Value;
            HttpResponseMessage res = client.GetAsync($"Student/{id}").Result;
            if (res.IsSuccessStatusCode)
            {
                StudentAdd std = res.Content.ReadAsAsync<StudentAdd>().Result;
                txt_Fname.Text = std.firstName;
                txt_Lname.Text = std.lastName;
                txt_age.Text = std.age.ToString();
                cb_dept.SelectedValue = std.dept_id;
                cb_super.SelectedValue = std.super_id;
            }
            btn_add.Visible = false;
            btn_delete.Visible = true;
            btn_update.Visible = true;

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            id = (int)dgv_student.SelectedRows[0].Cells[0].Value;
            StudentAdd std = new StudentAdd
            {
                id = id,
                firstName = txt_Fname.Text,
                lastName = txt_Lname.Text,
                age = int.Parse(txt_age.Text),
                address = txt_Address.Text,
                dept_id = (int)cb_dept.SelectedValue,
                super_id = (int)cb_super.SelectedValue
            };
            HttpResponseMessage res = client.PutAsJsonAsync($"Student/{id}", std).Result;
            if (res.IsSuccessStatusCode)
            {
                Form1_Load(null, null);
                txt_Fname.Text = txt_Lname.Text = txt_age.Text = txt_Address.Text = "";


            }

        }
    }
}
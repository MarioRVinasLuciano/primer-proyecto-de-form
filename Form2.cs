using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_of_dentist_appointment
{
    public partial class Form2 : Form
    {
        List<Appointment> appointments = new List<Appointment>();
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Saveappointment();
        }

        private void Saveappointment()
        {
            
            var appointment = new Appointment
            {
                Name = Name01.Text,
                Lastname = Lastname.Text,
                Email = email.Text,
                Number = number.Text,
                Scheduledate = dateTimePicker1.Value

            };

            appointments.Add(appointment);

            GetAppoiments(); 
        }

        private void GetAppoiments()
        {
            dgvAppointments.DataSource  = null;
            dgvAppointments.DataSource = appointments;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Name01.Text = string.Empty;
            Lastname.Text = string.Empty;   
            email.Text = string.Empty;  
            number.Text = string.Empty; 
           

        }
    }
    public class Appointment
    {
        public string Name { get; set; }

        public string Lastname { get; set; }

        public string Email { get; set; }


        public DateTime Scheduledate { get; set; }

        public string Number { get; set; }


    }
}

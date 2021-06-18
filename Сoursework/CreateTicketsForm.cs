using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Сoursework
{
    public partial class CreateTicketsForm : Form
    {
        private Main_Form main;
        
        public CreateTicketsForm(Main_Form form)
        {
            InitializeComponent();
            main = form;
        }

        public CreateTicketsForm(Ticket ticket ,Main_Form mf)
        {
            Ticket tick = ticket;
            InitializeComponent();
            tbArrivalTime.Text = Convert.ToString(tick.ArrivalTime);
            tbDepartureTime.Text = Convert.ToString(tick.DepartureTime);
            tbDepartureSity.Text = tick.DepartureSity;
            tbDestinationSity.Text = tick.DestinationSity;
            tbFlightNumber.Text = Convert.ToString(tick.FlightNumber);
            tbFreeSeats.Text = Convert.ToString(tick.FreeSeats);
            tbTotalFlightTime.Text = Convert.ToString(tick.TotalFlightTime);
            tbCost.Text = Convert.ToString(tick.Cost);


        }
        private static void tbCleaner(Control parent)
        {
            foreach (Control item in parent.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                    item.Text = string.Empty;
            }

        }
        public Ticket AddNewTicket()
        {
            Ticket ticket = new Ticket(Convert.ToInt32(tbFlightNumber.Text), Convert.ToInt32(tbArrivalTime.Text), Convert.ToInt32(tbDepartureTime.Text), Convert.ToInt32(tbTotalFlightTime.Text), tbDestinationSity.Text, tbDepartureSity.Text, Convert.ToInt32(tbCost.Text), Convert.ToInt32(tbFreeSeats.Text));
            return ticket;
        }

        private void btCreateTicket_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket ticket = AddNewTicket();
                main.tkList.Add(ticket);
                MessageBox.Show("Квіток був успішно створенний");
                tbCleaner(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Усі поля мають бути заповнені", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}

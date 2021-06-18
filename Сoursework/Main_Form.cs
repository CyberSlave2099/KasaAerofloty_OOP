using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Сoursework.Classes;

namespace Сoursework
{
    public partial class Main_Form : Form
    {
        public TicketsList tkList = new TicketsList();
        public TicketsList tkList2 = new TicketsList();
        public Main_Form()
        {
            InitializeComponent();
            TicketListVie.FullRowSelect = true;
        }
        
        public void update(TicketsList t)
        {
            Cleare();
            String[] row;
            if (t.list != null)
            {
                foreach (Ticket tt in t.list)
                {
                    row = tt.GetRowString();
                    ListViewItem item = new ListViewItem(row);
                    TicketListVie.Items.Add(item);
                }
            }
            tkList2 = tkList;
        }

        public void update2(TicketsList t)
        {
            Cleare();
            String[] row;
            if (t.list != null)
            {
                foreach (Ticket tt in t.list)
                {
                    row = tt.GetRowString();
                    ListViewItem item = new ListViewItem(row);
                    TicketListVie.Items.Add(item);
                }
            }
        }

        private void Cleare()
        {
            TicketListVie.Items.Clear();
        }

        private void btCreateTicket_Click(object sender, EventArgs e)
        { 
            CreateTicketsForm form = new CreateTicketsForm(this);
            form.ShowDialog();
            update(tkList);
        }

        private void btDelateTicket_Click(object sender, EventArgs e)
        {
            tkList.Delete(TicketListVie);
        }

        private void btSaveList_Click(object sender, EventArgs e)
        {
            //tkList.Serialize();
        }

        private void btOpenList_Click(object sender, EventArgs e)
        {
            //tkList = tkList.Open();
            //update(tkList);
        }

        private void btSaveToTxt_Click(object sender, EventArgs e)
        {
            string text;
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = ".txt";
            saveFile.Filter = "Test filds|*.txt";
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFile.FileName.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(saveFile.FileName, false))
                {
                    foreach (Ticket t in tkList2.list)
                    {
                        text = tkList.SaveToTxt(t);
                        sw.WriteLine(text);
                    }
                    sw.Close();
                }
            }
        }

        private void btActivateFilter_Click(object sender, EventArgs e)
        {
            tkList2 = tkList.Find(tkList, tbNumberOfFlight.Text, tbDepartureTime.Text, tbDepartureSity.Text, tbMaxCost.Text);
            update2(tkList2);
        }
    }
}

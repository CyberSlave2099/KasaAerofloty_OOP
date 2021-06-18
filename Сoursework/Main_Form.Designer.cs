
namespace Сoursework
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCreateTicket = new System.Windows.Forms.Button();
            this.btBuySomeTickets = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btSaveToTxt = new System.Windows.Forms.Button();
            this.btOpenList = new System.Windows.Forms.Button();
            this.btSaveList = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TicketListVie = new System.Windows.Forms.ListView();
            this.FlightNumber = new System.Windows.Forms.ColumnHeader();
            this.DepartureTime = new System.Windows.Forms.ColumnHeader();
            this.ArrivalTime = new System.Windows.Forms.ColumnHeader();
            this.TotalFliightTime = new System.Windows.Forms.ColumnHeader();
            this.DepartureSity = new System.Windows.Forms.ColumnHeader();
            this.DestinationSity = new System.Windows.Forms.ColumnHeader();
            this.Cost = new System.Windows.Forms.ColumnHeader();
            this.FreeSeats = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNumberOfFlight = new System.Windows.Forms.TextBox();
            this.tbDepartureTime = new System.Windows.Forms.TextBox();
            this.tbDepartureSity = new System.Windows.Forms.TextBox();
            this.tbMaxCost = new System.Windows.Forms.TextBox();
            this.btDelateTicket = new System.Windows.Forms.Button();
            this.btActivateFilter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btCreateTicket);
            this.panel1.Controls.Add(this.btBuySomeTickets);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 653);
            this.panel1.TabIndex = 0;
            // 
            // btCreateTicket
            // 
            this.btCreateTicket.Location = new System.Drawing.Point(12, 118);
            this.btCreateTicket.Name = "btCreateTicket";
            this.btCreateTicket.Size = new System.Drawing.Size(170, 80);
            this.btCreateTicket.TabIndex = 2;
            this.btCreateTicket.Text = "Додати квиток";
            this.btCreateTicket.UseVisualStyleBackColor = true;
            this.btCreateTicket.Click += new System.EventHandler(this.btCreateTicket_Click);
            // 
            // btBuySomeTickets
            // 
            this.btBuySomeTickets.Location = new System.Drawing.Point(12, 242);
            this.btBuySomeTickets.Name = "btBuySomeTickets";
            this.btBuySomeTickets.Size = new System.Drawing.Size(170, 80);
            this.btBuySomeTickets.TabIndex = 1;
            this.btBuySomeTickets.Text = "Придбати квиток/квитки";
            this.btBuySomeTickets.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel2.Controls.Add(this.btSaveToTxt);
            this.panel2.Controls.Add(this.btOpenList);
            this.panel2.Controls.Add(this.btSaveList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(193, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1243, 83);
            this.panel2.TabIndex = 1;
            // 
            // btSaveToTxt
            // 
            this.btSaveToTxt.Location = new System.Drawing.Point(312, 12);
            this.btSaveToTxt.Name = "btSaveToTxt";
            this.btSaveToTxt.Size = new System.Drawing.Size(162, 29);
            this.btSaveToTxt.TabIndex = 2;
            this.btSaveToTxt.Text = "Зберегти в .txt файл";
            this.btSaveToTxt.UseVisualStyleBackColor = true;
            this.btSaveToTxt.Click += new System.EventHandler(this.btSaveToTxt_Click);
            // 
            // btOpenList
            // 
            this.btOpenList.Location = new System.Drawing.Point(142, 11);
            this.btOpenList.Name = "btOpenList";
            this.btOpenList.Size = new System.Drawing.Size(149, 29);
            this.btOpenList.TabIndex = 1;
            this.btOpenList.Text = "Завантажити файл";
            this.btOpenList.UseVisualStyleBackColor = true;
            this.btOpenList.Click += new System.EventHandler(this.btOpenList_Click);
            // 
            // btSaveList
            // 
            this.btSaveList.Location = new System.Drawing.Point(6, 12);
            this.btSaveList.Name = "btSaveList";
            this.btSaveList.Size = new System.Drawing.Size(120, 28);
            this.btSaveList.TabIndex = 0;
            this.btSaveList.Text = "Зберегти файл";
            this.btSaveList.UseVisualStyleBackColor = true;
            this.btSaveList.Click += new System.EventHandler(this.btSaveList_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(193, 83);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Касса аерофлоту";
            // 
            // TicketListVie
            // 
            this.TicketListVie.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FlightNumber,
            this.DepartureTime,
            this.ArrivalTime,
            this.TotalFliightTime,
            this.DepartureSity,
            this.DestinationSity,
            this.Cost,
            this.FreeSeats});
            this.TicketListVie.GridLines = true;
            this.TicketListVie.HideSelection = false;
            this.TicketListVie.Location = new System.Drawing.Point(199, 152);
            this.TicketListVie.Name = "TicketListVie";
            this.TicketListVie.Size = new System.Drawing.Size(1225, 350);
            this.TicketListVie.TabIndex = 3;
            this.TicketListVie.UseCompatibleStateImageBehavior = false;
            this.TicketListVie.View = System.Windows.Forms.View.Details;
            // 
            // FlightNumber
            // 
            this.FlightNumber.Text = "Номер рейсу";
            this.FlightNumber.Width = 110;
            // 
            // DepartureTime
            // 
            this.DepartureTime.Text = "Час відправлення";
            this.DepartureTime.Width = 140;
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.Text = "Час прибуття";
            this.ArrivalTime.Width = 140;
            // 
            // TotalFliightTime
            // 
            this.TotalFliightTime.Text = "Сумарний час перельоту";
            this.TotalFliightTime.Width = 220;
            // 
            // DepartureSity
            // 
            this.DepartureSity.Text = "Місто відправки";
            this.DepartureSity.Width = 130;
            // 
            // DestinationSity
            // 
            this.DestinationSity.Text = "Місто прибуття";
            this.DestinationSity.Width = 160;
            // 
            // Cost
            // 
            this.Cost.Text = "Вартість";
            this.Cost.Width = 100;
            // 
            // FreeSeats
            // 
            this.FreeSeats.Text = "Кількість вільних місць";
            this.FreeSeats.Width = 220;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(199, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пошук квітків";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Номер рейсу";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Час відправлення";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(779, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Місто відправки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1045, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Максимально допустима вартість";
            // 
            // tbNumberOfFlight
            // 
            this.tbNumberOfFlight.Location = new System.Drawing.Point(326, 121);
            this.tbNumberOfFlight.Name = "tbNumberOfFlight";
            this.tbNumberOfFlight.Size = new System.Drawing.Size(125, 27);
            this.tbNumberOfFlight.TabIndex = 9;
            // 
            // tbDepartureTime
            // 
            this.tbDepartureTime.Location = new System.Drawing.Point(618, 118);
            this.tbDepartureTime.Name = "tbDepartureTime";
            this.tbDepartureTime.Size = new System.Drawing.Size(125, 27);
            this.tbDepartureTime.TabIndex = 10;
            // 
            // tbDepartureSity
            // 
            this.tbDepartureSity.Location = new System.Drawing.Point(907, 118);
            this.tbDepartureSity.Name = "tbDepartureSity";
            this.tbDepartureSity.Size = new System.Drawing.Size(125, 27);
            this.tbDepartureSity.TabIndex = 11;
            // 
            // tbMaxCost
            // 
            this.tbMaxCost.Location = new System.Drawing.Point(1295, 121);
            this.tbMaxCost.Name = "tbMaxCost";
            this.tbMaxCost.Size = new System.Drawing.Size(125, 27);
            this.tbMaxCost.TabIndex = 12;
            // 
            // btDelateTicket
            // 
            this.btDelateTicket.Location = new System.Drawing.Point(218, 508);
            this.btDelateTicket.Name = "btDelateTicket";
            this.btDelateTicket.Size = new System.Drawing.Size(137, 35);
            this.btDelateTicket.TabIndex = 13;
            this.btDelateTicket.Text = "Видалити квиток";
            this.btDelateTicket.UseVisualStyleBackColor = true;
            this.btDelateTicket.Click += new System.EventHandler(this.btDelateTicket_Click);
            // 
            // btActivateFilter
            // 
            this.btActivateFilter.BackColor = System.Drawing.Color.LimeGreen;
            this.btActivateFilter.Location = new System.Drawing.Point(380, 86);
            this.btActivateFilter.Name = "btActivateFilter";
            this.btActivateFilter.Size = new System.Drawing.Size(150, 29);
            this.btActivateFilter.TabIndex = 14;
            this.btActivateFilter.Text = "Здійснити пошук";
            this.btActivateFilter.UseVisualStyleBackColor = false;
            this.btActivateFilter.Click += new System.EventHandler(this.btActivateFilter_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 653);
            this.Controls.Add(this.btActivateFilter);
            this.Controls.Add(this.btDelateTicket);
            this.Controls.Add(this.tbMaxCost);
            this.Controls.Add(this.tbDepartureSity);
            this.Controls.Add(this.tbDepartureTime);
            this.Controls.Add(this.tbNumberOfFlight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TicketListVie);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btBuySomeTickets;
        private System.Windows.Forms.Button btCreateTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView TicketListVie;
        private System.Windows.Forms.ColumnHeader FlightNumber;
        private System.Windows.Forms.ColumnHeader DepartureTime;
        private System.Windows.Forms.ColumnHeader ArrivalTime;
        private System.Windows.Forms.ColumnHeader TotalFliightTime;
        private System.Windows.Forms.ColumnHeader DepartureSity;
        private System.Windows.Forms.ColumnHeader DestinationSity;
        private System.Windows.Forms.ColumnHeader Cost;
        private System.Windows.Forms.ColumnHeader FreeSeats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNumberOfFlight;
        private System.Windows.Forms.TextBox tbDepartureTime;
        private System.Windows.Forms.TextBox tbDepartureSity;
        private System.Windows.Forms.TextBox tbMaxCost;
        private System.Windows.Forms.Button btDelateTicket;
        private System.Windows.Forms.Button btSaveList;
        private System.Windows.Forms.Button btOpenList;
        private System.Windows.Forms.Button btSaveToTxt;
        private System.Windows.Forms.Button btActivateFilter;
    }
}
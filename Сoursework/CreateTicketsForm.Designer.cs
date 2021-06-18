
namespace Сoursework
{
    partial class CreateTicketsForm
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
            this.btCreateTicket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDepartureSity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDestinationSity = new System.Windows.Forms.TextBox();
            this.tbDepartureTime = new System.Windows.Forms.TextBox();
            this.tbArrivalTime = new System.Windows.Forms.TextBox();
            this.tbFlightNumber = new System.Windows.Forms.TextBox();
            this.tbFreeSeats = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTotalFlightTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCreateTicket
            // 
            this.btCreateTicket.Location = new System.Drawing.Point(186, 472);
            this.btCreateTicket.Name = "btCreateTicket";
            this.btCreateTicket.Size = new System.Drawing.Size(176, 58);
            this.btCreateTicket.TabIndex = 0;
            this.btCreateTicket.Text = "Додати";
            this.btCreateTicket.UseVisualStyleBackColor = true;
            this.btCreateTicket.Click += new System.EventHandler(this.btCreateTicket_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Місто відправлення";
            // 
            // tbDepartureSity
            // 
            this.tbDepartureSity.Location = new System.Drawing.Point(225, 34);
            this.tbDepartureSity.Name = "tbDepartureSity";
            this.tbDepartureSity.Size = new System.Drawing.Size(150, 27);
            this.tbDepartureSity.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Місто прибуття";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Час відправлення";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Сумарний час перельоту";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Номер рейсу";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Кількість вільних місць ";
            // 
            // tbDestinationSity
            // 
            this.tbDestinationSity.Location = new System.Drawing.Point(225, 78);
            this.tbDestinationSity.Name = "tbDestinationSity";
            this.tbDestinationSity.Size = new System.Drawing.Size(150, 27);
            this.tbDestinationSity.TabIndex = 8;
            // 
            // tbDepartureTime
            // 
            this.tbDepartureTime.Location = new System.Drawing.Point(225, 132);
            this.tbDepartureTime.Name = "tbDepartureTime";
            this.tbDepartureTime.Size = new System.Drawing.Size(150, 27);
            this.tbDepartureTime.TabIndex = 9;
            // 
            // tbArrivalTime
            // 
            this.tbArrivalTime.Location = new System.Drawing.Point(225, 186);
            this.tbArrivalTime.Name = "tbArrivalTime";
            this.tbArrivalTime.Size = new System.Drawing.Size(150, 27);
            this.tbArrivalTime.TabIndex = 10;
            // 
            // tbFlightNumber
            // 
            this.tbFlightNumber.Location = new System.Drawing.Point(225, 243);
            this.tbFlightNumber.Name = "tbFlightNumber";
            this.tbFlightNumber.Size = new System.Drawing.Size(150, 27);
            this.tbFlightNumber.TabIndex = 11;
            // 
            // tbFreeSeats
            // 
            this.tbFreeSeats.Location = new System.Drawing.Point(225, 350);
            this.tbFreeSeats.Name = "tbFreeSeats";
            this.tbFreeSeats.Size = new System.Drawing.Size(150, 27);
            this.tbFreeSeats.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.tbCost);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbTotalFlightTime);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbFreeSeats);
            this.panel1.Controls.Add(this.tbDepartureSity);
            this.panel1.Controls.Add(this.tbFlightNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbArrivalTime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbDepartureTime);
            this.panel1.Controls.Add(this.tbDestinationSity);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(48, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 435);
            this.panel1.TabIndex = 13;
            // 
            // tbTotalFlightTime
            // 
            this.tbTotalFlightTime.Location = new System.Drawing.Point(225, 301);
            this.tbTotalFlightTime.Name = "tbTotalFlightTime";
            this.tbTotalFlightTime.Size = new System.Drawing.Size(150, 27);
            this.tbTotalFlightTime.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Час прибуття";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Вартість";
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(225, 390);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(150, 27);
            this.tbCost.TabIndex = 16;
            // 
            // CreateTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 542);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btCreateTicket);
            this.Name = "CreateTicketsForm";
            this.Text = "SearchTicketsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCreateTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDepartureSity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDestinationSity;
        private System.Windows.Forms.TextBox tbDepartureTime;
        private System.Windows.Forms.TextBox tbArrivalTime;
        private System.Windows.Forms.TextBox tbFlightNumber;
        private System.Windows.Forms.TextBox tbFreeSeats;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbTotalFlightTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label label8;
    }
}
namespace database1
{
    partial class train
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
            this.return_btn4 = new System.Windows.Forms.Button();
            this.submit_btn4 = new System.Windows.Forms.Button();
            this.ttrain_insert_label = new System.Windows.Forms.Label();
            this.train_number_label = new System.Windows.Forms.Label();
            this.train_num_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.company_id_fk = new System.Windows.Forms.TextBox();
            this.m_date_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.class_textbox = new System.Windows.Forms.TextBox();
            this.nofseats_label = new System.Windows.Forms.Label();
            this.station_id_depart_label = new System.Windows.Forms.Label();
            this.station_arrive_id_label = new System.Windows.Forms.Label();
            this.num_of_seats_textbox = new System.Windows.Forms.TextBox();
            this.depart_id_textbox = new System.Windows.Forms.TextBox();
            this.arrive_id_textbox = new System.Windows.Forms.TextBox();
            this.m_date_date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // return_btn4
            // 
            this.return_btn4.Location = new System.Drawing.Point(12, 386);
            this.return_btn4.Name = "return_btn4";
            this.return_btn4.Size = new System.Drawing.Size(132, 52);
            this.return_btn4.TabIndex = 0;
            this.return_btn4.Text = "Go Back";
            this.return_btn4.UseVisualStyleBackColor = true;
            this.return_btn4.Click += new System.EventHandler(this.return_btn4_Click);
            // 
            // submit_btn4
            // 
            this.submit_btn4.Location = new System.Drawing.Point(672, 386);
            this.submit_btn4.Name = "submit_btn4";
            this.submit_btn4.Size = new System.Drawing.Size(116, 52);
            this.submit_btn4.TabIndex = 1;
            this.submit_btn4.Text = "Submit";
            this.submit_btn4.UseVisualStyleBackColor = true;
            this.submit_btn4.Click += new System.EventHandler(this.submit_btn4_Click);
            // 
            // ttrain_insert_label
            // 
            this.ttrain_insert_label.AutoSize = true;
            this.ttrain_insert_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ttrain_insert_label.Location = new System.Drawing.Point(300, 39);
            this.ttrain_insert_label.Name = "ttrain_insert_label";
            this.ttrain_insert_label.Size = new System.Drawing.Size(238, 32);
            this.ttrain_insert_label.TabIndex = 2;
            this.ttrain_insert_label.Text = "Insert a new Train";
            // 
            // train_number_label
            // 
            this.train_number_label.AutoSize = true;
            this.train_number_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.train_number_label.Location = new System.Drawing.Point(220, 103);
            this.train_number_label.Name = "train_number_label";
            this.train_number_label.Size = new System.Drawing.Size(131, 25);
            this.train_number_label.TabIndex = 3;
            this.train_number_label.Text = "Train Number";
            // 
            // train_num_textbox
            // 
            this.train_num_textbox.Location = new System.Drawing.Point(441, 104);
            this.train_num_textbox.Name = "train_num_textbox";
            this.train_num_textbox.Size = new System.Drawing.Size(140, 26);
            this.train_num_textbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(230, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Company ID";
            // 
            // company_id_fk
            // 
            this.company_id_fk.Location = new System.Drawing.Point(441, 148);
            this.company_id_fk.Name = "company_id_fk";
            this.company_id_fk.Size = new System.Drawing.Size(140, 26);
            this.company_id_fk.TabIndex = 6;
            // 
            // m_date_label
            // 
            this.m_date_label.AutoSize = true;
            this.m_date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.m_date_label.Location = new System.Drawing.Point(169, 192);
            this.m_date_label.Name = "m_date_label";
            this.m_date_label.Size = new System.Drawing.Size(182, 25);
            this.m_date_label.TabIndex = 7;
            this.m_date_label.Text = "Manufacturing Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(289, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Class";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // class_textbox
            // 
            this.class_textbox.Location = new System.Drawing.Point(441, 239);
            this.class_textbox.Name = "class_textbox";
            this.class_textbox.Size = new System.Drawing.Size(140, 26);
            this.class_textbox.TabIndex = 10;
            // 
            // nofseats_label
            // 
            this.nofseats_label.AutoSize = true;
            this.nofseats_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nofseats_label.Location = new System.Drawing.Point(193, 281);
            this.nofseats_label.Name = "nofseats_label";
            this.nofseats_label.Size = new System.Drawing.Size(158, 25);
            this.nofseats_label.TabIndex = 11;
            this.nofseats_label.Text = "Number of Seats";
            // 
            // station_id_depart_label
            // 
            this.station_id_depart_label.AutoSize = true;
            this.station_id_depart_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.station_id_depart_label.Location = new System.Drawing.Point(163, 324);
            this.station_id_depart_label.Name = "station_id_depart_label";
            this.station_id_depart_label.Size = new System.Drawing.Size(188, 25);
            this.station_id_depart_label.TabIndex = 12;
            this.station_id_depart_label.Text = "Departure Station ID";
            // 
            // station_arrive_id_label
            // 
            this.station_arrive_id_label.AutoSize = true;
            this.station_arrive_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.station_arrive_id_label.Location = new System.Drawing.Point(193, 368);
            this.station_arrive_id_label.Name = "station_arrive_id_label";
            this.station_arrive_id_label.Size = new System.Drawing.Size(157, 25);
            this.station_arrive_id_label.TabIndex = 13;
            this.station_arrive_id_label.Text = "Arrival Station ID";
            // 
            // num_of_seats_textbox
            // 
            this.num_of_seats_textbox.Location = new System.Drawing.Point(441, 281);
            this.num_of_seats_textbox.Name = "num_of_seats_textbox";
            this.num_of_seats_textbox.Size = new System.Drawing.Size(140, 26);
            this.num_of_seats_textbox.TabIndex = 14;
            // 
            // depart_id_textbox
            // 
            this.depart_id_textbox.Location = new System.Drawing.Point(441, 325);
            this.depart_id_textbox.Name = "depart_id_textbox";
            this.depart_id_textbox.Size = new System.Drawing.Size(140, 26);
            this.depart_id_textbox.TabIndex = 15;
            // 
            // arrive_id_textbox
            // 
            this.arrive_id_textbox.Location = new System.Drawing.Point(441, 368);
            this.arrive_id_textbox.Name = "arrive_id_textbox";
            this.arrive_id_textbox.Size = new System.Drawing.Size(140, 26);
            this.arrive_id_textbox.TabIndex = 16;
            // 
            // m_date_date
            // 
            this.m_date_date.Location = new System.Drawing.Point(441, 192);
            this.m_date_date.Name = "m_date_date";
            this.m_date_date.Size = new System.Drawing.Size(200, 26);
            this.m_date_date.TabIndex = 17;
            // 
            // train
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.m_date_date);
            this.Controls.Add(this.arrive_id_textbox);
            this.Controls.Add(this.depart_id_textbox);
            this.Controls.Add(this.num_of_seats_textbox);
            this.Controls.Add(this.station_arrive_id_label);
            this.Controls.Add(this.station_id_depart_label);
            this.Controls.Add(this.nofseats_label);
            this.Controls.Add(this.class_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_date_label);
            this.Controls.Add(this.company_id_fk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.train_num_textbox);
            this.Controls.Add(this.train_number_label);
            this.Controls.Add(this.ttrain_insert_label);
            this.Controls.Add(this.submit_btn4);
            this.Controls.Add(this.return_btn4);
            this.Name = "train";
            this.Text = "train";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button return_btn4;
        private System.Windows.Forms.Button submit_btn4;
        private System.Windows.Forms.Label ttrain_insert_label;
        private System.Windows.Forms.Label train_number_label;
        private System.Windows.Forms.TextBox train_num_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox company_id_fk;
        private System.Windows.Forms.Label m_date_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox class_textbox;
        private System.Windows.Forms.Label nofseats_label;
        private System.Windows.Forms.Label station_id_depart_label;
        private System.Windows.Forms.Label station_arrive_id_label;
        private System.Windows.Forms.TextBox num_of_seats_textbox;
        private System.Windows.Forms.TextBox depart_id_textbox;
        private System.Windows.Forms.TextBox arrive_id_textbox;
        private System.Windows.Forms.DateTimePicker m_date_date;
    }
}
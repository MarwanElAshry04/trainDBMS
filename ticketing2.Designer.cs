namespace database1
{
    partial class ticketing2
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
            this.return_btn_7 = new System.Windows.Forms.Button();
            this.submit_btn_6 = new System.Windows.Forms.Button();
            this.new_ticket_label = new System.Windows.Forms.Label();
            this.tk_num_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.price_tk_label = new System.Windows.Forms.Label();
            this.tr_num_ticket_label = new System.Windows.Forms.Label();
            this.comp_id_tick_label = new System.Windows.Forms.Label();
            this.passenger_id_fk_ticket = new System.Windows.Forms.Label();
            this.tk_num_textbox = new System.Windows.Forms.TextBox();
            this.price_textbox = new System.Windows.Forms.TextBox();
            this.tk_train_textbox = new System.Windows.Forms.TextBox();
            this.company_tick_textbox = new System.Windows.Forms.TextBox();
            this.passenger_id_tick = new System.Windows.Forms.TextBox();
            this.p_date_picker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // return_btn_7
            // 
            this.return_btn_7.Location = new System.Drawing.Point(12, 379);
            this.return_btn_7.Name = "return_btn_7";
            this.return_btn_7.Size = new System.Drawing.Size(120, 59);
            this.return_btn_7.TabIndex = 0;
            this.return_btn_7.Text = "Go Back";
            this.return_btn_7.UseVisualStyleBackColor = true;
            this.return_btn_7.Click += new System.EventHandler(this.return_btn_7_Click);
            // 
            // submit_btn_6
            // 
            this.submit_btn_6.Location = new System.Drawing.Point(669, 379);
            this.submit_btn_6.Name = "submit_btn_6";
            this.submit_btn_6.Size = new System.Drawing.Size(119, 59);
            this.submit_btn_6.TabIndex = 1;
            this.submit_btn_6.Text = "Submit";
            this.submit_btn_6.UseVisualStyleBackColor = true;
            this.submit_btn_6.Click += new System.EventHandler(this.submit_btn_6_Click);
            // 
            // new_ticket_label
            // 
            this.new_ticket_label.AutoSize = true;
            this.new_ticket_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.new_ticket_label.Location = new System.Drawing.Point(280, 39);
            this.new_ticket_label.Name = "new_ticket_label";
            this.new_ticket_label.Size = new System.Drawing.Size(240, 32);
            this.new_ticket_label.TabIndex = 2;
            this.new_ticket_label.Text = "Insert a new ticket";
            // 
            // tk_num_label
            // 
            this.tk_num_label.AutoSize = true;
            this.tk_num_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tk_num_label.Location = new System.Drawing.Point(220, 106);
            this.tk_num_label.Name = "tk_num_label";
            this.tk_num_label.Size = new System.Drawing.Size(139, 25);
            this.tk_num_label.TabIndex = 3;
            this.tk_num_label.Text = "Ticket Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(220, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Purchase Date";
            // 
            // price_tk_label
            // 
            this.price_tk_label.AutoSize = true;
            this.price_tk_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.price_tk_label.Location = new System.Drawing.Point(303, 196);
            this.price_tk_label.Name = "price_tk_label";
            this.price_tk_label.Size = new System.Drawing.Size(56, 25);
            this.price_tk_label.TabIndex = 5;
            this.price_tk_label.Text = "Price";
            // 
            // tr_num_ticket_label
            // 
            this.tr_num_ticket_label.AutoSize = true;
            this.tr_num_ticket_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tr_num_ticket_label.Location = new System.Drawing.Point(228, 239);
            this.tr_num_ticket_label.Name = "tr_num_ticket_label";
            this.tr_num_ticket_label.Size = new System.Drawing.Size(131, 25);
            this.tr_num_ticket_label.TabIndex = 6;
            this.tr_num_ticket_label.Text = "Train Number";
            // 
            // comp_id_tick_label
            // 
            this.comp_id_tick_label.AutoSize = true;
            this.comp_id_tick_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comp_id_tick_label.Location = new System.Drawing.Point(238, 284);
            this.comp_id_tick_label.Name = "comp_id_tick_label";
            this.comp_id_tick_label.Size = new System.Drawing.Size(121, 25);
            this.comp_id_tick_label.TabIndex = 7;
            this.comp_id_tick_label.Text = "Company ID";
            // 
            // passenger_id_fk_ticket
            // 
            this.passenger_id_fk_ticket.AutoSize = true;
            this.passenger_id_fk_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passenger_id_fk_ticket.Location = new System.Drawing.Point(229, 332);
            this.passenger_id_fk_ticket.Name = "passenger_id_fk_ticket";
            this.passenger_id_fk_ticket.Size = new System.Drawing.Size(130, 25);
            this.passenger_id_fk_ticket.TabIndex = 8;
            this.passenger_id_fk_ticket.Text = "Passenger ID";
            // 
            // tk_num_textbox
            // 
            this.tk_num_textbox.Location = new System.Drawing.Point(420, 106);
            this.tk_num_textbox.Name = "tk_num_textbox";
            this.tk_num_textbox.Size = new System.Drawing.Size(138, 26);
            this.tk_num_textbox.TabIndex = 9;
            // 
            // price_textbox
            // 
            this.price_textbox.Location = new System.Drawing.Point(420, 197);
            this.price_textbox.Name = "price_textbox";
            this.price_textbox.Size = new System.Drawing.Size(138, 26);
            this.price_textbox.TabIndex = 11;
            // 
            // tk_train_textbox
            // 
            this.tk_train_textbox.Location = new System.Drawing.Point(420, 239);
            this.tk_train_textbox.Name = "tk_train_textbox";
            this.tk_train_textbox.Size = new System.Drawing.Size(138, 26);
            this.tk_train_textbox.TabIndex = 12;
            // 
            // company_tick_textbox
            // 
            this.company_tick_textbox.Location = new System.Drawing.Point(420, 284);
            this.company_tick_textbox.Name = "company_tick_textbox";
            this.company_tick_textbox.Size = new System.Drawing.Size(138, 26);
            this.company_tick_textbox.TabIndex = 13;
            // 
            // passenger_id_tick
            // 
            this.passenger_id_tick.Location = new System.Drawing.Point(420, 332);
            this.passenger_id_tick.Name = "passenger_id_tick";
            this.passenger_id_tick.Size = new System.Drawing.Size(138, 26);
            this.passenger_id_tick.TabIndex = 14;
            // 
            // p_date_picker
            // 
            this.p_date_picker.Location = new System.Drawing.Point(420, 153);
            this.p_date_picker.Name = "p_date_picker";
            this.p_date_picker.Size = new System.Drawing.Size(200, 26);
            this.p_date_picker.TabIndex = 15;
            // 
            // ticketing2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.p_date_picker);
            this.Controls.Add(this.passenger_id_tick);
            this.Controls.Add(this.company_tick_textbox);
            this.Controls.Add(this.tk_train_textbox);
            this.Controls.Add(this.price_textbox);
            this.Controls.Add(this.tk_num_textbox);
            this.Controls.Add(this.passenger_id_fk_ticket);
            this.Controls.Add(this.comp_id_tick_label);
            this.Controls.Add(this.tr_num_ticket_label);
            this.Controls.Add(this.price_tk_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tk_num_label);
            this.Controls.Add(this.new_ticket_label);
            this.Controls.Add(this.submit_btn_6);
            this.Controls.Add(this.return_btn_7);
            this.Name = "ticketing2";
            this.Text = "ticketing2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button return_btn_7;
        private System.Windows.Forms.Button submit_btn_6;
        private System.Windows.Forms.Label new_ticket_label;
        private System.Windows.Forms.Label tk_num_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label price_tk_label;
        private System.Windows.Forms.Label tr_num_ticket_label;
        private System.Windows.Forms.Label comp_id_tick_label;
        private System.Windows.Forms.Label passenger_id_fk_ticket;
        private System.Windows.Forms.TextBox tk_num_textbox;
        private System.Windows.Forms.TextBox price_textbox;
        private System.Windows.Forms.TextBox tk_train_textbox;
        private System.Windows.Forms.TextBox company_tick_textbox;
        private System.Windows.Forms.TextBox passenger_id_tick;
        private System.Windows.Forms.DateTimePicker p_date_picker;
    }
}
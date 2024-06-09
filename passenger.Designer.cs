namespace database1
{
    partial class passenger
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
            this.return_btn5 = new System.Windows.Forms.Button();
            this.submit_btn5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.passenger_id_label = new System.Windows.Forms.Label();
            this.first_name_label2 = new System.Windows.Forms.Label();
            this.label_name_label3 = new System.Windows.Forms.Label();
            this.pass_id_textbox = new System.Windows.Forms.TextBox();
            this.pass_fname_textbox = new System.Windows.Forms.TextBox();
            this.pass_lname_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // return_btn5
            // 
            this.return_btn5.Location = new System.Drawing.Point(12, 380);
            this.return_btn5.Name = "return_btn5";
            this.return_btn5.Size = new System.Drawing.Size(141, 58);
            this.return_btn5.TabIndex = 0;
            this.return_btn5.Text = "Go Back";
            this.return_btn5.UseVisualStyleBackColor = true;
            this.return_btn5.Click += new System.EventHandler(this.return_btn5_Click);
            // 
            // submit_btn5
            // 
            this.submit_btn5.Location = new System.Drawing.Point(639, 380);
            this.submit_btn5.Name = "submit_btn5";
            this.submit_btn5.Size = new System.Drawing.Size(149, 58);
            this.submit_btn5.TabIndex = 1;
            this.submit_btn5.Text = "Submit";
            this.submit_btn5.UseVisualStyleBackColor = true;
            this.submit_btn5.Click += new System.EventHandler(this.submit_btn5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(241, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insert a new Passenger";
            // 
            // passenger_id_label
            // 
            this.passenger_id_label.AutoSize = true;
            this.passenger_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passenger_id_label.Location = new System.Drawing.Point(196, 124);
            this.passenger_id_label.Name = "passenger_id_label";
            this.passenger_id_label.Size = new System.Drawing.Size(130, 25);
            this.passenger_id_label.TabIndex = 3;
            this.passenger_id_label.Text = "Passenger ID";
            this.passenger_id_label.Click += new System.EventHandler(this.passenger_id_label_Click);
            // 
            // first_name_label2
            // 
            this.first_name_label2.AutoSize = true;
            this.first_name_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.first_name_label2.Location = new System.Drawing.Point(220, 183);
            this.first_name_label2.Name = "first_name_label2";
            this.first_name_label2.Size = new System.Drawing.Size(106, 25);
            this.first_name_label2.TabIndex = 4;
            this.first_name_label2.Text = "First Name";
            // 
            // label_name_label3
            // 
            this.label_name_label3.AutoSize = true;
            this.label_name_label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_name_label3.Location = new System.Drawing.Point(220, 243);
            this.label_name_label3.Name = "label_name_label3";
            this.label_name_label3.Size = new System.Drawing.Size(106, 25);
            this.label_name_label3.TabIndex = 5;
            this.label_name_label3.Text = "Last Name";
            // 
            // pass_id_textbox
            // 
            this.pass_id_textbox.Location = new System.Drawing.Point(398, 125);
            this.pass_id_textbox.Name = "pass_id_textbox";
            this.pass_id_textbox.Size = new System.Drawing.Size(168, 26);
            this.pass_id_textbox.TabIndex = 6;
            // 
            // pass_fname_textbox
            // 
            this.pass_fname_textbox.Location = new System.Drawing.Point(398, 184);
            this.pass_fname_textbox.Name = "pass_fname_textbox";
            this.pass_fname_textbox.Size = new System.Drawing.Size(168, 26);
            this.pass_fname_textbox.TabIndex = 7;
            // 
            // pass_lname_textbox
            // 
            this.pass_lname_textbox.Location = new System.Drawing.Point(398, 244);
            this.pass_lname_textbox.Name = "pass_lname_textbox";
            this.pass_lname_textbox.Size = new System.Drawing.Size(168, 26);
            this.pass_lname_textbox.TabIndex = 8;
            // 
            // passenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pass_lname_textbox);
            this.Controls.Add(this.pass_fname_textbox);
            this.Controls.Add(this.pass_id_textbox);
            this.Controls.Add(this.label_name_label3);
            this.Controls.Add(this.first_name_label2);
            this.Controls.Add(this.passenger_id_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submit_btn5);
            this.Controls.Add(this.return_btn5);
            this.Name = "passenger";
            this.Text = "passenger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button return_btn5;
        private System.Windows.Forms.Button submit_btn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label passenger_id_label;
        private System.Windows.Forms.Label first_name_label2;
        private System.Windows.Forms.Label label_name_label3;
        private System.Windows.Forms.TextBox pass_id_textbox;
        private System.Windows.Forms.TextBox pass_fname_textbox;
        private System.Windows.Forms.TextBox pass_lname_textbox;
    }
}
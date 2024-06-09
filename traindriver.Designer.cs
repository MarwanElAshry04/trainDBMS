namespace database1
{
    partial class traindriver
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
            this.returnbtn3 = new System.Windows.Forms.Button();
            this.submitdriver_btn = new System.Windows.Forms.Button();
            this.driver_label = new System.Windows.Forms.Label();
            this.driver_id_label = new System.Windows.Forms.Label();
            this.first_name_label = new System.Windows.Forms.Label();
            this.last_name_label = new System.Windows.Forms.Label();
            this.driver_id_texbox = new System.Windows.Forms.TextBox();
            this.fname_driver_textbox = new System.Windows.Forms.TextBox();
            this.lastname_driver_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // returnbtn3
            // 
            this.returnbtn3.Location = new System.Drawing.Point(12, 377);
            this.returnbtn3.Name = "returnbtn3";
            this.returnbtn3.Size = new System.Drawing.Size(135, 61);
            this.returnbtn3.TabIndex = 0;
            this.returnbtn3.Text = "Go Back";
            this.returnbtn3.UseVisualStyleBackColor = true;
            this.returnbtn3.Click += new System.EventHandler(this.returnbtn3_Click);
            // 
            // submitdriver_btn
            // 
            this.submitdriver_btn.Location = new System.Drawing.Point(647, 377);
            this.submitdriver_btn.Name = "submitdriver_btn";
            this.submitdriver_btn.Size = new System.Drawing.Size(141, 61);
            this.submitdriver_btn.TabIndex = 1;
            this.submitdriver_btn.Text = "Submit";
            this.submitdriver_btn.UseVisualStyleBackColor = true;
            this.submitdriver_btn.Click += new System.EventHandler(this.submitdriver_btn_Click);
            // 
            // driver_label
            // 
            this.driver_label.AutoSize = true;
            this.driver_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.driver_label.Location = new System.Drawing.Point(281, 31);
            this.driver_label.Name = "driver_label";
            this.driver_label.Size = new System.Drawing.Size(248, 32);
            this.driver_label.TabIndex = 2;
            this.driver_label.Text = "Insert a new Driver";
            // 
            // driver_id_label
            // 
            this.driver_id_label.AutoSize = true;
            this.driver_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.driver_id_label.Location = new System.Drawing.Point(240, 114);
            this.driver_id_label.Name = "driver_id_label";
            this.driver_id_label.Size = new System.Drawing.Size(87, 25);
            this.driver_id_label.TabIndex = 3;
            this.driver_id_label.Text = "Driver ID";
            // 
            // first_name_label
            // 
            this.first_name_label.AutoSize = true;
            this.first_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.first_name_label.Location = new System.Drawing.Point(221, 173);
            this.first_name_label.Name = "first_name_label";
            this.first_name_label.Size = new System.Drawing.Size(106, 25);
            this.first_name_label.TabIndex = 4;
            this.first_name_label.Text = "First Name";
            // 
            // last_name_label
            // 
            this.last_name_label.AutoSize = true;
            this.last_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.last_name_label.Location = new System.Drawing.Point(221, 232);
            this.last_name_label.Name = "last_name_label";
            this.last_name_label.Size = new System.Drawing.Size(106, 25);
            this.last_name_label.TabIndex = 5;
            this.last_name_label.Text = "Last Name";
            // 
            // driver_id_texbox
            // 
            this.driver_id_texbox.Location = new System.Drawing.Point(395, 114);
            this.driver_id_texbox.Name = "driver_id_texbox";
            this.driver_id_texbox.Size = new System.Drawing.Size(164, 26);
            this.driver_id_texbox.TabIndex = 6;
            // 
            // fname_driver_textbox
            // 
            this.fname_driver_textbox.Location = new System.Drawing.Point(395, 173);
            this.fname_driver_textbox.Name = "fname_driver_textbox";
            this.fname_driver_textbox.Size = new System.Drawing.Size(164, 26);
            this.fname_driver_textbox.TabIndex = 7;
            // 
            // lastname_driver_textbox
            // 
            this.lastname_driver_textbox.Location = new System.Drawing.Point(395, 232);
            this.lastname_driver_textbox.Name = "lastname_driver_textbox";
            this.lastname_driver_textbox.Size = new System.Drawing.Size(164, 26);
            this.lastname_driver_textbox.TabIndex = 8;
            // 
            // traindriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lastname_driver_textbox);
            this.Controls.Add(this.fname_driver_textbox);
            this.Controls.Add(this.driver_id_texbox);
            this.Controls.Add(this.last_name_label);
            this.Controls.Add(this.first_name_label);
            this.Controls.Add(this.driver_id_label);
            this.Controls.Add(this.driver_label);
            this.Controls.Add(this.submitdriver_btn);
            this.Controls.Add(this.returnbtn3);
            this.Name = "traindriver";
            this.Text = "u";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnbtn3;
        private System.Windows.Forms.Button submitdriver_btn;
        private System.Windows.Forms.Label driver_label;
        private System.Windows.Forms.Label driver_id_label;
        private System.Windows.Forms.Label first_name_label;
        private System.Windows.Forms.Label last_name_label;
        private System.Windows.Forms.TextBox driver_id_texbox;
        private System.Windows.Forms.TextBox fname_driver_textbox;
        private System.Windows.Forms.TextBox lastname_driver_textbox;
    }
}
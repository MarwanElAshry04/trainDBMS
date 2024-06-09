namespace database1
{
    partial class drives
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
            this.label1 = new System.Windows.Forms.Label();
            this.drives_insert_label = new System.Windows.Forms.Label();
            this.return_btn6 = new System.Windows.Forms.Button();
            this.submit_btn6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.drives_tnum_textbox = new System.Windows.Forms.TextBox();
            this.drives_cid_textbox = new System.Windows.Forms.TextBox();
            this.drives_did_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // drives_insert_label
            // 
            this.drives_insert_label.AutoSize = true;
            this.drives_insert_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.drives_insert_label.Location = new System.Drawing.Point(283, 45);
            this.drives_insert_label.Name = "drives_insert_label";
            this.drives_insert_label.Size = new System.Drawing.Size(253, 32);
            this.drives_insert_label.TabIndex = 1;
            this.drives_insert_label.Text = "Insert a new record";
            // 
            // return_btn6
            // 
            this.return_btn6.Location = new System.Drawing.Point(12, 386);
            this.return_btn6.Name = "return_btn6";
            this.return_btn6.Size = new System.Drawing.Size(114, 52);
            this.return_btn6.TabIndex = 2;
            this.return_btn6.Text = "Go Back";
            this.return_btn6.UseVisualStyleBackColor = true;
            this.return_btn6.Click += new System.EventHandler(this.return_btn6_Click);
            // 
            // submit_btn6
            // 
            this.submit_btn6.Location = new System.Drawing.Point(669, 386);
            this.submit_btn6.Name = "submit_btn6";
            this.submit_btn6.Size = new System.Drawing.Size(119, 52);
            this.submit_btn6.TabIndex = 3;
            this.submit_btn6.Text = "Submit";
            this.submit_btn6.UseVisualStyleBackColor = true;
            this.submit_btn6.Click += new System.EventHandler(this.submit_btn6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(187, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Train Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(197, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Company ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(231, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Driver ID";
            // 
            // drives_tnum_textbox
            // 
            this.drives_tnum_textbox.Location = new System.Drawing.Point(372, 121);
            this.drives_tnum_textbox.Name = "drives_tnum_textbox";
            this.drives_tnum_textbox.Size = new System.Drawing.Size(164, 26);
            this.drives_tnum_textbox.TabIndex = 7;
            // 
            // drives_cid_textbox
            // 
            this.drives_cid_textbox.Location = new System.Drawing.Point(372, 175);
            this.drives_cid_textbox.Name = "drives_cid_textbox";
            this.drives_cid_textbox.Size = new System.Drawing.Size(164, 26);
            this.drives_cid_textbox.TabIndex = 8;
            // 
            // drives_did_textbox
            // 
            this.drives_did_textbox.Location = new System.Drawing.Point(372, 227);
            this.drives_did_textbox.Name = "drives_did_textbox";
            this.drives_did_textbox.Size = new System.Drawing.Size(164, 26);
            this.drives_did_textbox.TabIndex = 9;
            // 
            // drives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drives_did_textbox);
            this.Controls.Add(this.drives_cid_textbox);
            this.Controls.Add(this.drives_tnum_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submit_btn6);
            this.Controls.Add(this.return_btn6);
            this.Controls.Add(this.drives_insert_label);
            this.Controls.Add(this.label1);
            this.Name = "drives";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label drives_insert_label;
        private System.Windows.Forms.Button return_btn6;
        private System.Windows.Forms.Button submit_btn6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox drives_tnum_textbox;
        private System.Windows.Forms.TextBox drives_cid_textbox;
        private System.Windows.Forms.TextBox drives_did_textbox;
    }
}
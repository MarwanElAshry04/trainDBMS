namespace database1
{
    partial class TrainCompany
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
            this.gobackbutton = new System.Windows.Forms.Button();
            this.c_id_textbox = new System.Windows.Forms.TextBox();
            this.newcompany = new System.Windows.Forms.Label();
            this.comp_id = new System.Windows.Forms.Label();
            this.comp_name = new System.Windows.Forms.Label();
            this.c_name_textbox = new System.Windows.Forms.TextBox();
            this.submitcompanybtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gobackbutton
            // 
            this.gobackbutton.Location = new System.Drawing.Point(25, 367);
            this.gobackbutton.Name = "gobackbutton";
            this.gobackbutton.Size = new System.Drawing.Size(161, 62);
            this.gobackbutton.TabIndex = 0;
            this.gobackbutton.Text = "Go Back";
            this.gobackbutton.UseVisualStyleBackColor = true;
            this.gobackbutton.Click += new System.EventHandler(this.gobackbutton_Click);
            // 
            // c_id_textbox
            // 
            this.c_id_textbox.Location = new System.Drawing.Point(423, 127);
            this.c_id_textbox.Name = "c_id_textbox";
            this.c_id_textbox.Size = new System.Drawing.Size(125, 26);
            this.c_id_textbox.TabIndex = 1;
            // 
            // newcompany
            // 
            this.newcompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.newcompany.Location = new System.Drawing.Point(261, 41);
            this.newcompany.Name = "newcompany";
            this.newcompany.Size = new System.Drawing.Size(287, 47);
            this.newcompany.TabIndex = 2;
            this.newcompany.Text = "Insert New Company";
            // 
            // comp_id
            // 
            this.comp_id.AutoSize = true;
            this.comp_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comp_id.Location = new System.Drawing.Point(262, 126);
            this.comp_id.Name = "comp_id";
            this.comp_id.Size = new System.Drawing.Size(121, 25);
            this.comp_id.TabIndex = 3;
            this.comp_id.Text = "Company ID";
            // 
            // comp_name
            // 
            this.comp_name.AutoSize = true;
            this.comp_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comp_name.Location = new System.Drawing.Point(229, 197);
            this.comp_name.Name = "comp_name";
            this.comp_name.Size = new System.Drawing.Size(154, 25);
            this.comp_name.TabIndex = 4;
            this.comp_name.Text = "Company Name";
            // 
            // c_name_textbox
            // 
            this.c_name_textbox.Location = new System.Drawing.Point(423, 197);
            this.c_name_textbox.Name = "c_name_textbox";
            this.c_name_textbox.Size = new System.Drawing.Size(125, 26);
            this.c_name_textbox.TabIndex = 5;
            // 
            // submitcompanybtn
            // 
            this.submitcompanybtn.Location = new System.Drawing.Point(635, 367);
            this.submitcompanybtn.Name = "submitcompanybtn";
            this.submitcompanybtn.Size = new System.Drawing.Size(153, 62);
            this.submitcompanybtn.TabIndex = 6;
            this.submitcompanybtn.Text = "Submit";
            this.submitcompanybtn.UseVisualStyleBackColor = true;
            this.submitcompanybtn.Click += new System.EventHandler(this.submitcompanybtn_Click);
            // 
            // TrainCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitcompanybtn);
            this.Controls.Add(this.c_name_textbox);
            this.Controls.Add(this.comp_name);
            this.Controls.Add(this.comp_id);
            this.Controls.Add(this.newcompany);
            this.Controls.Add(this.c_id_textbox);
            this.Controls.Add(this.gobackbutton);
            this.Name = "TrainCompany";
            this.Text = "TrainCompany";
            this.Load += new System.EventHandler(this.TrainCompany_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gobackbutton;
        private System.Windows.Forms.TextBox c_id_textbox;
        private System.Windows.Forms.Label newcompany;
        private System.Windows.Forms.Label comp_id;
        private System.Windows.Forms.Label comp_name;
        private System.Windows.Forms.TextBox c_name_textbox;
        private System.Windows.Forms.Button submitcompanybtn;
    }
}
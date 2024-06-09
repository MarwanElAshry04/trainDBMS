namespace database1
{
    partial class train_companies
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
            this.return_btn11 = new System.Windows.Forms.Button();
            this.train_company_label2 = new System.Windows.Forms.Label();
            this.display_btn6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // return_btn11
            // 
            this.return_btn11.Location = new System.Drawing.Point(13, 392);
            this.return_btn11.Name = "return_btn11";
            this.return_btn11.Size = new System.Drawing.Size(140, 46);
            this.return_btn11.TabIndex = 0;
            this.return_btn11.Text = "Go Back";
            this.return_btn11.UseVisualStyleBackColor = true;
            this.return_btn11.Click += new System.EventHandler(this.return_btn11_Click);
            // 
            // train_company_label2
            // 
            this.train_company_label2.AutoSize = true;
            this.train_company_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.train_company_label2.Location = new System.Drawing.Point(280, 48);
            this.train_company_label2.Name = "train_company_label2";
            this.train_company_label2.Size = new System.Drawing.Size(251, 32);
            this.train_company_label2.TabIndex = 1;
            this.train_company_label2.Text = "Train\'s companies:";
            this.train_company_label2.Click += new System.EventHandler(this.train_company_label2_Click);
            // 
            // display_btn6
            // 
            this.display_btn6.Location = new System.Drawing.Point(655, 392);
            this.display_btn6.Name = "display_btn6";
            this.display_btn6.Size = new System.Drawing.Size(133, 46);
            this.display_btn6.TabIndex = 6;
            this.display_btn6.Text = "Display";
            this.display_btn6.UseVisualStyleBackColor = true;
            this.display_btn6.Click += new System.EventHandler(this.display_btn6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(139, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(514, 232);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // train_companies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.display_btn6);
            this.Controls.Add(this.train_company_label2);
            this.Controls.Add(this.return_btn11);
            this.Name = "train_companies";
            this.Text = "train_companies";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button return_btn11;
        private System.Windows.Forms.Label train_company_label2;
        private System.Windows.Forms.Button display_btn6;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
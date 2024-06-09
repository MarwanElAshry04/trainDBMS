namespace database1
{
    partial class company_revenue
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
            this.return_btn12 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.company_idsearch_label = new System.Windows.Forms.Label();
            this.search_cid_textbox = new System.Windows.Forms.TextBox();
            this.revenue_data = new System.Windows.Forms.DataGridView();
            this.display_btn5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.revenue_data)).BeginInit();
            this.SuspendLayout();
            // 
            // return_btn12
            // 
            this.return_btn12.Location = new System.Drawing.Point(13, 392);
            this.return_btn12.Name = "return_btn12";
            this.return_btn12.Size = new System.Drawing.Size(141, 46);
            this.return_btn12.TabIndex = 0;
            this.return_btn12.Text = "Go Back";
            this.return_btn12.UseVisualStyleBackColor = true;
            this.return_btn12.Click += new System.EventHandler(this.return_btn12_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(224, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Train Company\'s Revenue";
            // 
            // company_idsearch_label
            // 
            this.company_idsearch_label.AutoSize = true;
            this.company_idsearch_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.company_idsearch_label.Location = new System.Drawing.Point(225, 114);
            this.company_idsearch_label.Name = "company_idsearch_label";
            this.company_idsearch_label.Size = new System.Drawing.Size(121, 25);
            this.company_idsearch_label.TabIndex = 2;
            this.company_idsearch_label.Text = "Company ID";
            // 
            // search_cid_textbox
            // 
            this.search_cid_textbox.Location = new System.Drawing.Point(388, 114);
            this.search_cid_textbox.Name = "search_cid_textbox";
            this.search_cid_textbox.Size = new System.Drawing.Size(117, 26);
            this.search_cid_textbox.TabIndex = 3;
            // 
            // revenue_data
            // 
            this.revenue_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.revenue_data.Location = new System.Drawing.Point(187, 168);
            this.revenue_data.Name = "revenue_data";
            this.revenue_data.RowHeadersWidth = 62;
            this.revenue_data.RowTemplate.Height = 28;
            this.revenue_data.Size = new System.Drawing.Size(431, 184);
            this.revenue_data.TabIndex = 4;
            // 
            // display_btn5
            // 
            this.display_btn5.Location = new System.Drawing.Point(644, 392);
            this.display_btn5.Name = "display_btn5";
            this.display_btn5.Size = new System.Drawing.Size(144, 46);
            this.display_btn5.TabIndex = 5;
            this.display_btn5.Text = "Display";
            this.display_btn5.UseVisualStyleBackColor = true;
            this.display_btn5.Click += new System.EventHandler(this.display_btn5_Click);
            // 
            // company_revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.display_btn5);
            this.Controls.Add(this.revenue_data);
            this.Controls.Add(this.search_cid_textbox);
            this.Controls.Add(this.company_idsearch_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.return_btn12);
            this.Name = "company_revenue";
            this.Text = "company_revenue";
            ((System.ComponentModel.ISupportInitialize)(this.revenue_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button return_btn12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label company_idsearch_label;
        private System.Windows.Forms.TextBox search_cid_textbox;
        private System.Windows.Forms.DataGridView revenue_data;
        private System.Windows.Forms.Button display_btn5;
    }
}
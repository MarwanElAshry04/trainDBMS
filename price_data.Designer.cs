namespace database1
{
    partial class price_data
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
            this.return_btn10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.train_num_price_textbox = new System.Windows.Forms.TextBox();
            this.Minimum_Ticket_Price = new System.Windows.Forms.ListBox();
            this.Maximum_Ticket_Price = new System.Windows.Forms.ListBox();
            this.display_btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // return_btn10
            // 
            this.return_btn10.Location = new System.Drawing.Point(13, 394);
            this.return_btn10.Name = "return_btn10";
            this.return_btn10.Size = new System.Drawing.Size(124, 44);
            this.return_btn10.TabIndex = 0;
            this.return_btn10.Text = "Go Back";
            this.return_btn10.UseVisualStyleBackColor = true;
            this.return_btn10.Click += new System.EventHandler(this.return_btn10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(200, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maximum and minimum price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(87, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter the train number:";
            // 
            // train_num_price_textbox
            // 
            this.train_num_price_textbox.Location = new System.Drawing.Point(336, 128);
            this.train_num_price_textbox.Name = "train_num_price_textbox";
            this.train_num_price_textbox.Size = new System.Drawing.Size(172, 26);
            this.train_num_price_textbox.TabIndex = 3;
            // 
            // Minimum_Ticket_Price
            // 
            this.Minimum_Ticket_Price.FormattingEnabled = true;
            this.Minimum_Ticket_Price.ItemHeight = 20;
            this.Minimum_Ticket_Price.Location = new System.Drawing.Point(181, 201);
            this.Minimum_Ticket_Price.Name = "Minimum_Ticket_Price";
            this.Minimum_Ticket_Price.Size = new System.Drawing.Size(172, 84);
            this.Minimum_Ticket_Price.TabIndex = 4;
            // 
            // Maximum_Ticket_Price
            // 
            this.Maximum_Ticket_Price.FormattingEnabled = true;
            this.Maximum_Ticket_Price.ItemHeight = 20;
            this.Maximum_Ticket_Price.Location = new System.Drawing.Point(451, 201);
            this.Maximum_Ticket_Price.Name = "Maximum_Ticket_Price";
            this.Maximum_Ticket_Price.Size = new System.Drawing.Size(176, 84);
            this.Maximum_Ticket_Price.TabIndex = 5;
            // 
            // display_btn2
            // 
            this.display_btn2.Location = new System.Drawing.Point(668, 394);
            this.display_btn2.Name = "display_btn2";
            this.display_btn2.Size = new System.Drawing.Size(120, 44);
            this.display_btn2.TabIndex = 6;
            this.display_btn2.Text = "Display";
            this.display_btn2.UseVisualStyleBackColor = true;
            this.display_btn2.Click += new System.EventHandler(this.display_btn2_Click);
            // 
            // price_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.display_btn2);
            this.Controls.Add(this.Maximum_Ticket_Price);
            this.Controls.Add(this.Minimum_Ticket_Price);
            this.Controls.Add(this.train_num_price_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.return_btn10);
            this.Name = "price_data";
            this.Text = "price_data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button return_btn10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox train_num_price_textbox;
        private System.Windows.Forms.ListBox Minimum_Ticket_Price;
        private System.Windows.Forms.ListBox Maximum_Ticket_Price;
        private System.Windows.Forms.Button display_btn2;
    }
}
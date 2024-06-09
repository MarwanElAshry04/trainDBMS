namespace database1
{
    partial class passenger_count
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
            this.num_passengers_label = new System.Windows.Forms.Label();
            this.passenger_data = new System.Windows.Forms.DataGridView();
            this.return_btn14 = new System.Windows.Forms.Button();
            this.Display_btn7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.passenger_data)).BeginInit();
            this.SuspendLayout();
            // 
            // num_passengers_label
            // 
            this.num_passengers_label.AutoSize = true;
            this.num_passengers_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.num_passengers_label.Location = new System.Drawing.Point(199, 37);
            this.num_passengers_label.Name = "num_passengers_label";
            this.num_passengers_label.Size = new System.Drawing.Size(410, 32);
            this.num_passengers_label.TabIndex = 0;
            this.num_passengers_label.Text = "Number of passengers per train";
            // 
            // passenger_data
            // 
            this.passenger_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passenger_data.Location = new System.Drawing.Point(130, 100);
            this.passenger_data.Name = "passenger_data";
            this.passenger_data.RowHeadersWidth = 62;
            this.passenger_data.RowTemplate.Height = 28;
            this.passenger_data.Size = new System.Drawing.Size(536, 278);
            this.passenger_data.TabIndex = 1;
            // 
            // return_btn14
            // 
            this.return_btn14.Location = new System.Drawing.Point(13, 395);
            this.return_btn14.Name = "return_btn14";
            this.return_btn14.Size = new System.Drawing.Size(131, 43);
            this.return_btn14.TabIndex = 2;
            this.return_btn14.Text = "Go Back";
            this.return_btn14.UseVisualStyleBackColor = true;
            this.return_btn14.Click += new System.EventHandler(this.return_btn14_Click);
            // 
            // Display_btn7
            // 
            this.Display_btn7.Location = new System.Drawing.Point(671, 395);
            this.Display_btn7.Name = "Display_btn7";
            this.Display_btn7.Size = new System.Drawing.Size(117, 43);
            this.Display_btn7.TabIndex = 3;
            this.Display_btn7.Text = "Display";
            this.Display_btn7.UseVisualStyleBackColor = true;
            this.Display_btn7.Click += new System.EventHandler(this.Display_btn7_Click);
            // 
            // passenger_count
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Display_btn7);
            this.Controls.Add(this.return_btn14);
            this.Controls.Add(this.passenger_data);
            this.Controls.Add(this.num_passengers_label);
            this.Name = "passenger_count";
            this.Text = "passenger_count";
            ((System.ComponentModel.ISupportInitialize)(this.passenger_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num_passengers_label;
        private System.Windows.Forms.DataGridView passenger_data;
        private System.Windows.Forms.Button return_btn14;
        private System.Windows.Forms.Button Display_btn7;
    }
}
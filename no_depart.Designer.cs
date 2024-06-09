namespace database1
{
    partial class no_depart
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
            this.return_btn16 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stations_data = new System.Windows.Forms.DataGridView();
            this.Display_btn10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stations_data)).BeginInit();
            this.SuspendLayout();
            // 
            // return_btn16
            // 
            this.return_btn16.Location = new System.Drawing.Point(12, 397);
            this.return_btn16.Name = "return_btn16";
            this.return_btn16.Size = new System.Drawing.Size(120, 41);
            this.return_btn16.TabIndex = 0;
            this.return_btn16.Text = "Go Back";
            this.return_btn16.UseVisualStyleBackColor = true;
            this.return_btn16.Click += new System.EventHandler(this.return_btn16_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(227, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stations with no departures";
            // 
            // stations_data
            // 
            this.stations_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stations_data.Location = new System.Drawing.Point(103, 99);
            this.stations_data.Name = "stations_data";
            this.stations_data.RowHeadersWidth = 62;
            this.stations_data.RowTemplate.Height = 28;
            this.stations_data.Size = new System.Drawing.Size(611, 274);
            this.stations_data.TabIndex = 2;
            // 
            // Display_btn10
            // 
            this.Display_btn10.Location = new System.Drawing.Point(668, 397);
            this.Display_btn10.Name = "Display_btn10";
            this.Display_btn10.Size = new System.Drawing.Size(120, 41);
            this.Display_btn10.TabIndex = 3;
            this.Display_btn10.Text = "Display";
            this.Display_btn10.UseVisualStyleBackColor = true;
            this.Display_btn10.Click += new System.EventHandler(this.Display_btn10_Click);
            // 
            // no_depart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Display_btn10);
            this.Controls.Add(this.stations_data);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.return_btn16);
            this.Name = "no_depart";
            this.Text = "no_depart";
            ((System.ComponentModel.ISupportInitialize)(this.stations_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button return_btn16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView stations_data;
        private System.Windows.Forms.Button Display_btn10;
    }
}
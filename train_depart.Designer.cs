namespace database1
{
    partial class train_depart
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
            this.return_btn9 = new System.Windows.Forms.Button();
            this.display_btn1 = new System.Windows.Forms.Button();
            this.Trains = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.station_id_textbox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // return_btn9
            // 
            this.return_btn9.Location = new System.Drawing.Point(12, 389);
            this.return_btn9.Name = "return_btn9";
            this.return_btn9.Size = new System.Drawing.Size(125, 49);
            this.return_btn9.TabIndex = 0;
            this.return_btn9.Text = "Go Back";
            this.return_btn9.UseVisualStyleBackColor = true;
            this.return_btn9.Click += new System.EventHandler(this.Return_btn9_Click);
            // 
            // display_btn1
            // 
            this.display_btn1.Location = new System.Drawing.Point(656, 389);
            this.display_btn1.Name = "display_btn1";
            this.display_btn1.Size = new System.Drawing.Size(132, 49);
            this.display_btn1.TabIndex = 1;
            this.display_btn1.Text = "Display";
            this.display_btn1.UseVisualStyleBackColor = true;
            this.display_btn1.Click += new System.EventHandler(this.Display_btn1_Click);
            // 
            // Trains
            // 
            this.Trains.FormattingEnabled = true;
            this.Trains.ItemHeight = 20;
            this.Trains.Location = new System.Drawing.Point(239, 154);
            this.Trains.Name = "Trains";
            this.Trains.Size = new System.Drawing.Size(339, 224);
            this.Trains.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter the station:";
            // 
            // station_id_textbox2
            // 
            this.station_id_textbox2.Location = new System.Drawing.Point(262, 40);
            this.station_id_textbox2.Name = "station_id_textbox2";
            this.station_id_textbox2.Size = new System.Drawing.Size(223, 26);
            this.station_id_textbox2.TabIndex = 4;
            // 
            // train_depart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.station_id_textbox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Trains);
            this.Controls.Add(this.display_btn1);
            this.Controls.Add(this.return_btn9);
            this.Name = "train_depart";
            this.Text = "train_depart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button return_btn9;
        private System.Windows.Forms.Button display_btn1;
        private System.Windows.Forms.ListBox Trains;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox station_id_textbox2;
    }
}
namespace database1
{
    partial class station
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
            this.returnbtn2 = new System.Windows.Forms.Button();
            this.submitbtn2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.station_id = new System.Windows.Forms.Label();
            this.station_name = new System.Windows.Forms.Label();
            this.station_location = new System.Windows.Forms.Label();
            this.s_id_textbox = new System.Windows.Forms.TextBox();
            this.s_name_textbox = new System.Windows.Forms.TextBox();
            this.s_location_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // returnbtn2
            // 
            this.returnbtn2.Location = new System.Drawing.Point(12, 368);
            this.returnbtn2.Name = "returnbtn2";
            this.returnbtn2.Size = new System.Drawing.Size(163, 70);
            this.returnbtn2.TabIndex = 0;
            this.returnbtn2.Text = "Go Back";
            this.returnbtn2.UseVisualStyleBackColor = true;
            this.returnbtn2.Click += new System.EventHandler(this.returnbtn2_Click);
            // 
            // submitbtn2
            // 
            this.submitbtn2.Location = new System.Drawing.Point(633, 368);
            this.submitbtn2.Name = "submitbtn2";
            this.submitbtn2.Size = new System.Drawing.Size(155, 70);
            this.submitbtn2.TabIndex = 1;
            this.submitbtn2.Text = "Submit";
            this.submitbtn2.UseVisualStyleBackColor = true;
            this.submitbtn2.Click += new System.EventHandler(this.submitbtn2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(299, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insert New Station";
            // 
            // station_id
            // 
            this.station_id.AutoSize = true;
            this.station_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.station_id.Location = new System.Drawing.Point(249, 120);
            this.station_id.Name = "station_id";
            this.station_id.Size = new System.Drawing.Size(97, 25);
            this.station_id.TabIndex = 3;
            this.station_id.Text = "Station ID";
            // 
            // station_name
            // 
            this.station_name.AutoSize = true;
            this.station_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.station_name.Location = new System.Drawing.Point(216, 188);
            this.station_name.Name = "station_name";
            this.station_name.Size = new System.Drawing.Size(130, 25);
            this.station_name.TabIndex = 4;
            this.station_name.Text = "Station Name";
            // 
            // station_location
            // 
            this.station_location.AutoSize = true;
            this.station_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.station_location.Location = new System.Drawing.Point(260, 252);
            this.station_location.Name = "station_location";
            this.station_location.Size = new System.Drawing.Size(86, 25);
            this.station_location.TabIndex = 5;
            this.station_location.Text = "Location";
            // 
            // s_id_textbox
            // 
            this.s_id_textbox.Location = new System.Drawing.Point(395, 119);
            this.s_id_textbox.Name = "s_id_textbox";
            this.s_id_textbox.Size = new System.Drawing.Size(148, 26);
            this.s_id_textbox.TabIndex = 6;
            // 
            // s_name_textbox
            // 
            this.s_name_textbox.Location = new System.Drawing.Point(395, 188);
            this.s_name_textbox.Name = "s_name_textbox";
            this.s_name_textbox.Size = new System.Drawing.Size(148, 26);
            this.s_name_textbox.TabIndex = 7;
            // 
            // s_location_textbox
            // 
            this.s_location_textbox.Location = new System.Drawing.Point(395, 252);
            this.s_location_textbox.Name = "s_location_textbox";
            this.s_location_textbox.Size = new System.Drawing.Size(148, 26);
            this.s_location_textbox.TabIndex = 8;
            // 
            // station
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.s_location_textbox);
            this.Controls.Add(this.s_name_textbox);
            this.Controls.Add(this.s_id_textbox);
            this.Controls.Add(this.station_location);
            this.Controls.Add(this.station_name);
            this.Controls.Add(this.station_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitbtn2);
            this.Controls.Add(this.returnbtn2);
            this.Name = "station";
            this.Text = "station";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnbtn2;
        private System.Windows.Forms.Button submitbtn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label station_id;
        private System.Windows.Forms.Label station_name;
        private System.Windows.Forms.Label station_location;
        private System.Windows.Forms.TextBox s_id_textbox;
        private System.Windows.Forms.TextBox s_name_textbox;
        private System.Windows.Forms.TextBox s_location_textbox;
    }
}
namespace StripColorBits
{
	partial class Form1
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
			this.cmbBits = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSelectColor = new System.Windows.Forms.Button();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.SuspendLayout();
			// 
			// cmbBits
			// 
			this.cmbBits.FormattingEnabled = true;
			this.cmbBits.Items.AddRange(new object[] {
            "None",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
			this.cmbBits.Location = new System.Drawing.Point(646, 151);
			this.cmbBits.Name = "cmbBits";
			this.cmbBits.Size = new System.Drawing.Size(121, 21);
			this.cmbBits.TabIndex = 0;
			this.cmbBits.SelectedIndexChanged += new System.EventHandler(this.OnSelectionChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(580, 154);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Bits to Strip";
			// 
			// btnSelectColor
			// 
			this.btnSelectColor.Location = new System.Drawing.Point(484, 149);
			this.btnSelectColor.Name = "btnSelectColor";
			this.btnSelectColor.Size = new System.Drawing.Size(75, 23);
			this.btnSelectColor.TabIndex = 2;
			this.btnSelectColor.Text = "Select Color";
			this.btnSelectColor.UseVisualStyleBackColor = true;
			this.btnSelectColor.Click += new System.EventHandler(this.btnSelectColor_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(924, 237);
			this.Controls.Add(this.btnSelectColor);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbBits);
			this.Name = "Form1";
			this.Text = "Strip Color Bits";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbBits;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSelectColor;
		private System.Windows.Forms.ColorDialog colorDialog1;
	}
}


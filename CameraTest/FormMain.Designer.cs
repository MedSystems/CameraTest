namespace WindowsFormsAppCamTest
{
	partial class FormMain
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
			this.cboCamera = new System.Windows.Forms.ComboBox();
			this.picCamera = new System.Windows.Forms.PictureBox();
			this.btnOpenCamera = new System.Windows.Forms.Button();
			this.cboRresolution = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.picCamera)).BeginInit();
			this.SuspendLayout();
			// 
			// cboCamera
			// 
			this.cboCamera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cboCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboCamera.FormattingEnabled = true;
			this.cboCamera.Location = new System.Drawing.Point(12, 12);
			this.cboCamera.Name = "cboCamera";
			this.cboCamera.Size = new System.Drawing.Size(674, 21);
			this.cboCamera.TabIndex = 0;
			this.cboCamera.DropDown += new System.EventHandler(this.cboCamera_DropDown);
			// 
			// picCamera
			// 
			this.picCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picCamera.Location = new System.Drawing.Point(12, 66);
			this.picCamera.Name = "picCamera";
			this.picCamera.Size = new System.Drawing.Size(755, 448);
			this.picCamera.TabIndex = 1;
			this.picCamera.TabStop = false;
			// 
			// btnOpenCamera
			// 
			this.btnOpenCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpenCamera.Location = new System.Drawing.Point(692, 10);
			this.btnOpenCamera.Name = "btnOpenCamera";
			this.btnOpenCamera.Size = new System.Drawing.Size(75, 23);
			this.btnOpenCamera.TabIndex = 2;
			this.btnOpenCamera.Text = "Open";
			this.btnOpenCamera.UseVisualStyleBackColor = true;
			this.btnOpenCamera.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// cboRresolution
			// 
			this.cboRresolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cboRresolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboRresolution.FormattingEnabled = true;
			this.cboRresolution.Location = new System.Drawing.Point(12, 39);
			this.cboRresolution.Name = "cboRresolution";
			this.cboRresolution.Size = new System.Drawing.Size(755, 21);
			this.cboRresolution.TabIndex = 0;
			this.cboRresolution.DropDown += new System.EventHandler(this.cboCamera_DropDown);
			this.cboRresolution.SelectedIndexChanged += new System.EventHandler(this.cboRresolution_SelectedIndexChanged);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(779, 526);
			this.Controls.Add(this.btnOpenCamera);
			this.Controls.Add(this.picCamera);
			this.Controls.Add(this.cboRresolution);
			this.Controls.Add(this.cboCamera);
			this.Name = "FormMain";
			this.Text = "Camera Tester";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.picCamera)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox cboCamera;
		private System.Windows.Forms.PictureBox picCamera;
		private System.Windows.Forms.Button btnOpenCamera;
		private System.Windows.Forms.ComboBox cboRresolution;
	}
}
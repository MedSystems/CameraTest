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
			this.picCamera = new System.Windows.Forms.PictureBox();
			this.btnOpenCamera = new System.Windows.Forms.Button();
			this.cboRresolution = new System.Windows.Forms.ComboBox();
			this.groupBoxCamera = new System.Windows.Forms.GroupBox();
			this.cboCamera = new System.Windows.Forms.ComboBox();
			this.radioButtonCamera = new System.Windows.Forms.RadioButton();
			this.groupBoxUrl = new System.Windows.Forms.GroupBox();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.textBoxUsername = new System.Windows.Forms.TextBox();
			this.textBoxPort = new System.Windows.Forms.TextBox();
			this.LabelResolution = new System.Windows.Forms.Label();
			this.labelPassword = new System.Windows.Forms.Label();
			this.labelUsername = new System.Windows.Forms.Label();
			this.labelPort = new System.Windows.Forms.Label();
			this.textBoxUrl = new System.Windows.Forms.TextBox();
			this.labelUrl = new System.Windows.Forms.Label();
			this.textBoxIp = new System.Windows.Forms.TextBox();
			this.labelIp = new System.Windows.Forms.Label();
			this.buttonOpenUrl = new System.Windows.Forms.Button();
			this.radioButtonUrl = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.picCamera)).BeginInit();
			this.groupBoxCamera.SuspendLayout();
			this.groupBoxUrl.SuspendLayout();
			this.SuspendLayout();
			// 
			// picCamera
			// 
			this.picCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.picCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picCamera.Location = new System.Drawing.Point(13, 196);
			this.picCamera.Margin = new System.Windows.Forms.Padding(4);
			this.picCamera.Name = "picCamera";
			this.picCamera.Size = new System.Drawing.Size(1014, 438);
			this.picCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picCamera.TabIndex = 1;
			this.picCamera.TabStop = false;
			// 
			// btnOpenCamera
			// 
			this.btnOpenCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpenCamera.Location = new System.Drawing.Point(878, 22);
			this.btnOpenCamera.Margin = new System.Windows.Forms.Padding(4);
			this.btnOpenCamera.Name = "btnOpenCamera";
			this.btnOpenCamera.Size = new System.Drawing.Size(100, 28);
			this.btnOpenCamera.TabIndex = 2;
			this.btnOpenCamera.Text = "Open";
			this.btnOpenCamera.UseVisualStyleBackColor = true;
			this.btnOpenCamera.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// cboRresolution
			// 
			this.cboRresolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.cboRresolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboRresolution.FormattingEnabled = true;
			this.cboRresolution.Location = new System.Drawing.Point(7, 58);
			this.cboRresolution.Margin = new System.Windows.Forms.Padding(4);
			this.cboRresolution.Name = "cboRresolution";
			this.cboRresolution.Size = new System.Drawing.Size(969, 24);
			this.cboRresolution.TabIndex = 0;
			this.cboRresolution.DropDown += new System.EventHandler(this.cboCamera_DropDown);
			this.cboRresolution.SelectedIndexChanged += new System.EventHandler(this.cboRresolution_SelectedIndexChanged);
			// 
			// groupBoxCamera
			// 
			this.groupBoxCamera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxCamera.Controls.Add(this.cboCamera);
			this.groupBoxCamera.Controls.Add(this.btnOpenCamera);
			this.groupBoxCamera.Controls.Add(this.cboRresolution);
			this.groupBoxCamera.Location = new System.Drawing.Point(42, 12);
			this.groupBoxCamera.Name = "groupBoxCamera";
			this.groupBoxCamera.Size = new System.Drawing.Size(985, 92);
			this.groupBoxCamera.TabIndex = 3;
			this.groupBoxCamera.TabStop = false;
			this.groupBoxCamera.Text = "Camera";
			// 
			// cboCamera
			// 
			this.cboCamera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.cboCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboCamera.FormattingEnabled = true;
			this.cboCamera.Location = new System.Drawing.Point(7, 25);
			this.cboCamera.Margin = new System.Windows.Forms.Padding(4);
			this.cboCamera.Name = "cboCamera";
			this.cboCamera.Size = new System.Drawing.Size(861, 24);
			this.cboCamera.TabIndex = 0;
			this.cboCamera.DropDown += new System.EventHandler(this.cboCamera_DropDown);
			// 
			// radioButtonCamera
			// 
			this.radioButtonCamera.Checked = true;
			this.radioButtonCamera.Location = new System.Drawing.Point(12, 12);
			this.radioButtonCamera.Name = "radioButtonCamera";
			this.radioButtonCamera.Size = new System.Drawing.Size(24, 24);
			this.radioButtonCamera.TabIndex = 4;
			this.radioButtonCamera.TabStop = true;
			this.radioButtonCamera.UseVisualStyleBackColor = true;
			this.radioButtonCamera.CheckedChanged += new System.EventHandler(this.radioButtonCameraURl_CheckedChanged);
			// 
			// groupBoxUrl
			// 
			this.groupBoxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxUrl.Controls.Add(this.textBoxPassword);
			this.groupBoxUrl.Controls.Add(this.textBoxUsername);
			this.groupBoxUrl.Controls.Add(this.textBoxPort);
			this.groupBoxUrl.Controls.Add(this.LabelResolution);
			this.groupBoxUrl.Controls.Add(this.labelPassword);
			this.groupBoxUrl.Controls.Add(this.labelUsername);
			this.groupBoxUrl.Controls.Add(this.labelPort);
			this.groupBoxUrl.Controls.Add(this.textBoxUrl);
			this.groupBoxUrl.Controls.Add(this.labelUrl);
			this.groupBoxUrl.Controls.Add(this.textBoxIp);
			this.groupBoxUrl.Controls.Add(this.labelIp);
			this.groupBoxUrl.Controls.Add(this.buttonOpenUrl);
			this.groupBoxUrl.Enabled = false;
			this.groupBoxUrl.Location = new System.Drawing.Point(42, 110);
			this.groupBoxUrl.Name = "groupBoxUrl";
			this.groupBoxUrl.Size = new System.Drawing.Size(985, 79);
			this.groupBoxUrl.TabIndex = 3;
			this.groupBoxUrl.TabStop = false;
			this.groupBoxUrl.Text = "Url";
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(536, 15);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(97, 22);
			this.textBoxPassword.TabIndex = 4;
			this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxGenerate_TextChanged);
			// 
			// textBoxUsername
			// 
			this.textBoxUsername.Location = new System.Drawing.Point(355, 15);
			this.textBoxUsername.Name = "textBoxUsername";
			this.textBoxUsername.Size = new System.Drawing.Size(96, 22);
			this.textBoxUsername.TabIndex = 4;
			this.textBoxUsername.Text = "Admin";
			this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxGenerate_TextChanged);
			// 
			// textBoxPort
			// 
			this.textBoxPort.Location = new System.Drawing.Point(205, 15);
			this.textBoxPort.Name = "textBoxPort";
			this.textBoxPort.Size = new System.Drawing.Size(65, 22);
			this.textBoxPort.TabIndex = 4;
			this.textBoxPort.Text = "80";
			this.textBoxPort.TextChanged += new System.EventHandler(this.textBoxGenerate_TextChanged);
			// 
			// LabelResolution
			// 
			this.LabelResolution.Location = new System.Drawing.Point(639, 18);
			this.LabelResolution.Name = "LabelResolution";
			this.LabelResolution.Size = new System.Drawing.Size(128, 17);
			this.LabelResolution.TabIndex = 3;
			// 
			// labelPassword
			// 
			this.labelPassword.AutoSize = true;
			this.labelPassword.Location = new System.Drawing.Point(457, 18);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(69, 17);
			this.labelPassword.TabIndex = 3;
			this.labelPassword.Text = "Password";
			// 
			// labelUsername
			// 
			this.labelUsername.AutoSize = true;
			this.labelUsername.Location = new System.Drawing.Point(276, 18);
			this.labelUsername.Name = "labelUsername";
			this.labelUsername.Size = new System.Drawing.Size(73, 17);
			this.labelUsername.TabIndex = 3;
			this.labelUsername.Text = "Username";
			// 
			// labelPort
			// 
			this.labelPort.AutoSize = true;
			this.labelPort.Location = new System.Drawing.Point(165, 18);
			this.labelPort.Name = "labelPort";
			this.labelPort.Size = new System.Drawing.Size(34, 17);
			this.labelPort.TabIndex = 3;
			this.labelPort.Text = "Port";
			// 
			// textBoxUrl
			// 
			this.textBoxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxUrl.Location = new System.Drawing.Point(31, 47);
			this.textBoxUrl.Name = "textBoxUrl";
			this.textBoxUrl.Size = new System.Drawing.Size(947, 22);
			this.textBoxUrl.TabIndex = 4;
			// 
			// labelUrl
			// 
			this.labelUrl.AutoSize = true;
			this.labelUrl.Location = new System.Drawing.Point(6, 50);
			this.labelUrl.Name = "labelUrl";
			this.labelUrl.Size = new System.Drawing.Size(26, 17);
			this.labelUrl.TabIndex = 3;
			this.labelUrl.Text = "Url";
			// 
			// textBoxIp
			// 
			this.textBoxIp.Location = new System.Drawing.Point(31, 15);
			this.textBoxIp.Name = "textBoxIp";
			this.textBoxIp.Size = new System.Drawing.Size(128, 22);
			this.textBoxIp.TabIndex = 4;
			this.textBoxIp.Text = "192.168.1.168";
			this.textBoxIp.TextChanged += new System.EventHandler(this.textBoxGenerate_TextChanged);
			// 
			// labelIp
			// 
			this.labelIp.AutoSize = true;
			this.labelIp.Location = new System.Drawing.Point(6, 18);
			this.labelIp.Name = "labelIp";
			this.labelIp.Size = new System.Drawing.Size(19, 17);
			this.labelIp.TabIndex = 3;
			this.labelIp.Text = "Ip";
			// 
			// buttonOpenUrl
			// 
			this.buttonOpenUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOpenUrl.Location = new System.Drawing.Point(878, 12);
			this.buttonOpenUrl.Margin = new System.Windows.Forms.Padding(4);
			this.buttonOpenUrl.Name = "buttonOpenUrl";
			this.buttonOpenUrl.Size = new System.Drawing.Size(100, 28);
			this.buttonOpenUrl.TabIndex = 2;
			this.buttonOpenUrl.Text = "Open";
			this.buttonOpenUrl.UseVisualStyleBackColor = true;
			this.buttonOpenUrl.Click += new System.EventHandler(this.btnOpenUrl_Click);
			// 
			// radioButtonUrl
			// 
			this.radioButtonUrl.Location = new System.Drawing.Point(12, 110);
			this.radioButtonUrl.Name = "radioButtonUrl";
			this.radioButtonUrl.Size = new System.Drawing.Size(24, 24);
			this.radioButtonUrl.TabIndex = 4;
			this.radioButtonUrl.UseVisualStyleBackColor = true;
			this.radioButtonUrl.CheckedChanged += new System.EventHandler(this.radioButtonCameraURl_CheckedChanged);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1039, 647);
			this.Controls.Add(this.radioButtonUrl);
			this.Controls.Add(this.groupBoxUrl);
			this.Controls.Add(this.radioButtonCamera);
			this.Controls.Add(this.picCamera);
			this.Controls.Add(this.groupBoxCamera);
			this.Location = new System.Drawing.Point(15, 15);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormMain";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.picCamera)).EndInit();
			this.groupBoxCamera.ResumeLayout(false);
			this.groupBoxUrl.ResumeLayout(false);
			this.groupBoxUrl.PerformLayout();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Label LabelResolution;

		private System.Windows.Forms.Label labelUrl;
		private System.Windows.Forms.TextBox textBoxUrl;

		private System.Windows.Forms.Label labelUsername;
		private System.Windows.Forms.TextBox textBoxUsername;
		private System.Windows.Forms.Label labelPassword;
		private System.Windows.Forms.TextBox textBoxPassword;

		private System.Windows.Forms.Label labelIp;
		private System.Windows.Forms.TextBox textBoxIp;
		private System.Windows.Forms.Label labelPort;
		private System.Windows.Forms.TextBox textBoxPort;

		private System.Windows.Forms.GroupBox groupBoxCamera;
		private System.Windows.Forms.RadioButton radioButtonCamera;
		private System.Windows.Forms.GroupBox groupBoxUrl;
		private System.Windows.Forms.Button buttonOpenUrl;
		private System.Windows.Forms.RadioButton radioButtonUrl;

		#endregion

		private System.Windows.Forms.ComboBox cboCamera;
		private System.Windows.Forms.PictureBox picCamera;
		private System.Windows.Forms.Button btnOpenCamera;
		private System.Windows.Forms.ComboBox cboRresolution;
	}
}
namespace CustomGamesBrowser {
	partial class UpdateInfoForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.dontUpdateBtn = new MetroFramework.Controls.MetroButton();
			this.updateBtn = new MetroFramework.Controls.MetroButton();
			this.progressLabel = new MetroFramework.Controls.MetroLabel();
			this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
			this.changelogTextBox = new MetroFramework.Controls.MetroTextBox();
			this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
			this.SuspendLayout();
			// 
			// dontUpdateBtn
			// 
			this.dontUpdateBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.dontUpdateBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.dontUpdateBtn.Location = new System.Drawing.Point(217, 345);
			this.dontUpdateBtn.Margin = new System.Windows.Forms.Padding(4);
			this.dontUpdateBtn.Name = "dontUpdateBtn";
			this.dontUpdateBtn.Size = new System.Drawing.Size(67, 40);
			this.dontUpdateBtn.TabIndex = 30;
			this.dontUpdateBtn.TabStop = false;
			this.dontUpdateBtn.Text = "Cancel";
			this.dontUpdateBtn.UseSelectable = true;
			// 
			// updateBtn
			// 
			this.updateBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.updateBtn.Location = new System.Drawing.Point(117, 345);
			this.updateBtn.Margin = new System.Windows.Forms.Padding(4);
			this.updateBtn.Name = "updateBtn";
			this.updateBtn.Size = new System.Drawing.Size(95, 40);
			this.updateBtn.Style = MetroFramework.MetroColorStyle.Green;
			this.updateBtn.TabIndex = 29;
			this.updateBtn.TabStop = false;
			this.updateBtn.Text = "Update!";
			this.updateBtn.UseSelectable = true;
			this.updateBtn.UseStyleColors = true;
			// 
			// progressLabel
			// 
			this.progressLabel.AutoSize = true;
			this.progressLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.progressLabel.Location = new System.Drawing.Point(125, 281);
			this.progressLabel.Name = "progressLabel";
			this.progressLabel.Size = new System.Drawing.Size(151, 19);
			this.progressLabel.TabIndex = 28;
			this.progressLabel.Text = "Downloading v2.0.0.0...";
			this.progressLabel.Visible = false;
			// 
			// metroProgressBar1
			// 
			this.metroProgressBar1.Location = new System.Drawing.Point(23, 305);
			this.metroProgressBar1.Name = "metroProgressBar1";
			this.metroProgressBar1.Size = new System.Drawing.Size(350, 31);
			this.metroProgressBar1.TabIndex = 27;
			this.metroProgressBar1.Visible = false;
			// 
			// changelogTextBox
			// 
			// 
			// 
			// 
			this.changelogTextBox.CustomButton.Image = null;
			this.changelogTextBox.CustomButton.Location = new System.Drawing.Point(140, 1);
			this.changelogTextBox.CustomButton.Name = "";
			this.changelogTextBox.CustomButton.Size = new System.Drawing.Size(209, 209);
			this.changelogTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.changelogTextBox.CustomButton.TabIndex = 1;
			this.changelogTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.changelogTextBox.CustomButton.UseSelectable = true;
			this.changelogTextBox.CustomButton.Visible = false;
			this.changelogTextBox.Lines = new string[0];
			this.changelogTextBox.Location = new System.Drawing.Point(23, 63);
			this.changelogTextBox.MaxLength = 32767;
			this.changelogTextBox.Multiline = true;
			this.changelogTextBox.Name = "changelogTextBox";
			this.changelogTextBox.PasswordChar = '\0';
			this.changelogTextBox.ReadOnly = true;
			this.changelogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.changelogTextBox.SelectedText = "";
			this.changelogTextBox.SelectionLength = 0;
			this.changelogTextBox.SelectionStart = 0;
			this.changelogTextBox.Size = new System.Drawing.Size(350, 211);
			this.changelogTextBox.TabIndex = 26;
			this.changelogTextBox.TabStop = false;
			this.changelogTextBox.UseSelectable = true;
			this.changelogTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.changelogTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroRadioButton1
			// 
			this.metroRadioButton1.AutoSize = true;
			this.metroRadioButton1.Location = new System.Drawing.Point(228, 0);
			this.metroRadioButton1.Name = "metroRadioButton1";
			this.metroRadioButton1.Size = new System.Drawing.Size(127, 15);
			this.metroRadioButton1.TabIndex = 31;
			this.metroRadioButton1.Text = "metroRadioButton1";
			this.metroRadioButton1.UseSelectable = true;
			this.metroRadioButton1.Visible = false;
			// 
			// UpdateInfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(398, 400);
			this.Controls.Add(this.metroRadioButton1);
			this.Controls.Add(this.dontUpdateBtn);
			this.Controls.Add(this.updateBtn);
			this.Controls.Add(this.progressLabel);
			this.Controls.Add(this.metroProgressBar1);
			this.Controls.Add(this.changelogTextBox);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UpdateInfoForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Update Available!";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroButton dontUpdateBtn;
		private MetroFramework.Controls.MetroButton updateBtn;
		private MetroFramework.Controls.MetroLabel progressLabel;
		private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
		private MetroFramework.Controls.MetroTextBox changelogTextBox;
		private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
	}
}
﻿namespace ControllerManager
{
	partial class FormProfile
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
			this.btnProfilExist = new System.Windows.Forms.Button();
			this.btnCreateProfil = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnProfilExist
			// 
			this.btnProfilExist.Location = new System.Drawing.Point(12, 12);
			this.btnProfilExist.Name = "btnProfilExist";
			this.btnProfilExist.Size = new System.Drawing.Size(81, 35);
			this.btnProfilExist.TabIndex = 0;
			this.btnProfilExist.Text = "&Créer des tâches";
			this.btnProfilExist.UseVisualStyleBackColor = true;
			this.btnProfilExist.Click += new System.EventHandler(this.btnProfilExistant_Click);
			// 
			// btnCreateProfil
			// 
			this.btnCreateProfil.Location = new System.Drawing.Point(142, 12);
			this.btnCreateProfil.Name = "btnCreateProfil";
			this.btnCreateProfil.Size = new System.Drawing.Size(81, 35);
			this.btnCreateProfil.TabIndex = 1;
			this.btnCreateProfil.Text = "&Créer un profil";
			this.btnCreateProfil.UseVisualStyleBackColor = true;
			this.btnCreateProfil.Click += new System.EventHandler(this.btnCreerProfil_Click);
			// 
			// FormProfile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(235, 60);
			this.Controls.Add(this.btnCreateProfil);
			this.Controls.Add(this.btnProfilExist);
			this.Location = new System.Drawing.Point(100, 100);
			this.Name = "FormProfile";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Controller Task Manager";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnProfilExist;
		private System.Windows.Forms.Button btnCreateProfil;
	}
}
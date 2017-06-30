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
			this.btnManageTasks = new System.Windows.Forms.Button();
			this.btnCreateProfil = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnExecute = new System.Windows.Forms.Button();
			this.lbxTaskType = new System.Windows.Forms.ListBox();
			this.lbxTaskName = new System.Windows.Forms.ListBox();
			this.lbxTaskDesc = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// btnManageTasks
			// 
			this.btnManageTasks.Enabled = false;
			this.btnManageTasks.Location = new System.Drawing.Point(12, 12);
			this.btnManageTasks.Name = "btnManageTasks";
			this.btnManageTasks.Size = new System.Drawing.Size(81, 35);
			this.btnManageTasks.TabIndex = 0;
			this.btnManageTasks.Text = "Management des tâches";
			this.btnManageTasks.UseVisualStyleBackColor = true;
			this.btnManageTasks.Visible = false;
			// 
			// btnCreateProfil
			// 
			this.btnCreateProfil.Enabled = false;
			this.btnCreateProfil.Location = new System.Drawing.Point(142, 12);
			this.btnCreateProfil.Name = "btnCreateProfil";
			this.btnCreateProfil.Size = new System.Drawing.Size(81, 35);
			this.btnCreateProfil.TabIndex = 1;
			this.btnCreateProfil.Text = "Créer un profil";
			this.btnCreateProfil.UseVisualStyleBackColor = true;
			this.btnCreateProfil.Visible = false;
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(663, 53);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(81, 35);
			this.btnCreate.TabIndex = 2;
			this.btnCreate.Text = "&Créer";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(663, 94);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(81, 35);
			this.btnEdit.TabIndex = 3;
			this.btnEdit.Text = "&Modifier";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(663, 135);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(81, 35);
			this.btnRemove.TabIndex = 4;
			this.btnRemove.Text = "&Supprimer";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnExecute
			// 
			this.btnExecute.Location = new System.Drawing.Point(663, 12);
			this.btnExecute.Name = "btnExecute";
			this.btnExecute.Size = new System.Drawing.Size(81, 35);
			this.btnExecute.TabIndex = 5;
			this.btnExecute.Text = "&Exécuter";
			this.btnExecute.UseVisualStyleBackColor = true;
			this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
			// 
			// lbxTaskType
			// 
			this.lbxTaskType.FormattingEnabled = true;
			this.lbxTaskType.Location = new System.Drawing.Point(12, 12);
			this.lbxTaskType.Name = "lbxTaskType";
			this.lbxTaskType.Size = new System.Drawing.Size(211, 160);
			this.lbxTaskType.TabIndex = 6;
			this.lbxTaskType.SelectedIndexChanged += new System.EventHandler(this.lbxTasks_SelectedIndexChanged);
			// 
			// lbxTaskName
			// 
			this.lbxTaskName.FormattingEnabled = true;
			this.lbxTaskName.Location = new System.Drawing.Point(229, 12);
			this.lbxTaskName.Name = "lbxTaskName";
			this.lbxTaskName.Size = new System.Drawing.Size(211, 160);
			this.lbxTaskName.TabIndex = 7;
			// 
			// lbxTaskDesc
			// 
			this.lbxTaskDesc.FormattingEnabled = true;
			this.lbxTaskDesc.Location = new System.Drawing.Point(446, 12);
			this.lbxTaskDesc.Name = "lbxTaskDesc";
			this.lbxTaskDesc.Size = new System.Drawing.Size(211, 160);
			this.lbxTaskDesc.TabIndex = 8;
			// 
			// FormProfile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(756, 182);
			this.Controls.Add(this.lbxTaskDesc);
			this.Controls.Add(this.lbxTaskName);
			this.Controls.Add(this.lbxTaskType);
			this.Controls.Add(this.btnExecute);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.btnCreateProfil);
			this.Controls.Add(this.btnManageTasks);
			this.Location = new System.Drawing.Point(100, 100);
			this.Name = "FormProfile";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Controller Task Manager";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnManageTasks;
		private System.Windows.Forms.Button btnCreateProfil;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnExecute;
		public System.Windows.Forms.ListBox lbxTaskType;
		public System.Windows.Forms.ListBox lbxTaskName;
		public System.Windows.Forms.ListBox lbxTaskDesc;
	}
}
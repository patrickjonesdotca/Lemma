﻿namespace Lemma
{
	partial class AnalyticsForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.label3 = new System.Windows.Forms.Label();
			this.anonymousIdTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 28);
			this.label1.MaximumSize = new System.Drawing.Size(260, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(254, 39);
			this.label1.TabIndex = 0;
			this.label1.Text = "We saved an anonymous recording of your play session. Help improve Lemma by hitti" +
    "ng \"Upload\" to send the following data:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 190);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Upload!";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(146, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Thanks for playing!";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(197, 190);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 8;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Visible = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 77);
			this.label4.MaximumSize = new System.Drawing.Size(260, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "- Basic system info";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 99);
			this.label5.MaximumSize = new System.Drawing.Size(270, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(147, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "- Timeline of your play session";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 123);
			this.label7.MaximumSize = new System.Drawing.Size(260, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(62, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "- Crash logs";
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.WorkerReportsProgress = true;
			this.backgroundWorker1.WorkerSupportsCancellation = true;
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
			this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 147);
			this.label3.MaximumSize = new System.Drawing.Size(260, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "- Your anonymous ID:";
			// 
			// anonymousIdTextBox
			// 
			this.anonymousIdTextBox.Location = new System.Drawing.Point(15, 164);
			this.anonymousIdTextBox.Name = "anonymousIdTextBox";
			this.anonymousIdTextBox.ReadOnly = true;
			this.anonymousIdTextBox.Size = new System.Drawing.Size(251, 20);
			this.anonymousIdTextBox.TabIndex = 15;
			// 
			// AnalyticsForm
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 221);
			this.Controls.Add(this.anonymousIdTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AnalyticsForm";
			this.Text = "Lemma";
			this.Load += new System.EventHandler(this.AnalyticsForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox anonymousIdTextBox;
	}
}
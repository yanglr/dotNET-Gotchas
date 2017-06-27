using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;
using ALibrary;

namespace UnhandledExceptionGUI
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button RunButton;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.RunButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// RunButton
			// 
			this.RunButton.Location = new System.Drawing.Point(80, 16);
			this.RunButton.Name = "RunButton";
			this.RunButton.TabIndex = 0;
			this.RunButton.Text = "Run";
			this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(264, 61);
			this.Controls.Add(this.RunButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
//			Application.ThreadException 
//				+= new ThreadExceptionEventHandler(
//					Application_ThreadException);
			Application.Run(new Form1());
		}

		private void RunButton_Click(
			object sender, System.EventArgs e)
		{
			MessageBox.Show(
				new Utility().Operate(1, 0).ToString());
		}

		private static void Application_ThreadException(
			object sender, 
			System.Threading.ThreadExceptionEventArgs e)
		{
			MessageBox.Show(
				"Send the following to support: " +
				e.Exception);
		}
	}
}

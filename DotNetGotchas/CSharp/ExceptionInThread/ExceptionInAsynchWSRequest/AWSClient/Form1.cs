//Form1.cs part of AWSClient
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;
using AWSClient.ACSWebService;

namespace AWSClient
{
	public class Form1 : System.Windows.Forms.Form
	{
		private static MyService service;

		// Parts of this file not shown...

		private System.Windows.Forms.Button InvokeButton;
		private System.Windows.Forms.CheckBox AsynchCheckBox;
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			InitializeComponent();
		}

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
			this.AsynchCheckBox = new System.Windows.Forms.CheckBox();
			this.InvokeButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// AsynchCheckBox
			// 
			this.AsynchCheckBox.Location = new System.Drawing.Point(24, 24);
			this.AsynchCheckBox.Name = "AsynchCheckBox";
			this.AsynchCheckBox.Size = new System.Drawing.Size(128, 24);
			this.AsynchCheckBox.TabIndex = 0;
			this.AsynchCheckBox.Text = "Call Asynchronously";
			// 
			// InvokeButton
			// 
			this.InvokeButton.Location = new System.Drawing.Point(176, 24);
			this.InvokeButton.Name = "InvokeButton";
			this.InvokeButton.TabIndex = 2;
			this.InvokeButton.Text = "Invoke";
			this.InvokeButton.Click += new System.EventHandler(this.InvokeButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(264, 77);
			this.Controls.Add(this.InvokeButton);
			this.Controls.Add(this.AsynchCheckBox);
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
			Application.Run(new Form1());
		}

		private void InvokeButton_Click(
			object sender, System.EventArgs e)
		{
			service = new MyService();
			service.Credentials = 
				System.Net.CredentialCache.DefaultCredentials;

			if (AsynchCheckBox.Checked)
			{
				CallAsynch();
			}
			else
			{
				CallSynch();
			}
		}

		private static void CallSynch()
		{
			int result = service.Method1(1);
			MessageBox.Show("Result received: " + result);

			result = service.Method1(0);
			MessageBox.Show("Result received: " + result);
		}

		private static void CallAsynch()
		{
			service.BeginMethod1(1, 
				new AsyncCallback(response), service);

			Thread.Sleep(1000);

			service.BeginMethod1(0, 
				new AsyncCallback(response), service);

			Thread.Sleep(1000);
		}

		private static void response(IAsyncResult handle)
		{
			MyService theService 
				= handle.AsyncState as MyService;

			try
			{
				int result = theService.EndMethod1(handle);
				MessageBox.Show("Result received asynchronously " +
					result);
			}
			catch(System.Web.Services.Protocols.SoapException ex)
			{
				MessageBox.Show("Now I got " + ex);
			}
		}
	}
}

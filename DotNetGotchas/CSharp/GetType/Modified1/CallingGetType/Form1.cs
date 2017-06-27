using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CallingGetType
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button CallGetTypeButton;
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
			this.CallGetTypeButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// CallGetTypeButton
			// 
			this.CallGetTypeButton.Location = new System.Drawing.Point(72, 16);
			this.CallGetTypeButton.Name = "CallGetTypeButton";
			this.CallGetTypeButton.Size = new System.Drawing.Size(80, 23);
			this.CallGetTypeButton.TabIndex = 0;
			this.CallGetTypeButton.Text = "Call GetType";
			this.CallGetTypeButton.Click += new System.EventHandler(this.CallGetTypeButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(280, 53);
			this.Controls.Add(this.CallGetTypeButton);
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

		private void CallGetTypeButton_Click(object sender, 
			System.EventArgs e)
		{
			try
			{
				Type theType;
				
				theType = Type.GetType(
					"CallingGetType.Form1", true);
				MessageBox.Show("First type is " 
					+ theType.FullName);

				theType = Type.GetType(
					"System.Collections.Queue", true);
				MessageBox.Show("Second type is " 
					+ theType.FullName);

				theType = Type.GetType(
					"System.Windows.Forms.Form, " +
					"System.Windows.Forms, " +
					"Version=1.0.5000.0, " +
					"Culture=neutral, " +
					"PublicKeyToken=b77a5c561934e089", 
					true);
				MessageBox.Show("Third type is " 
					+ theType.FullName);
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}
	}
}

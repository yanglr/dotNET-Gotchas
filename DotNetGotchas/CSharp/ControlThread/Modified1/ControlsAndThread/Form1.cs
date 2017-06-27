using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ControlsAndThread
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		#region Code Not to be shown
		private System.Windows.Forms.Button TimerButton;
		private System.Windows.Forms.Label MainThreadLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label ExecutingThreadLabel;
		private System.Windows.Forms.Button TimersTimerButton;
		private System.Windows.Forms.Button DelegateButton;
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
			this.TimerButton = new System.Windows.Forms.Button();
			this.MainThreadLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ExecutingThreadLabel = new System.Windows.Forms.Label();
			this.TimersTimerButton = new System.Windows.Forms.Button();
			this.DelegateButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TimerButton
			// 
			this.TimerButton.Location = new System.Drawing.Point(16, 96);
			this.TimerButton.Name = "TimerButton";
			this.TimerButton.TabIndex = 0;
			this.TimerButton.Text = "Timer";
			this.TimerButton.Click += new System.EventHandler(this.TimerButton_Click);
			// 
			// MainThreadLabel
			// 
			this.MainThreadLabel.Location = new System.Drawing.Point(112, 16);
			this.MainThreadLabel.Name = "MainThreadLabel";
			this.MainThreadLabel.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Main Thread";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Executing Thread";
			// 
			// ExecutingThreadLabel
			// 
			this.ExecutingThreadLabel.Location = new System.Drawing.Point(112, 56);
			this.ExecutingThreadLabel.Name = "ExecutingThreadLabel";
			this.ExecutingThreadLabel.Size = new System.Drawing.Size(160, 23);
			this.ExecutingThreadLabel.TabIndex = 3;
			// 
			// TimersTimerButton
			// 
			this.TimersTimerButton.Location = new System.Drawing.Point(104, 96);
			this.TimersTimerButton.Name = "TimersTimerButton";
			this.TimersTimerButton.Size = new System.Drawing.Size(80, 23);
			this.TimersTimerButton.TabIndex = 5;
			this.TimersTimerButton.Text = "Timers Timer";
			this.TimersTimerButton.Click += new System.EventHandler(this.TimersTimerButton_Click);
			// 
			// DelegateButton
			// 
			this.DelegateButton.Location = new System.Drawing.Point(200, 96);
			this.DelegateButton.Name = "DelegateButton";
			this.DelegateButton.Size = new System.Drawing.Size(80, 23);
			this.DelegateButton.TabIndex = 6;
			this.DelegateButton.Text = "Delegate";
			this.DelegateButton.Click += new System.EventHandler(this.DelegateButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 133);
			this.Controls.Add(this.DelegateButton);
			this.Controls.Add(this.TimersTimerButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ExecutingThreadLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.MainThreadLabel);
			this.Controls.Add(this.TimerButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
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

		#endregion

		private void Form1_Load(object sender, System.EventArgs e)
		{
			MainThreadLabel.Text 
				= AppDomain.GetCurrentThreadId().ToString();
		}

		private delegate void SetLabelDelegate(string message);

		private void SetExecutingThreadLabel(string message)
		{
			if(ExecutingThreadLabel.InvokeRequired)
			{
				//MessageBox.Show("Jumping thread to display " + message);
				Invoke(new SetLabelDelegate(SetExecutingThreadLabel),
					new object[] {message});
			}
			else
			{
				ExecutingThreadLabel.Text = message;
			}
		}

		private void TimerButton_Click(
			object sender, System.EventArgs e)
		{
			Timer theTimer = new Timer();
			theTimer.Interval = 1000;
			theTimer.Tick += new EventHandler(Timer_Tick);
			theTimer.Start();
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			(sender as Timer).Stop();
			SetExecutingThreadLabel(
					"Timer : " 
					+ AppDomain.GetCurrentThreadId() + ": " 
					+ InvokeRequired);
		}

		private void TimersTimerButton_Click(
			object sender, System.EventArgs e)
		{
			System.Timers.Timer theTimer 
				= new System.Timers.Timer(1000);
			theTimer.Elapsed 
				+= new System.Timers.ElapsedEventHandler(
					Timer_Elapsed);
			theTimer.Start();
		}

		private void Timer_Elapsed(
			object sender, System.Timers.ElapsedEventArgs e)
		{
			(sender as System.Timers.Timer).Stop();
			SetExecutingThreadLabel(
				"Timers.Timer : " 
				+ AppDomain.GetCurrentThreadId() + ": " 
				+ InvokeRequired);
		}

		private delegate void AsynchDelegate();

		private void DelegateButton_Click(
			object sender, System.EventArgs e)
		{
			AsynchDelegate dlg 
				= new AsynchDelegate(AsynchExecuted);
			dlg.BeginInvoke(null, null);
		}

		private void AsynchExecuted()
		{
			SetExecutingThreadLabel(
				"Delegate : " 
				+ AppDomain.GetCurrentThreadId() + ": " 
				+ InvokeRequired);
		}
	}
}

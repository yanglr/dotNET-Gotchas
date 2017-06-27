//MyService.asmx.cs part of ACSWebService.dll (Web Service)
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;

namespace ACSWebService
{
	[WebService(Namespace="MyServiceNameSpace")]
	public class MyService : System.Web.Services.WebService
	{
		public MyService()
		{
			InitializeComponent();
		}

		#region Component Designer generated code
		
		//Required by the Web Services Designer 
		private IContainer components = null;
				
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if(disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);		
		}
		
		#endregion

		[WebMethod]
		public int Method1(int val)
		{
			if (val == 0)
				throw new ApplicationException(
					"Do not like the input");

			return val;
		}
	}
}

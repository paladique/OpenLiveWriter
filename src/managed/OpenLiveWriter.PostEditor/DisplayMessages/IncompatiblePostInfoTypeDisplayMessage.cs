// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for details.

using System.ComponentModel;
using OpenLiveWriter.Controls;

namespace OpenLiveWriter.PostEditor.DisplayMessages
{
	/// <summary>
	/// Summary description for DeleteSingleItemDisplayMessage.
	/// </summary>
	public class IncompatiblePostInfoTypeDisplayMessage : DisplayMessage
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public IncompatiblePostInfoTypeDisplayMessage(IContainer container)
		{
			///
			/// Required for Windows.Forms Class Composition Designer support
			///
			container.Add(this);
			InitializeComponent();

			//
			// 
			//
		}

		public IncompatiblePostInfoTypeDisplayMessage()
		{
			///
			/// Required for Windows.Forms Class Composition Designer support
			///
			InitializeComponent();

			//
			// 
			//
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}


		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			// 
			// IncompatiblePostInfoTypeDisplayMessage
			// 
			this.Text = "An internal error occurred (incompatible blog post info type). Unable to " +
				"open the selected post.";
			this.Title = "Internal Error";

		}
		#endregion
	}
}

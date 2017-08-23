namespace tpi.addins.excel {
	partial class RibbonAddin : Microsoft.Office.Tools.Ribbon.RibbonBase {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		public RibbonAddin()
			: base(Globals.Factory.GetRibbonFactory()) {
			InitializeComponent();
		}

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

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonAddin));
			this.tabTelcomtrixAddin = this.Factory.CreateRibbonTab();
			this.groupActions = this.Factory.CreateRibbonGroup();
			this.buttonPasteValue = this.Factory.CreateRibbonButton();
			this.buttonAutoFillIncrement = this.Factory.CreateRibbonButton();
			this.group1 = this.Factory.CreateRibbonGroup();
			this.toggleButtonViewLogs = this.Factory.CreateRibbonToggleButton();
			this.tabTelcomtrixAddin.SuspendLayout();
			this.groupActions.SuspendLayout();
			this.group1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabTelcomtrixAddin
			// 
			this.tabTelcomtrixAddin.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
			this.tabTelcomtrixAddin.Groups.Add(this.groupActions);
			this.tabTelcomtrixAddin.Groups.Add(this.group1);
			this.tabTelcomtrixAddin.Label = "Telcomtrix";
			this.tabTelcomtrixAddin.Name = "tabTelcomtrixAddin";
			// 
			// groupActions
			// 
			this.groupActions.Items.Add(this.buttonPasteValue);
			this.groupActions.Items.Add(this.buttonAutoFillIncrement);
			this.groupActions.Label = "Actions";
			this.groupActions.Name = "groupActions";
			// 
			// buttonPasteValue
			// 
			this.buttonPasteValue.Image = ((System.Drawing.Image)(resources.GetObject("buttonPasteValue.Image")));
			this.buttonPasteValue.Label = "Paste Value Only";
			this.buttonPasteValue.Name = "buttonPasteValue";
			this.buttonPasteValue.ShowImage = true;
			this.buttonPasteValue.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonPasteValue_Click);
			// 
			// buttonAutoFillIncrement
			// 
			this.buttonAutoFillIncrement.Image = ((System.Drawing.Image)(resources.GetObject("buttonAutoFillIncrement.Image")));
			this.buttonAutoFillIncrement.Label = "AutoFill Increment Number";
			this.buttonAutoFillIncrement.Name = "buttonAutoFillIncrement";
			this.buttonAutoFillIncrement.ShowImage = true;
			this.buttonAutoFillIncrement.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonAutoFillIncrement_Click);
			// 
			// group1
			// 
			this.group1.Items.Add(this.toggleButtonViewLogs);
			this.group1.Label = "group1";
			this.group1.Name = "group1";
			// 
			// toggleButtonViewLogs
			// 
			this.toggleButtonViewLogs.Label = "View Logs";
			this.toggleButtonViewLogs.Name = "toggleButtonViewLogs";
			this.toggleButtonViewLogs.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.toggleButtonViewLogs_Click);
			// 
			// RibbonAddin
			// 
			this.Name = "RibbonAddin";
			this.RibbonType = "Microsoft.Excel.Workbook";
			this.Tabs.Add(this.tabTelcomtrixAddin);
			this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.RibbonAddin_Load);
			this.tabTelcomtrixAddin.ResumeLayout(false);
			this.tabTelcomtrixAddin.PerformLayout();
			this.groupActions.ResumeLayout(false);
			this.groupActions.PerformLayout();
			this.group1.ResumeLayout(false);
			this.group1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		internal Microsoft.Office.Tools.Ribbon.RibbonTab tabTelcomtrixAddin;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupActions;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonPasteValue;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonAutoFillIncrement;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
		internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton toggleButtonViewLogs;
	}

	partial class ThisRibbonCollection {
		internal RibbonAddin RibbonAddin {
			get { return this.GetRibbon<RibbonAddin>(); }
		}
	}
}

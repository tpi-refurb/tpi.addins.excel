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
			this.tab1 = this.Factory.CreateRibbonTab();
			this.groupActions = this.Factory.CreateRibbonGroup();
			this.buttonPasteValue = this.Factory.CreateRibbonButton();
			this.buttonAutoFillIncrement = this.Factory.CreateRibbonButton();
			this.tab1.SuspendLayout();
			this.groupActions.SuspendLayout();
			this.SuspendLayout();
			// 
			// tab1
			// 
			this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
			this.tab1.Groups.Add(this.groupActions);
			this.tab1.Label = "TabAddIns";
			this.tab1.Name = "tab1";
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
			// 
			// buttonAutoFillIncrement
			// 
			this.buttonAutoFillIncrement.Image = ((System.Drawing.Image)(resources.GetObject("buttonAutoFillIncrement.Image")));
			this.buttonAutoFillIncrement.Label = "AutoFill Increment Number";
			this.buttonAutoFillIncrement.Name = "buttonAutoFillIncrement";
			this.buttonAutoFillIncrement.ShowImage = true;
			// 
			// RibbonAddin
			// 
			this.Name = "RibbonAddin";
			this.RibbonType = "Microsoft.Excel.Workbook";
			this.Tabs.Add(this.tab1);
			this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.RibbonAddin_Load);
			this.tab1.ResumeLayout(false);
			this.tab1.PerformLayout();
			this.groupActions.ResumeLayout(false);
			this.groupActions.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupActions;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonPasteValue;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonAutoFillIncrement;
	}

	partial class ThisRibbonCollection {
		internal RibbonAddin RibbonAddin {
			get { return this.GetRibbon<RibbonAddin>(); }
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using Microsoft.Office.Tools;

namespace tpi.addins.excel
{
    public partial class ThisAddIn
    {
		private LogPane _logPanel;
		private CustomTaskPane _taskPane;
		private CustomTaskPane TaskPane{
			get {
				return this._taskPane;
			}
		}

		public void TogglePanelVisibility(bool state) {
			_taskPane.Visible = state;
		}
		public void AddLog(string message) {
			if (_logPanel != null) {
				_logPanel.AddLog(message);
			}
		}
		private void InitializeAddin() {
			_logPanel = new LogPane();
			_taskPane = this.CustomTaskPanes.Add(_logPanel, "Logs");
			_taskPane.Visible = true;
		}
		private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
			InitializeAddin();
		}

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpi.addins.excel {
	public partial class LogPane : UserControl {
		public LogPane() {
			InitializeComponent();
		}

		public void AddLog(string message) {
			//Invoke(new MethodInvoker(delegate {
				listBoxLog.Items.Add(message);
				listBoxLog.SelectedIndex = listBoxLog.Items.Count - 1;
			//}));
		}

		private void buttonAdd_Click(object sender, EventArgs e) {
			AddLog(Guid.NewGuid().ToSafeString());
		}

		private void buttonClearLog_Click(object sender, EventArgs e) {
			listBoxLog.Items.Clear();
		}
	}
}

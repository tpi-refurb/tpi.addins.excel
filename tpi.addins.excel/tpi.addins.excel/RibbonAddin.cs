using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace tpi.addins.excel {
	public partial class RibbonAddin {
		Excel.Application excelApp;
		Excel.Worksheet excelWorksheet;
		private void InitializeExcel() {
			excelApp = Globals.ThisAddIn.Application;
			if (excelApp != null) {
				excelWorksheet = excelApp.ActiveSheet;
			}
		}


		private void AutoIncrement(int cellValue, int rowIndex, int columnIndex) {
			int lastRow = excelWorksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing).Row;
			for (var row = rowIndex; row <= lastRow; row++) {
				var cell = (Excel.Range)excelApp.Cells[row, columnIndex];
				cell.Value2 = cellValue++;
			}
		}
		private void RibbonAddin_Load(object sender, RibbonUIEventArgs e) {

			InitializeExcel();
		}

		private void buttonPasteValue_Click(object sender, RibbonControlEventArgs e) {
			try {
				string copiedText = Clipboard.GetText();
				Excel.Range range = excelApp.ActiveCell;
				range.Value = copiedText.Trim();
				Globals.ThisAddIn.AddLog("PASTE: " + copiedText.Trim());
			} catch (Exception ex) {
				Globals.ThisAddIn.AddLog(ex.Message);
			}
		}

		private void buttonAutoFillIncrement_Click(object sender, RibbonControlEventArgs e) {
			try {
				Excel.Range range = excelApp.ActiveCell;
				string rangeValue = range.Text;
				int number;
				if (int.TryParse(rangeValue.ToSafeString(), out number)) {
					AutoIncrement(number, range.Row, range.Column);
				} else {
					Regex re = new Regex(@"([a-zA-Z]+)(\d+)");
					Match result = re.Match(rangeValue.ToSafeString());
					if (result.Groups.Count > 1) {
						string alphaPart = result.Groups[1].Value;
						string numberPart = result.Groups[2].Value;
						number = numberPart.ToInteger();
						AutoIncrement(number, range.Row, range.Column);
					} else {
						if (String.IsNullOrEmpty(rangeValue)) {
							AutoIncrement(1, range.Row, range.Column);
						}
					}
				}
			} catch (Exception ex) {
				Globals.ThisAddIn.AddLog(ex.Message);
			}
		}



		private void toggleButtonViewLogs_Click(object sender, RibbonControlEventArgs e) {
			Globals.ThisAddIn.TogglePanelVisibility(toggleButtonViewLogs.Checked);
		}
	}
}
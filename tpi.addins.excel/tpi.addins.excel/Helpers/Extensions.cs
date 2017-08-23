using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpi.addins.excel {
	internal static class Extensions {
		internal static string ToSafeString(this object value) {
			return value != null ? value.ToString().Trim() : string.Empty;
		}

		internal static int ToInteger(this object value) {
			if(value!= null) {
				int out_Number = 0;
				if(int.TryParse(value.ToSafeString(),out out_Number)) {
					return out_Number;
				}
			}
			return 0;
		}

		internal static bool IsNumber(this object value) {
			if (value != null) {
				int out_Number;
				if (int.TryParse(value.ToSafeString(), out out_Number)) {
					return true;
				}
			}
			return false;
		}
	}
}

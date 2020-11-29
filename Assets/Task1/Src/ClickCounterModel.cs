using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GYRE_Tasks.Task1 {
	public struct ClickData {
		public string ClickCount;
		public ClickData(int count) {
			ClickCount = count.ToString();
		}
	}

	public class ClickCounterModel {
		private int _clickCount;
		public int ClickCount {
			get {
				return _clickCount;
			}
		}
		public ClickCounterModel() {
			_clickCount = 0;
		}

		public void Click() {
			_clickCount++;
		}

		public ClickData ToClickData() {
			return new ClickData(_clickCount);
		}
	}
}

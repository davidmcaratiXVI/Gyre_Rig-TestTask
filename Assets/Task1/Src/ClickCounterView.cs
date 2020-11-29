using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GYRE_Tasks.Task1 {
	public class ClickCounterView : MonoBehaviour {
		public delegate void OnClick();
		public OnClick AnotherClick;
		[SerializeField] private Button clickButton;
		[SerializeField] private Text clickTextValue;
		private void Awake() {
			clickButton.onClick.AddListener(() => ButtonClickHandler());
		}

		private void ButtonClickHandler() {
			AnotherClick(); 
		}

		public void UpdateClickData(ClickData _cd) {
			clickTextValue.text = _cd.ClickCount;
		}
	}
}

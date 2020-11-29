using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GYRE_Tasks.Task1 {
	public class ClickCounterController : MonoBehaviour {
		[SerializeField] private ClickCounterView clickCounter;
		private ClickCounterModel clickCounterModel;

		private void Awake() {
			clickCounterModel = new ClickCounterModel();
			clickCounter.AnotherClick += OnNewClick;
		}

		private void OnNewClick() {
			clickCounterModel.Click();
			clickCounter.UpdateClickData(clickCounterModel.ToClickData());
		}
	}
}

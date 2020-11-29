using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GYRE_Tasks.Task2 {
	public class DataInputView : MonoBehaviour {
		[SerializeField] private InputField inputDelayTime;
		[SerializeField] private InputField inputVelocity;
		[SerializeField] private InputField inputSpace;
		[SerializeField] private Button btnSubmit;
		private DataInput storedData = new DataInput(0f,0f,0f);
		public delegate void Submit(DataInput data);
		public Submit OnInputDataSubmitted;
		private void Awake() {
			inputDelayTime.onEndEdit.AddListener((data) => HandleDelayTimeInput(data));
			inputVelocity.onEndEdit.AddListener((data) => HandleVelocityInput(data));
			inputSpace.onEndEdit.AddListener((data) => HandleSpaceInput(data));
			btnSubmit.onClick.AddListener(() => SubmitInputData());
		}
		private void SubmitInputData() {
			OnInputDataSubmitted(storedData);
		}
		private void UpdateInputFields() {
			inputDelayTime.text = storedData.delayTime.ToString();
			inputVelocity.text = storedData.velocity.ToString();
			inputSpace.text = storedData.space.ToString();
		}
		private void HandleDelayTimeInput(string value) {
			storedData.delayTime = MakeInputValid(float.Parse(value));
			UpdateInputFields();
		}
		private void HandleVelocityInput(string value) {
			storedData.velocity = MakeInputValid(float.Parse(value));
			UpdateInputFields();
		}
		private void HandleSpaceInput(string value) {
			storedData.space = MakeInputValid(float.Parse(value));
			UpdateInputFields();
		}
		private float MakeInputValid(float value) {
			return Mathf.Abs(value);
		}
	}
}

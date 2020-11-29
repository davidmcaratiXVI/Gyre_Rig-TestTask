using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GYRE_Tasks.Task2 {
	public class DataInputController : MonoBehaviour {
		[SerializeField] private DataInputView DataInput;

		private void Awake() {
			DataInput.OnInputDataSubmitted += HandleNewData;
		}

		private void HandleNewData(DataInput data) {
			CubeSpawnManager.instance.SpawnNewCube(data);
		}

	}
}

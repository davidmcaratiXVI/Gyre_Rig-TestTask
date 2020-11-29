using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GYRE_Tasks.Task2 {
	public class CubeSpawnManager : MonoBehaviour {
		public static CubeSpawnManager instance;
		[SerializeField] private GameObject cubeSpawnPrefab;
		[SerializeField] private Transform cubeSpawnPoint;
		private void Awake() {
			if(instance == null) {
				instance = this;
			}
		}

		public void SpawnNewCube(DataInput data) {
			StartCoroutine("SpawnCube", data);
		}

		private IEnumerator SpawnCube(DataInput data) {
			yield return new WaitForSeconds(data.delayTime);
			SpawnedCubeBehaviour _scb = Instantiate(cubeSpawnPrefab,Vector3.zero, Quaternion.identity).GetComponent<SpawnedCubeBehaviour>();
			_scb.Initialize(data.velocity, data.space);
		}
	}
}

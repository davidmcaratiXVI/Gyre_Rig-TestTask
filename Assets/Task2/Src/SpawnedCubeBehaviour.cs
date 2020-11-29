using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GYRE_Tasks.Task2 {
	public class SpawnedCubeBehaviour : MonoBehaviour {
		private float velocity = 0f;
		private float space = 0f;
		private float time = 0f;
		private Vector3 startPosition;
		private Vector3 endPosition;
		public void Initialize(float _v, float _s) {
			velocity = _v;
			space = _s;
			time = space / velocity;
			CalcucalteStartAndEnd();
			StartMoving();
		}

		private void CalcucalteStartAndEnd() {
			startPosition = transform.position;
			endPosition = startPosition + (transform.forward * space);
		}

		private void StartMoving() {
			StartCoroutine("Moving");
		}

		IEnumerator Moving() {
			float _t = 0f;
			while(_t <= time) {
				yield return new WaitForEndOfFrame();
				_t += Time.deltaTime;
				transform.position = Vector3.Lerp(startPosition, endPosition, _t / time);
			}
			Destroy(gameObject);
		}
	}
}

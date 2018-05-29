using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedKill : MonoBehaviour {

	[SerializeField]
	private Scored pearScoreTracker;
	[SerializeField]
	private Scored appleScoreTracker;

	[SerializeField]
	private bool isPear;

	public float pointAdd;

	private void Start() {
		if (pearScoreTracker == null)
			Debug.LogError("Pear score tracker must be defined");
		if (appleScoreTracker == null)
			Debug.LogError("Apple score tracker must be defined");
	}

	private void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag("Player"))
			return;
		if (other.gameObject.tag.Contains("Destroyable")) {
			if (isPear)
				if (pearScoreTracker != null)
					pearScoreTracker.addPoints(pointAdd);
			else
				if (appleScoreTracker != null)
					appleScoreTracker.addPoints(pointAdd);
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
	}
}

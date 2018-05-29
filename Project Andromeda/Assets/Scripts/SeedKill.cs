using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedKill : MonoBehaviour {

	public MonoBehaviour scoreTracker;

	public bool isPear;

	public float pointAdd;

	private void Start() {
		if (scoreTracker == null)
			Debug.LogError("Score tracker must be defined");
	}

	private void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag("Player"))
			return;
		if (other.gameObject.tag.Contains("Destroyable")) {
			if (scoreTracker != null) {
				if (isPear)
					((ScoredPear) scoreTracker).addPoints(pointAdd);
				else
					((Scored) scoreTracker).addPoints(pointAdd);
			}
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
	}
}

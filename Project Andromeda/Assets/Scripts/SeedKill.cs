using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedKill : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag("Player"))
			return;
		Debug.Log("collided");
		if (other.gameObject.tag.Contains("Destroyable")) {
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
	}
}

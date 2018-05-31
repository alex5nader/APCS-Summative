using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour {

	public SpawnableObjects SpawnableObjectList;
	public PowerUpList PowerUpList;
	// the object to place spawned objects under, so they don't clog up the hierarchy
	[SerializeField]
	private Transform ObjectParent;
	public float XPosition;

	public void Spawn() {
		var spawnableObject = SpawnableObjectList.Random();

		foreach (var pair in spawnableObject.GetSpawnable()) {
			// convert the selected object's position to an actual number
			int y;
			switch (pair.Value) {
			case ObjectPosition.Top:
				y = 10;
				break;
			case ObjectPosition.Bottom:
				y = -10;
				break;
			case ObjectPosition.Middle:
			default:
				y = 0;
				break;
			}

			// 1 in 180 chance to spawn a power up in place of an obstacle
			if (Random.Range(0, 180)  < 90) {
				Instantiate(
					PowerUpList.Random(),
					new Vector2(XPosition, y),
					Quaternion.identity, // no rotation
					ObjectParent
				);
			} else {
				Instantiate(
					pair.Key,
					new Vector2(XPosition, y),
					Quaternion.identity,
					ObjectParent
				);
			}
		}
	}
}

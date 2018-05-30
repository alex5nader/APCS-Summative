using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour {

	public SpawnableObjects SpawnableObjectList;
	public GameObject[] PowerUpList;
	[SerializeField]
	private Transform ObjectParent;
	public float XPosition;

	public void Spawn() {
		var spawnableObject = SpawnableObjectList.Random();

		foreach (var pair in spawnableObject.GetSpawnable()) {
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
			if (Random.Range(0, 180)  < 1) {
				Instantiate(
					PowerUpList[Random.Range(0, PowerUpList.Length)],
					new Vector2(XPosition, y),
					Quaternion.identity,
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

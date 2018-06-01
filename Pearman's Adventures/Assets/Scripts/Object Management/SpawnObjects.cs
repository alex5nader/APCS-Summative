using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour {

	public SpawnableObjects SpawnableObjectList;
	public PowerUpList PowerUpList;
	public GameObject CoinPrefab;
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

			var rand = Random.Range(0, 30);
			if (rand < 1) { // 1 out of 30 objects will become a power up
				var toSpawn = PowerUpList.Random();
				if (toSpawn.CompareTag("JetPack")) {
					if (Random.Range(0, 2) == 0) { // 50-50 chance for jetpack to not spawn because it is very strong
						Instantiate(
							pair.Key,
							new Vector2(XPosition, y),
							Quaternion.identity, 
							ObjectParent
						);
					} else {
						Instantiate(
							toSpawn,
							new Vector2(XPosition, y),
							Quaternion.identity, // no rotation
							ObjectParent
						);
					}
				} else if (toSpawn.CompareTag("Magnet")) {
				    if (Toolbox.Instance.PlayMode != PlayState.Multiplayer) {
				        Instantiate(
				            pair.Key,
				            new Vector2(XPosition, y),
				            Quaternion.identity,
				            ObjectParent
				        );
				    }
				} else {
					Instantiate(
						toSpawn,
						new Vector2(XPosition, y),
						Quaternion.identity, // no rotation
						ObjectParent
					);
				}
			} else if (rand < 5) { // 5 out of 30 objects will become a coin
				Instantiate(
					CoinPrefab,
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

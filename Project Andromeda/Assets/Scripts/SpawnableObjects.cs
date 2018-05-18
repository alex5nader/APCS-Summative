using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SpawnableObjects : ScriptableObject {

	[SerializeField]
	private SpawnableObject[] _objects;

	public SpawnableObject this[int index] {
		get { return _objects[index]; }
	}

	public SpawnableObject Random() {
		return _objects[UnityEngine.Random.Range(0, _objects.Length - 1)];
	}
}

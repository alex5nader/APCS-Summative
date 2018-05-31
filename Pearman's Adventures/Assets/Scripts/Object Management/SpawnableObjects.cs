using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// SpawnableObjects is a wrapper for a SpawnableObject array that makes the editor easier to use.
/// It also provides a way to get a random set of objects (in the form of a SpawnableObject)
/// </summary>
[System.Serializable]
public class SpawnableObjects : ScriptableObject {

	[SerializeField]
	private SpawnableObject[] _objects;

	public SpawnableObject this[int index] {
		get { return _objects[index]; }
	}

	public SpawnableObject Random() {
		return _objects[UnityEngine.Random.Range(0, _objects.Length)];
	}
}

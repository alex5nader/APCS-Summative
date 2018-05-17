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
}

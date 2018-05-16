using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SpawnableObjects : ScriptableObject {

	[SerializeField]
	private Transform[] _objects;
	
	public Transform this[int index] {
		get { return _objects[index]; }
	}
}

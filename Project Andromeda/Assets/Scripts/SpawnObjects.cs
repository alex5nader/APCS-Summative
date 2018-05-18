using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour {

	public SpawnableObjects SpawnableObjectList;
	public Transform ObjectParent;

	public void Spawn() {
		
		var newObject = Instantiate(SpawnableObjectList.Random().Object, ObjectParent);
	}
}

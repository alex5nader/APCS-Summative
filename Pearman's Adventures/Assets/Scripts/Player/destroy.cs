using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {
    public static int pearSeedCount = 0;
	// runs when a new seed is created
	void Start () {
        pearSeedCount++;
        if (pearSeedCount > 2)
        {
            pearSeedCount--;
            Destroy(gameObject);
        }
	}

    // runs when the object goes offscreen
    void OnBecameInvisible()
    {
        pearSeedCount--;
        Destroy(gameObject);
    }
}

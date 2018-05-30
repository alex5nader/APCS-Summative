using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {
    public static int i = 0;
	// Use this for initialization
	void Start () {
        i++;
        if (i > 2)
        {
            i--;
            Destroy(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnBecameInvisible()
    {
        i--;
        Destroy(gameObject);
    }
}

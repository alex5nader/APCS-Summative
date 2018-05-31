using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reverse : MonoBehaviour {

    private new Collider collider;
    public PearMan pearMan;
    public Scored scored;

    // Use this for initialization
    void Start () {
        collider = GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("collision");
        pearMan.reverse();
        Destroy(gameObject);
    }
}

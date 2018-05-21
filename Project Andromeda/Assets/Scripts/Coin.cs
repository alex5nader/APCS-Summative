using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    private Collider2D collider;
    public PearMan pearMan;
    public Scored scored;

	// Use this for initialization
	void Start () {
        collider = GetComponent<Collider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if(collider.IsTouching(pearMan.getPlayerCollider()))
        {
            scored.addPoints(100);
            Destroy(gameObject);
        }
	}
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public GameObject projectile;
    public Transform seeds;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity, seeds) as GameObject;
            bullet.GetComponent<Rigidbody2D>().velocity = transform.right * 10;
        }
    }
}

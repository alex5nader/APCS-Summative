using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleShoot : MonoBehaviour {
    // the base to copy when shoot is pressed
    public GameObject projectile;
    // the parent object for seeds to be spawned under
    public Transform seeds;
    // Use this for initialization
    void Start () {
		
	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.D))
        {
            GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity, seeds) as GameObject;
            bullet.GetComponent<Rigidbody2D>().velocity = transform.right * 50;
            var killScript = bullet.GetComponent<SeedKill>();
            killScript.isPear = false;
            killScript.scoreTracker = GetComponent<Scored>();
        }
    }
}

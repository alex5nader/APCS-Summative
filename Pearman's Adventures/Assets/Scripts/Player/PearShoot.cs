using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PearShoot : MonoBehaviour
{
    // the base to copy when shoot is pressed
    public GameObject projectile;
    // the parent object for seeds to be spawned under
    public Transform seeds;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            var bullet = Instantiate(projectile, transform.position, Quaternion.identity, seeds);
            bullet.GetComponent<Rigidbody2D>().velocity = transform.right * 50;
            var killScript = bullet.GetComponent<SeedKill>();
            killScript.isPearSeed = true;
            killScript.scoreTracker = GetComponent<ScoredPear>();
        }
    }
}

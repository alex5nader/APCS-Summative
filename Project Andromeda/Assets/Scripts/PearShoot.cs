using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PearShoot : MonoBehaviour
{
    public GameObject projectile;
    public Transform seeds;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            var bullet = Instantiate(projectile, transform.position, Quaternion.identity, seeds);
            bullet.GetComponent<Rigidbody2D>().velocity = transform.right * 50;
            var killScript = bullet.GetComponent<SeedKill>();
            killScript.isPear = true;
            killScript.scoreTracker = GetComponent<ScoredPear>();
        }
    }
}

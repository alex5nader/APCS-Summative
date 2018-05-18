using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

    public float speed;

    public Transform target;
    public SpawnObjects spawnObjects;

	// Use this for initialization
	void Start () {
        spawnObjects = new SpawnObjects();
	}

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, target.position, step);

        if (Vector2.Distance(transform.position, target.position) < 0.1f)
        {
            transform.position = new Vector2(-26.6f, 0);
            spawnObjects.Spawn();
        }
    }
}

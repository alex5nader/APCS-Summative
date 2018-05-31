using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// <c>Background</c> moves the background sprite towards a certain object's position, then moves it back to the center.
/// This provides the effect that the background is "infinitely scrolling"
/// </summary>
public class Background : MonoBehaviour {

    // the object to move towards
    public Transform target;
    // the reference to the object spawner
    private SpawnObjects spawnObjects;
    
	void Start () {
        spawnObjects = Camera.main.GetComponent<SpawnObjects>();
        if (spawnObjects == null)
            Debug.LogError("Main camera must contain a SpawnObjects script.");
	}

    void Update()
    {
        // get how far to move and move that far toward the target
        float step = Toolbox.Instance.ScrollSpeed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, target.position, step);

        // a distance of 0.1 is effectively inside the other object and
        // provides a margin of error for if the background would overstep
        if (Vector2.Distance(transform.position, target.position) < 0.1f)
        {
            transform.position = Vector2.zero;
            if (spawnObjects != null)
                spawnObjects.Spawn();
        }
    }
}

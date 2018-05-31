using UnityEngine;

public class ObjectMove : MonoBehaviour {

    private SpawnObjects objectSpawner;

    private void Start() {
        objectSpawner = Camera.main.GetComponent<SpawnObjects>();
        if (objectSpawner == null)
            Debug.LogError("Main camera has no SpawnObjects script attached.");
    }

    private void Update() {
        if (objectSpawner == null)
            return;

        transform.Translate(-Toolbox.Instance.ScrollSpeed * Time.deltaTime, 0, 0);

        // objects spawn offscreen by some amount XPosition
        // if this object gets to be offscreen on the other side by that same amount (x pos <= -XPosition), destroy it
        if (transform.position.x <= -objectSpawner.XPosition)
            Destroy(gameObject);
    } 
}
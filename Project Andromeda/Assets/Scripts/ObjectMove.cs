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

        transform.Translate(-Background.Speed * Time.deltaTime, 0, 0);

        if (transform.position.x <= -objectSpawner.XPosition)
            Destroy(gameObject);
    }
}
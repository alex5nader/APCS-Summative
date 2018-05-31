using UnityEngine;

public class ObjectMove : MonoBehaviour {

    private SpawnObjects objectSpawner;

    bool isfivex;
    bool istenx;

    private void Start() {
        objectSpawner = Camera.main.GetComponent<SpawnObjects>();
        if (objectSpawner == null)
            Debug.LogError("Main camera has no SpawnObjects script attached.");

        isfivex = false;
        istenx = false;
    }

    private void Update() {
        if (objectSpawner == null)
            return;

        transform.Translate(-Toolbox.Instance.ScrollSpeed * Time.deltaTime, 0, 0);

        if (transform.position.x <= -objectSpawner.XPosition)
            Destroy(gameObject);
    }

    public void fivex()
    {
        isfivex = true;
    }   
}
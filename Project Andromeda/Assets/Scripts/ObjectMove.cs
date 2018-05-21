using UnityEngine;

public class ObjectMove : MonoBehaviour {

    public float Speed;

    [SerializeField]
    private float CutoffX;

    private void Update() {
        transform.Translate(-Speed * Time.deltaTime, 0, 0);

        if (transform.position.x <= CutoffX)
            Destroy(gameObject);
    }
}
using UnityEngine;

public class ObjectMove : MonoBehaviour {

    public float Speed;

    private void Update() {
        transform.Translate(-Speed * Time.deltaTime, 0, 0);
    }
}
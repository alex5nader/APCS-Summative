using UnityEngine;

public class ObjectMove : MonoBehaviour {

    [SerializeField]
    public static float CutoffX = 30;

    private void Update() {
        transform.Translate(-Background.Speed * Time.deltaTime, 0, 0);

        if (transform.position.x <= CutoffX)
            Destroy(gameObject);
    }
}
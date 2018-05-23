using System;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerDie : MonoBehaviour {

    public void OnCollisionEnter2D(Collision2D other) {
        Toolbox.Instance.ScrollSpeed = Toolbox.Instance.DefaultScrollSpeed;
        if (other.gameObject.CompareTag("Object")) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        } else if (other.gameObject.CompareTag("Power Up"))
            throw new NotImplementedException();
    }
}
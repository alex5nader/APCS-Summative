using System;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerCollide : MonoBehaviour {

    public bool isPear;
    private Scored score;
    public void Start()
    {
        score = GetComponent<Scored>();
    }

    public void OnCollisionEnter2D(Collision2D other) {

        Toolbox.Instance.ScrollSpeed = Toolbox.Instance.DefaultScrollSpeed;
        if (other.gameObject.tag.Contains("Object"))
        {
            AreDead.die();
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Coin"))
        {
            score.addPoints(1000);
            Destroy(other.gameObject);
        }
    }
}
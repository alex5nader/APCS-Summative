using System;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerCollide : MonoBehaviour {

    public bool isPear;
    private Scored score;
    private ScoredPear score2;
    public void Start()
    {
        if(isPear)
            score2 = GetComponent<ScoredPear>();
        else
            score = GetComponent<Scored>();
    }

    public void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag.Contains("Object"))
        {
            Toolbox.Instance.ScrollSpeed = Toolbox.Instance.DefaultScrollSpeed;
            AreDead.die();
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Coin"))
        {
            if(!isPear)
                score.addPoints(1000);
            else
                score2.addPoints(1000);
            Destroy(other.gameObject);
        }
    }
}
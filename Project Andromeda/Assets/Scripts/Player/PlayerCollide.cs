using System;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class PlayerCollide : MonoBehaviour {

    public bool isPear;
    private Scored score;
    private bool isInvun;
    private ScoredPear score2;
    public void Start()
    {
        if(isPear)
            score2 = GetComponent<ScoredPear>();
        else
            score = GetComponent<Scored>();
    }

    public void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag.Contains("Object") && !isInvun)
        {
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
        else if (other.gameObject.CompareTag("Speed2"))
        {
            StartCoroutine(SpeedUp(2, 15));
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Speed3"))
        {
            StartCoroutine(SpeedUp(3,15));
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("SlowDown"))
        {
            StartCoroutine(SpeedUp(.75f,10));
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("JetPack"))
        {
            StartCoroutine(SpeedUp(10f, 5));
            StartCoroutine(Invunerability(6));
            Destroy(other.gameObject);
        }
    }

    private IEnumerator SpeedUp(float mult, float time)
    {
        Toolbox.Instance.MaxScrollSpeed *= mult;
        Toolbox.Instance.ScrollSpeed *= mult;
        Toolbox.Instance.PointsDelta *= mult;
        yield return new WaitForSeconds(time);
        Toolbox.Instance.MaxScrollSpeed /= mult;
        Toolbox.Instance.ScrollSpeed /= mult;
        Toolbox.Instance.PointsDelta /= mult;
    }
    private IEnumerator Invunerability(float time)
    {
        isInvun = true;
        yield return new WaitForSeconds(time);
        isInvun = false;
    }
}
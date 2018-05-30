using System;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class PlayerCollide : MonoBehaviour {

    public bool isPear;
    private Scored score;
    private bool JetPack;
    private bool Shield;
    private ScoredPear score2;
    public void Start()
    {
        if(isPear)
            score2 = GetComponent<ScoredPear>();
        else
            score = GetComponent<Scored>();
    }

    public void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag.Contains("Object") && !JetPack)
        {
<<<<<<< HEAD
            if (Shield)
            {
                Destroy(other.gameObject);
                Shield = false;
            }
            else
            {
                Toolbox.Instance.ScrollSpeed = Toolbox.Instance.DefaultScrollSpeed;
                AreDead.die();
                Destroy(gameObject);
            }
=======
            AreDead.die();
            Destroy(gameObject);
>>>>>>> 13088d152e3ed260893af5345554e457e81d0bd3
        }
        else if (other.gameObject.CompareTag("Coin") && !JetPack)
        {
            if(!isPear)
                score.addPoints(1000);
            else
                score2.addPoints(1000);
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Speed2") && !JetPack)
        {
            StartCoroutine(SpeedUp(2, 15));
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Speed3") && !JetPack)
        {
            StartCoroutine(SpeedUp(3,15));
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("SlowDown") && !JetPack)
        {
            StartCoroutine(SpeedUp(.75f,10));
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("JetPack") && !JetPack)
        {
            StartCoroutine(SpeedUp(10f, 5));
            StartCoroutine(Invunerability(6));
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Shield") && !JetPack && !Shield)
        {
            Shield = true;
            
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
        JetPack = true;
        yield return new WaitForSeconds(time);
        JetPack = false;
    }
}
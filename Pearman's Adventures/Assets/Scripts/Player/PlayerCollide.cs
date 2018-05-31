using System;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class PlayerCollide : MonoBehaviour {

    public bool isPear;
    public GameObject shieldObject;
    private ScoredPear scoreTrackerPear;
    private Scored scoreTrackerApple;
    private bool hasJetPack;
    private bool hasSheild;

    public void Start()
    {
        if(isPear)
            scoreTrackerPear = GetComponent<ScoredPear>();
        else
            scoreTrackerApple = GetComponent<Scored>();
    }

    public void OnTriggerEnter2D(Collider2D other) {
        // don't collide with anything if the player has a jetpack
        if (hasJetPack)
            return;
            
        if (other.gameObject.tag.Contains("Object"))
        {
            if (hasSheild)
            {
                // player shouldnt die with shield
                shieldObject.SetActive(false);
                Destroy(other.gameObject);
                hasSheild = false;
            }
            else
            {
                Destroy(gameObject);
            }
        }
        else if (other.gameObject.CompareTag("Coin"))
        {
            if(!isPear)
                scoreTrackerApple.addPoints(1000);
            else
                scoreTrackerPear.addPoints(1000);
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
        // player can only have one shield active
        else if (other.gameObject.CompareTag("Shield") && !hasSheild)
        {
            hasSheild = true;
            shieldObject.SetActive(true);
            Destroy(other.gameObject);
        }
        else if(other.gameObject.CompareTag("Magnet"))
        {
            other.GetComponent<MoveTowardsPM>().target = transform;
            StartCoroutine(magnet(15));
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
        hasJetPack = true;
        yield return new WaitForSeconds(time);
        hasJetPack = false;
    }
    private IEnumerator magnet(float time)
    {
        MoveTowardsPM.isMagnet = true;
        yield return new WaitForSeconds(time);
        MoveTowardsPM.isMagnet = false;
    }
}
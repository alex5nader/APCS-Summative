using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scored : MonoBehaviour {
    public Text score;
    private int count;
	// Use this for initialization
	void Start ()
    {
        
	}

    // Update is called once per frame
    void Update()
    {
        count++;
        score.text = "Score: " + (count/10);
    }
}

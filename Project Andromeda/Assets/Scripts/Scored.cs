using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scored : MonoBehaviour {
    public Text score;
    private int count;
	// Use this for initialization
	void Start () {
        //InvokeRepeating("AddValue", 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
        count += (int)Time.deltaTime; ;
        score.text = count + "";
	}
//    public AddValue()
//    {
//       count++;
//    }
}

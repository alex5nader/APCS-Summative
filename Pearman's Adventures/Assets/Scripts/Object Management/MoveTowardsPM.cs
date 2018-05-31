using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsPM : MonoBehaviour {
    static public bool isMagnet;
	// Use this for initialization
	void Start () {
        
	}

    // Update is called once per frame
    void Update()
    {
        Debug.Log(isMagnet);
        if(isMagnet)
        {
            float step = (Toolbox.Instance.ScrollSpeed * Time.deltaTime) * 1.5f;
            transform.position = Vector2.MoveTowards(transform.position, GameObject.FindWithTag("Player").transform.position, step);

            if (Vector2.Distance(transform.position, GameObject.FindWithTag("Player").transform.position) < 0.1f)
            {
                transform.position = Vector2.zero;
            }
        }
    }
}

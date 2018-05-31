using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsPM : MonoBehaviour {
    public Transform target;
    static public bool isMagnet;
	// Use this for initialization
	void Start () {
        isMagnet = false;
        
	}

    // Update is called once per frame
    void Update()
    {
        Debug.Log(isMagnet);
        if(isMagnet)
        {
            float step = (Toolbox.Instance.ScrollSpeed * Time.deltaTime) * 2;
            transform.position = Vector2.MoveTowards(transform.position, target.position, step);

            if (Vector2.Distance(transform.position, target.position) < 0.1f)
            {
                transform.position = Vector2.zero;
            }
        }
    }
}

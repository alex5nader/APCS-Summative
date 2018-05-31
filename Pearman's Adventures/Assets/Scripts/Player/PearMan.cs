using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PearMan : MonoBehaviour
{
    private int lane;
    private bool reversed;

    void Start()
    {
        lane = 1;
        reversed = false;
	}
	
	void Update()
    {
        if (!reversed)
        {
            if (Input.GetKeyDown("down"))
            {
                if (lane == 1)
                {
                    lane = 0;
                    transform.position = new Vector2(transform.position.x, transform.position.y - 10);
                }
                if (lane == 2)
                {
                    lane = 1;
                    transform.position = new Vector2(transform.position.x, transform.position.y - 10);
                }
            }
            if (Input.GetKeyDown("up"))
            {
                if (lane == 1)
                {
                    lane = 2;
                    transform.position = new Vector2(transform.position.x, transform.position.y + 10);
                }
                if (lane == 0)
                {
                    lane = 1;
                    transform.position = new Vector2(transform.position.x, transform.position.y + 10);
                }
            }
        }
        else
        {
            if (Input.GetKeyDown("up"))
            {
                if (lane == 1)
                {
                    lane = 0;
                    transform.position = new Vector2(transform.position.x, transform.position.y - 10);
                }
                if (lane == 2)
                {
                    lane = 1;
                    transform.position = new Vector2(transform.position.x, transform.position.y - 10);
                }
            }
            if (Input.GetKeyDown("down"))
            {
                if (lane == 1)
                {
                    lane = 2;
                    transform.position = new Vector2(transform.position.x, transform.position.y + 10);
                }
                if (lane == 0)
                {
                    lane = 1;
                    transform.position = new Vector2(transform.position.x, transform.position.y + 10);
                }
            }
        }
    }

    public void reverse()
    {
        reversed = !reversed;
    }
}

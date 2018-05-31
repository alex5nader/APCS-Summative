using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PearMan : MonoBehaviour
{
    private int position;
    private new Collider collider;
    private bool reversed;

    void Start()
    {
        collider = GetComponent<Collider>();
        position = 1;
        reversed = false;
	}
	
	void Update()
    {
        if (!reversed)
        {
            if (Input.GetKeyDown("down"))
            {
                if (position == 1)
                {
                    position = 0;
                    transform.position = new Vector2(transform.position.x, transform.position.y - 10);
                }
                if (position == 2)
                {
                    position = 1;
                    transform.position = new Vector2(transform.position.x, transform.position.y - 10);
                }
            }
            if (Input.GetKeyDown("up"))
            {
                if (position == 1)
                {
                    position = 2;
                    transform.position = new Vector2(transform.position.x, transform.position.y + 10);
                }
                if (position == 0)
                {
                    position = 1;
                    transform.position = new Vector2(transform.position.x, transform.position.y + 10);
                }
            }
        }
        else
        {
            if (Input.GetKeyDown("up"))
            {
                if (position == 1)
                {
                    position = 0;
                    transform.position = new Vector2(transform.position.x, transform.position.y - 10);
                }
                if (position == 2)
                {
                    position = 1;
                    transform.position = new Vector2(transform.position.x, transform.position.y - 10);
                }
            }
            if (Input.GetKeyDown("down"))
            {
                if (position == 1)
                {
                    position = 2;
                    transform.position = new Vector2(transform.position.x, transform.position.y + 10);
                }
                if (position == 0)
                {
                    position = 1;
                    transform.position = new Vector2(transform.position.x, transform.position.y + 10);
                }
            }
        }
    }

    public Collider getPlayerCollider()
    {
        return collider;
    }

    public void reverse()
    {
        reversed = !reversed;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PearMan : MonoBehaviour
{
    private int position;
    private Collider2D collider;

    void Start()
    {
        collider = GetComponent<Collider2D>();
        position = 1;
	}
	
	void Update()
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

    public Collider2D getPlayerCollider()
    {
        return collider;
    }
}

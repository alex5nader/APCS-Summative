using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyA : MonoBehaviour
{
    public static int i = 0;
    // Use this for initialization
    void Start()
    {
        i++;
        if (i > 3)
        {
            i--;
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnBecameInvisible()
    {
        i--;
        Destroy(gameObject);
    }
}

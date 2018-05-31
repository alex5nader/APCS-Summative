using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyA : MonoBehaviour
{
    public static int appleSeedCount = 0;
	// runs when a new seed is created
    void Start()
    {
        appleSeedCount++;
        if (appleSeedCount > 2)
        {
            appleSeedCount--;
            Destroy(gameObject);
        }
    }

    // runs when the object goes offscreen
    void OnBecameInvisible()
    {
        appleSeedCount--;
        Destroy(gameObject);
    }
}

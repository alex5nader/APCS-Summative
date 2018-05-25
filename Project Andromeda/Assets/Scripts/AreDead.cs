using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class AreDead : MonoBehaviour {

    private static int player;
	
	// Update is called once per frame
	void Update () {
		if(player == 0)
        {
            SceneManager.LoadScene(0);
        }
	}

    public static void die()
    {
        player--;
    }

    public static void Reset(int player) {
        AreDead.player = player;
    }
}

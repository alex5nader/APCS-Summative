using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class AreDead : MonoBehaviour {

    private static int player;
	
    private void Start() {
        player = GameObject.FindGameObjectsWithTag("Player").Length;
    }

	// Update is called once per frame
	void Update () {
		if(player == 0)
        {
            Toolbox.Instance.Reset();
            SceneManager.LoadScene(3);
        }
	}

    public static void die()
    {
        player--;
    }
}

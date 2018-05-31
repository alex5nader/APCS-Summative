using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class AreDead : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if(GameObject.FindGameObjectsWithTag("Player").Length == 0)
        {
            Toolbox.Instance.Reset();
            SceneManager.LoadScene((int) PlayState.GameOverScreen);
        }
	}
}

﻿//#define EDITOR

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
    public Button TitleButton;
    public Button ReplayButton;
    public Button QuitButton;

    private void Start()
    {
        TitleButton.onClick.AddListener(GoToTitle);
        ReplayButton.onClick.AddListener(Replay);
        QuitButton.onClick.AddListener(Quit);
    }

    private void GoToTitle()
    {
        Toolbox.Instance.ScrollSpeed = Toolbox.Instance.DefaultScrollSpeed;
        SceneManager.LoadScene(0);
    }

    private void Replay() {
        Toolbox.Instance.ScrollSpeed = Toolbox.Instance.DefaultScrollSpeed;
        SceneManager.LoadScene(Toolbox.Instance.PlayMode);
    }

    private void Quit()
    {
        #if EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}

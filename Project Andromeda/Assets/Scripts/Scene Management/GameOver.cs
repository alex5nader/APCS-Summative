﻿//#define EDITOR

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
    public Button TitleButton;
    public Button ReplayButton;

    private void Start()
    {
        TitleButton.onClick.AddListener(GoToTitle);
        ReplayButton.onClick.AddListener(Replay);
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
}

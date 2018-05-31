// #define EDITOR

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour {
    
    public Button PlayButtonSP;
    public Button PlayButtonMP;

    private void Awake() {
        PlayButtonSP.onClick.AddListener(PlayGameSingleplayer);
        PlayButtonMP.onClick.AddListener(PlayGameMultiplayer);
    }

    private void PlayGameSingleplayer() {
        Toolbox.Instance.Reset();
        Toolbox.Instance.PlayMode = PlayState.Singleplayer;
        SceneManager.LoadScene((int) PlayState.Singleplayer);
    }

    private void PlayGameMultiplayer()
    {
        Toolbox.Instance.Reset();
        Toolbox.Instance.PlayMode = PlayState.Multiplayer;
        SceneManager.LoadScene((int) PlayState.Multiplayer);
    }
}
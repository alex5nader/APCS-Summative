// #define EDITOR

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour {
    
    private const int SingleplayerScene = 1;
    private const int MultiplayerScene = 2;

    public Button PlayButtonSP;
    public Button PlayButtonMP;

    private void Awake() {
        PlayButtonSP.onClick.AddListener(PlayGameSingleplayer);
        PlayButtonMP.onClick.AddListener(PlayGameMultiplayer);
    }

    private void PlayGameSingleplayer() {
        Toolbox.Instance.ScrollSpeed = Toolbox.Instance.DefaultScrollSpeed;
        Toolbox.Instance.PlayMode = 1;
        SceneManager.LoadScene(SingleplayerScene);
    }

    private void PlayGameMultiplayer()
    {
        Toolbox.Instance.ScrollSpeed = Toolbox.Instance.DefaultScrollSpeed;
        Toolbox.Instance.PlayMode = 2;
        SceneManager.LoadScene(MultiplayerScene);
    }
}
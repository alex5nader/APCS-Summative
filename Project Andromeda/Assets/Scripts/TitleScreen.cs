using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour {
    
    private const int SingleplayerScene = 1;
    private const int MultiplayerScene = 2;

    public Button PlayButtonSP;
    public Button PlayButtonMP;
    public Button QuitButton;

    private void Awake() {
        PlayButtonSP.onClick.AddListener(PlayGameSingleplayer);
        PlayButtonMP.onClick.AddListener(PlayGameMultiplayer);
        QuitButton.onClick.AddListener(Application.Quit);
    }

    private void PlayGameSingleplayer() {
        Toolbox.Instance.ScrollSpeed = Toolbox.Instance.DefaultScrollSpeed;
        SceneManager.LoadScene(SingleplayerScene);
    }

    private void PlayGameMultiplayer()
    {
        Toolbox.Instance.ScrollSpeed = Toolbox.Instance.DefaultScrollSpeed;
        SceneManager.LoadScene(MultiplayerScene);
    }
}
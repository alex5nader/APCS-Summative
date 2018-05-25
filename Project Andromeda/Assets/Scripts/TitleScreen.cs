using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour {
    
    public Button PlayButtonSP;
    public Button PlayButtonMP;
    public Button QuitButton;

    private void Awake() {
        PlayButtonSP.onClick.AddListener(PlayGameSingleplayer);
        PlayButtonMP.onClick.AddListener(PlayGameMultiplayer);
        QuitButton.onClick.AddListener(Application.Quit);
    }

    private void PlayGameSingleplayer() {
        AreDead.Reset(1);
        Toolbox.Instance.ScrollSpeed = Toolbox.Instance.DefaultScrollSpeed;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void PlayGameMultiplayer() {
        AreDead.Reset(2);
        Toolbox.Instance.ScrollSpeed = Toolbox.Instance.DefaultScrollSpeed;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
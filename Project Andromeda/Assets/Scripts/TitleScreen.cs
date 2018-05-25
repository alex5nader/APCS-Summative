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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void PlayGameMultiplayer() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
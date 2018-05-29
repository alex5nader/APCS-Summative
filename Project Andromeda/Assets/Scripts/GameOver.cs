using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
    public Button TitleButton;
    public Button QuitButton;

    private void Start()
    {
        TitleButton.onClick.AddListener(GoToTitle);
        QuitButton.onClick.AddListener(Quit);
    }

    private void GoToTitle()
    {
        Toolbox.Instance.ScrollSpeed = Toolbox.Instance.DefaultScrollSpeed;
        SceneManager.LoadScene(0);
    }

    private void Quit()
    {
        if (Application.isEditor)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
        else
            Application.Quit();
    }
}

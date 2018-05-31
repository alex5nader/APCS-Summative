//#define EDITOR

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
    public Button TitleButton;
    public Button ReplayButton;

    private void Start()
    {
        // tell buttons to run those methods when they are clicked
        TitleButton.onClick.AddListener(GoToTitle);
        ReplayButton.onClick.AddListener(Replay);
    }

    private void GoToTitle()
    {
        Toolbox.Instance.Reset();
        SceneManager.LoadScene((int) PlayState.TitleScreen);
    }

    private void Replay() {
        Toolbox.Instance.Reset();
        SceneManager.LoadScene((int) Toolbox.Instance.PlayMode);
    }
}

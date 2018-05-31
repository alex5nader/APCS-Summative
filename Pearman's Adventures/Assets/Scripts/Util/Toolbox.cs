using UnityEngine;

/// <summary>
/// Toolbox is a way to provide global variables and constants.
/// Variables are accessible by Toolbox.Instance.&lt;var&gt;
/// and constants are accessible by Toolbox.&lt;const&gt;
/// </summary>
public class Toolbox : Singleton<Toolbox> {

    protected Toolbox() { }

    #region Constants
    public const int TitleScreenScene = 1;
    public const int SingleplayerScene = 2;
    public const int MultiplayerScene = 3;
    public const int GameOverScene = 4;
    #endregion

    #region Globals
    public float ScrollSpeed { get; set; }
    public float MaxScrollSpeed { get; set; }
    public float DefaultScrollSpeed { get; private set; }
    public float ScrollDelta { get; set; }
    
    public float PointsDelta { get; set; }
    public float DefaultPointsDelta { get; set; }

    public int PlayMode { get; set; }
    #endregion

    private void Awake() {
        DefaultScrollSpeed = 30f;
        MaxScrollSpeed = 80f;
        // number of frames in 5 seconds = fps * 5 seconds
        // delta per frame = change in speed / (number of frames in 5 seconds)
        ScrollDelta = (MaxScrollSpeed - DefaultScrollSpeed) / (60f * 60f * 5f);
        ScrollSpeed = DefaultScrollSpeed;

        DefaultPointsDelta = 1f;
        PointsDelta = DefaultPointsDelta;
        PlayMode = -1;
    }

    public void Reset() {
        ScrollSpeed = DefaultScrollSpeed;
        PointsDelta = DefaultPointsDelta;
    }

    private void Update() {
        ScrollSpeed += ScrollDelta;
        if (ScrollSpeed > MaxScrollSpeed)
            ScrollSpeed = MaxScrollSpeed;
    }
}
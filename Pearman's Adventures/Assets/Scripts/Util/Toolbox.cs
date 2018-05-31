using UnityEngine;

/// <summary>
/// Toolbox is a way to provide global variables.
/// Variables are accessible by Toolbox.Instance.&lt;var&gt;
/// </summary>
public class Toolbox : Singleton<Toolbox> {

    protected Toolbox() { }

    #region Globals
    public float ScrollSpeed { get; set; }
    public float MaxScrollSpeed { get; set; }
    public float DefaultScrollSpeed { get; private set; }
    public float HardMaxScrollSpeed { get; set; }
    public float ScrollDelta { get; set; }
    
    public float PointsDelta { get; set; }
    public float DefaultPointsDelta { get; set; }

    public PlayState PlayMode { get; set; }
    #endregion

    private void Awake() {
        DefaultScrollSpeed = 30f;
        MaxScrollSpeed = 80f;
        HardMaxScrollSpeed = MaxScrollSpeed * 4;
        // number of frames in 5 seconds = fps * 5 seconds
        // delta per frame = change in speed / (number of frames in 5 seconds)
        ScrollDelta = (MaxScrollSpeed - DefaultScrollSpeed) / (60f * 60f * 1.5f);
        ScrollSpeed = DefaultScrollSpeed;

        DefaultPointsDelta = 1f;
        PointsDelta = DefaultPointsDelta;
        PlayMode = PlayState.None;
    }

    public void Reset() {
        ScrollSpeed = DefaultScrollSpeed;
        PointsDelta = DefaultPointsDelta;
    }

    private void Update() {
        ScrollSpeed += ScrollDelta;
        if (MaxScrollSpeed > HardMaxScrollSpeed)
            MaxScrollSpeed = HardMaxScrollSpeed;
        if (ScrollSpeed > MaxScrollSpeed)
            ScrollSpeed = MaxScrollSpeed;
    }
}

public enum PlayState {
    None = -1,
    TitleScreen,
    Singleplayer,
    Multiplayer,
    GameOverScreen
}
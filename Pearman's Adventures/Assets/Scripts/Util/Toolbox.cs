using UnityEngine;

/// <summary>
/// Toolbox is a way to provide global variables.
/// Variables are accessible by Toolbox.Instance.&lt;var&gt;
/// </summary>
public class Toolbox : Singleton<Toolbox> {

    protected Toolbox() { }

    private float actualMaxScrollSpeed;
    private float actualPointsDelta;

    #region Globals
    public float ScrollSpeed { get; set; }

    public float MaxScrollSpeed {
        get { return Mathf.Clamp(actualMaxScrollSpeed, DefaultMaxScrollSpeed * .75f, actualMaxScrollSpeed); }
        set { actualMaxScrollSpeed = value; }
    }
    public float DefaultScrollSpeed { get; private set; }
    public float DefaultMaxScrollSpeed { get; private set; }
    public float HardMaxScrollSpeed { get; set; }
    public float ScrollSpeedDelta { get; set; }

    public float PointsDelta {
        get { return Mathf.Clamp(actualPointsDelta, DefaultPointsDelta * .75f, actualPointsDelta); }
        set { actualPointsDelta = value; }
    }
    public float DefaultPointsDelta { get; set; }

    public PlayState PlayMode { get; set; }
    #endregion

    private void Awake() {
        DefaultScrollSpeed = 40f;
        DefaultMaxScrollSpeed = 80f;
        MaxScrollSpeed = DefaultMaxScrollSpeed;
        HardMaxScrollSpeed = MaxScrollSpeed * 5; // jetpack makes you 5x as fast so the absolute max should be jetpack speed
        // number of frames in 5 seconds = fps * 5 seconds
        // delta per frame = change in speed / (number of frames in 5 seconds)
        ScrollSpeedDelta = (MaxScrollSpeed - DefaultScrollSpeed) / (60f * 60f * 1.5f);
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
        ScrollSpeed += ScrollSpeedDelta;
        if (MaxScrollSpeed > HardMaxScrollSpeed) // keep withing hard cap
            MaxScrollSpeed = HardMaxScrollSpeed;
        if (MaxScrollSpeed < DefaultMaxScrollSpeed * .75f) // don't go too slow
            MaxScrollSpeed = DefaultMaxScrollSpeed * .75f;
        if (ScrollSpeed > MaxScrollSpeed) // cap speed outside of speed ups/downs
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
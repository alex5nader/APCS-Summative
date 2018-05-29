public class Toolbox : Singleton<Toolbox> {

    protected Toolbox() { }

    public float ScrollSpeed { get; set; }
    public float MaxScrollSpeed { get; set; }
    public float DefaultScrollSpeed { get; private set; }
    public float ScrollDelta { get; set; }

    private void Awake() {
        DefaultScrollSpeed = 30f;
        MaxScrollSpeed = 80f;
        // number of frames in 5 seconds = fps * 5 seconds
        // delta per frame = change in speed / (number of frames in 5 seconds)
        ScrollDelta = (MaxScrollSpeed - DefaultScrollSpeed) / (60f * 60f * 5f);
        ScrollSpeed = DefaultScrollSpeed;
    }

    private void Update() {
        ScrollSpeed += ScrollDelta;
        if (ScrollSpeed > MaxScrollSpeed)
            ScrollSpeed = MaxScrollSpeed;
    }
}
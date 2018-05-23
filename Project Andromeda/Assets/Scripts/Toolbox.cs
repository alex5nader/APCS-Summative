public class Toolbox : Singleton<Toolbox> {

    protected Toolbox() { }

    public float ScrollSpeed { get; set; }
    public float DefaultScrollSpeed { get; private set; }

    private void Awake() {
        DefaultScrollSpeed = 20f;
        ScrollSpeed = DefaultScrollSpeed;
    }

    private void Update() {
        ScrollSpeed *= 1.0005f;
    }
}
using UnityEngine;

[System.Serializable]
public class PowerUpList : ScriptableObject {

    [SerializeField]
    private GameObject[] _powerUps;

    public GameObject this[int index] {
        get { return _powerUps[index]; }
    }

    public GameObject Random() {
        return _powerUps[UnityEngine.Random.Range(0, _powerUps.Length)];
    }
}
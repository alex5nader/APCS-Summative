using UnityEngine;

/// <summary>
/// PowerUpList is a wrapper for a GameObject[] that makes the editor easy to use
/// and provides a Random() method for getting a random power up
/// </summary>
[System.Serializable]
public class PowerUpList : ScriptableObject {

    [SerializeField]
    private GameObject[] _powerUps;

    public GameObject this[int index] {
        get { return _powerUps[index]; }
    }

    /// <summary>
    /// Get a random power up from the array
    /// </summary>
    /// <returns>A random power up from the array</returns>
    public GameObject Random() {
        return _powerUps[UnityEngine.Random.Range(0, _powerUps.Length)];
    }
}
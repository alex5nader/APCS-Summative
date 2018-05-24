using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scored : MonoBehaviour {
    public TextMeshPro ScoreObject;
    private float count;

    // Update is called once per frame
    void Update()
    {
        addPoints(0.1f);
        ScoreObject.SetText(Mathf.FloorToInt(count).ToString());
    }

    public void addPoints(float points)
    {
        count += points;
    }
}

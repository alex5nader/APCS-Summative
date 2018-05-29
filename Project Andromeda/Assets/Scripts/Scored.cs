using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scored : MonoBehaviour {
    public TextMeshProUGUI ScoreObject;
    private float count;

    // Update is called once per frame
    void Update()
    {
        addPoints(1f);
        ScoreObject.SetText(Mathf.FloorToInt((int) count / 10 * 10).ToString()); // make player feel better by multiplying the score by 10
    }

    public void addPoints(float points)
    {
        count += points;
    }
}

using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoredPear : MonoBehaviour
{
    public TextMeshProUGUI ScoreObject;
    private float count = -20;

    // Update is called once per frame
    void Update()
    {
        // pear score should be equal to apple but apple is slightly ahead so this makes them look the same but also be equal if they both die to the same obstacle
        addPoints(Toolbox.Instance.PointsDelta);
        var text = Mathf.FloorToInt((int) (count + 20) / 10 * 10);
        if (text < 0)
            text = 0;
        ScoreObject.SetText((text).ToString()); // make player feel better by "multiplying" the score by 10
    }

    public void addPoints(float points)
    {
        count += points;
    }
}

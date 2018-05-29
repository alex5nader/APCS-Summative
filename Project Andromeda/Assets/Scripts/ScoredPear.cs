using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoredPear : MonoBehaviour
{
    public TextMeshProUGUI ScoreObject;
    private float count = -2;

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

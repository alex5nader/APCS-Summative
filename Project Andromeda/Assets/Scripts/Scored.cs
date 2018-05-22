using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scored : MonoBehaviour {
    public Transform Canvas;
    private float count;
    private GameObject scoreObject;
	// Use this for initialization
	void Start ()
    {
        var scoreTransform = Canvas.Cast<Transform>().FirstOrDefault(child => child.CompareTag("ScoreUI"));
        if (scoreTransform != null)
            scoreObject = scoreTransform.gameObject;
        else
            Debug.LogError("No UI Object found with tag ScoreUI");
	}

    // Update is called once per frame
    void Update()
    {
        count += 0.1f;
        if (scoreObject == null) {
            Debug.LogError("No UI object found with tag ScoreUI");
            return;
        }
        var tmProComponent = scoreObject.GetComponent<TextMeshProUGUI>();
        var textComponent = scoreObject.GetComponent<Text>();
        if (tmProComponent != null) {
            tmProComponent.SetText(Mathf.FloorToInt(count).ToString());
        } else if (textComponent != null) {
            textComponent.text = Mathf.FloorToInt(count).ToString();
        }
    }

    public void addPoints(int points)
    {
        count += points;
    }
}

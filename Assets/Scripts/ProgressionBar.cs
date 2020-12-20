using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressionBar : MonoBehaviour
{
    public static ProgressionBar progressionBar;
    public Text progressionText;
    public int progression;
    public GameObject winText;
    public GameObject looseText;

    public int Progression
    {
        get => progression;
        set
        {
            UpdateProgress();
            progression = Mathf.Clamp(value, 0, 100);
        }
    }

    private void Start()
    {
        progressionBar = this;
        UpdateProgress();
        if(progressionText == null)
        {
            progressionText = GetComponent<Text>();
        }
    }

    public void UpdateProgress()
    {
        progressionText.text = $"Progress: {Progression}";
        if(progression >= 100)
        {
            winText.SetActive(true);
            Time.timeScale = 0;
        }
    }
}

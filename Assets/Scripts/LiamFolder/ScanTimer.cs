using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class ScanTimer : MonoBehaviour
{
    [Header("Component")]
    public TextMeshProUGUI timerText;
    public Slider slider;

    [Header("Timer Setting")]
    public float currentTime;
    public bool countDown;
    public float scanFrequency;

    [Header("Limit Settings")]
    public bool hasLimit;
    public float timerLimit;
    public TheKillsYouScript virus; 

    // Update is called once per frame
    void Update()
    {
        currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;

        if (hasLimit && ((countDown && currentTime <= timerLimit) || (!countDown && currentTime >= timerLimit)))
        {
            SetTimerText();
            virus.Scan();
        }
        if(currentTime <= 0) {
        currentTime = scanFrequency;
        }
        SetTimerText();
        slider.value = currentTime;
    }
    private void SetTimerText()
    {
        timerText.text = currentTime.ToString("0.0000000");
    }
}

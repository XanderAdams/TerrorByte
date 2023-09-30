using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanTimer : MonoBehaviour
{
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
            virus.Scan();
        }
        if(currentTime <= 0) {
        currentTime = scanFrequency;
        }
    }
}

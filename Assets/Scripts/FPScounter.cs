using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class FPScounter : MonoBehaviour
{
    float fps;
    float updateTimer = 0.2f;

    [SerializeField] TextMeshProUGUI fpsTitle;

    private void UpdateFPS()
    {
        updateTimer -= Time.deltaTime;
        if (updateTimer<= 0f)
        {
            fps = 1f / Time.unscaledDeltaTime;
            fpsTitle.text = "FPS: " + Mathf.Round(fps);
            updateTimer = 0.2f; // to update 5 times every second
        }
    }
    void Update()
    {
        UpdateFPS();
    }
}

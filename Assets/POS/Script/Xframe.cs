using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Xframe : MonoBehaviour
{
    private List<float> myData = new List<float>();

    private float timeSinceLastCalled;

    [SerializeField] TextMeshProUGUI debugMessage;

    private void Update()
    {

        debugMessage.text = "FPS: "+Time.frameCount;
        RunOn(60, SomeFunction);
        RunPer(2, SomeFunction2);
    }

    private void SomeFunction()
    {
        Debug.Log("Run on 3rd");
        myData.Add(0);
    }

    private void SomeFunction2()
    {
        Debug.Log("Run per 1 frame");
        myData.Add(0);
    }

    private void RunOn(int xframe, Action funToRun)
    {
        if (Time.frameCount % xframe == 0) funToRun();
    }

    private void RunPer(int delay, Action funToRun)
    {
        timeSinceLastCalled += Time.deltaTime;
        if (timeSinceLastCalled > delay)
        {
            funToRun();
            timeSinceLastCalled = 0f;
        }
    }
}

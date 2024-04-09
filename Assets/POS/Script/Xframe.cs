using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xframe : MonoBehaviour
{
    private List<float> myData = new List<float>();

    private int interval = 24;
    private void Update()
    {
        Debug.Log("A frame");
        // if (Time.frameCount % interval == 0) SomeFunction();
        RunOn(10, SomeFunction);
        RunOn(24, SomeFunction);
    }

    private void SomeFunction()
    {
        Debug.Log("3rd frame");
        myData.Add(0);
    }

    private void RunOn(int xframe,Action funToRun){
        if (Time.frameCount % xframe == 0) funToRun();
    }
}

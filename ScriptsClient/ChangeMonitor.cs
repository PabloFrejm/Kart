using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMonitor : MonoBehaviour
{



    private void Start()
    {
        
    }
    private void Update()
    {
        
    }


    public void DetectDisplay()
    {
        for (int i = 0; i < Display.displays.Length; i++)
        {
            Display.displays[i].Activate();
            Debug.Log(i);
        }
    }
}


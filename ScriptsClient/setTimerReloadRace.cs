using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class setTimerReloadRace : MonoBehaviour
{

    public TMP_InputField inputTimeReload;
  
    public float currentTimeReload;
    public string sec;
    public float limitSec;
    public float reloadTime;
    // Start is called before the first frame update
    void Start()
    {
        updateTimeReload();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void updateTimeReload()
    {
        
        if (reloadTime== 1)
        {
            sec = "секунда";
        }
        if (reloadTime >= 2&& reloadTime <= 4)
        {
            sec = "секунды";
        }
        if (reloadTime >= 5&&reloadTime<=limitSec||reloadTime==0)
        {
            sec = "секунд";
        }
        inputTimeReload.text = reloadTime.ToString()+" "+sec;
    }

    public void editTimeReload()
    {

        float.TryParse(inputTimeReload.text, out currentTimeReload);
        
        float t=Mathf.Abs(currentTimeReload);
        
        if (t < limitSec)
        {
           reloadTime = t;
        }
        else
        {
           reloadTime = limitSec;
        }
        
       
    }
}

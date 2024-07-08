using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationUI : MonoBehaviour
{
    public LeanTweenType type;
    public GameObject generalPnl, sessionRacePnl, sessionFootBallPnl, settingsPnl, startIpPnl, infoExitPnl, startRacePnl, startFootBallPnl, 
                      infoPauseRacePnl,  infoPauseFootBallPnl, infoReloadRacePnl, infoReloadFootBallPnl, infoToEndRacePnl, infoToEndFootBallPnl;
    public GameObject tergetPanel, connectPanel;
    public float time;
    public Client GetClient;
    public bool bConnect;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //DisActiveTargetPanel();
     //   CoonectStatusPanel();
    }

    public void GeneralPnlActive()
    {
        LeanTween.scale(generalPnl, Vector3.one, time).setEase(type);
    }
    public void GeneralPnlDisactive()
    {
       // if (GetClient.connect)
       // {
            LeanTween.scale(generalPnl, Vector3.zero, time).setEase(type);
       // }
    }
    public void SessionRacePnlActive()
    {
      //  if (GetClient.connect)
       // {
            LeanTween.scale(sessionRacePnl, Vector3.one, time).setEase(type);
       // }
       
    }
    public void SessionRacePnlDisactive()
    {
        LeanTween.scale(sessionRacePnl, Vector3.zero, time).setEase(type);
    }
    public void SessionFootBallPnlActive()
    {
        //if (GetClient.connect)
        //{
            LeanTween.scale(sessionFootBallPnl, Vector3.one, time).setEase(type);
        //}
    }
    public void SessionFootBallPnlDisactive()
    {
        LeanTween.scale(sessionFootBallPnl, Vector3.zero, time).setEase(type);
    }
    public void SettingsPnlActive()
    {
        LeanTween.scale(settingsPnl, Vector3.one, time).setEase(type);
    }
    public void SettingsPnlDisactive()
    {
        LeanTween.scale(settingsPnl, Vector3.zero, time).setEase(type);
    }
    public void DisActiveTargetPanel()
    {
        if (GetClient.connect) 
        {
       
            tergetPanel.SetActive(false);


        }
        else
        {
            if (GetClient.connect) { tergetPanel.SetActive(true);}
        }
    }
    public void CoonectStatusPanel()
    {
        if (GetClient.connect) 
        {
            if (!bConnect)
            {
                LeanTween.scale(connectPanel, Vector3.zero, time).setEase(type);
                bConnect = true;
            }


        }
        else
        {
            if (bConnect)
            {
                LeanTween.scale(connectPanel, Vector3.one, time).setEase(type);
                bConnect = false;
            }
            else
            {

            }
        }
    }
    public void StartIPPnlActive()
    {
        LeanTween.scale(startIpPnl, Vector3.one, time).setEase(type);
    }
    public void StartIPPnlDisactive()
    {
        LeanTween.scale(startIpPnl, Vector3.zero, time).setEase(type);
    }
    public void infoExitPnlActive()
    {
        LeanTween.scale(infoExitPnl, Vector3.one, time).setEase(type);
    }
    public void InfoExitPnlDisactive()
    {
        LeanTween.scale(infoExitPnl, Vector3.zero, time).setEase(type);
    }

    public void StartRacePnlActive()
    {
        LeanTween.scale(startRacePnl, Vector3.one, time).setEase(type);
    }

    public void StartRacePnlDisactive()
    {
        LeanTween.scale(startRacePnl, Vector3.zero, time).setEase(type);
    }

    public void StartFootBallPnlActive()
    {
        LeanTween.scale(startFootBallPnl, Vector3.one, time).setEase(type);
    }

    public void StartFootBallPnlDisactive()
    {
        LeanTween.scale(startFootBallPnl, Vector3.zero, time).setEase(type);
    }

    public void InfoPauseRacePnlActive()
    {
        LeanTween.scale(infoPauseRacePnl, Vector3.one, time).setEase(type);
    }

    public void InfoPauseRacePnlDisactive()
    {
        LeanTween.scale(infoPauseRacePnl, Vector3.zero, time).setEase(type);
    }

    public void InfoReloadRacePnlActive()
    {
        LeanTween.scale(infoReloadRacePnl, Vector3.one, time).setEase(type);
    }

    public void InfoReloadRacePnlDisactive()
    {
        LeanTween.scale(infoReloadRacePnl, Vector3.zero, time).setEase(type);
    }

    public void InfoToEndRacePnlActive()
    {
        LeanTween.scale(infoToEndRacePnl, Vector3.one, time).setEase(type);
    }

    public void InfoToEndRacePnlDisactive()
    {
        LeanTween.scale(infoToEndRacePnl, Vector3.zero, time).setEase(type);
    }

    public void InfoPauseFootBallPnlActive()
    {
        LeanTween.scale(infoPauseFootBallPnl, Vector3.one, time).setEase(type);
    }

    public void InfoPauseFootBallPnlDisactive()
    {
        LeanTween.scale(infoPauseFootBallPnl, Vector3.zero, time).setEase(type);
    }

    public void InfoReloadFootBallPnlActive()
    {
        LeanTween.scale(infoReloadFootBallPnl, Vector3.one, time).setEase(type);
    }

    public void InfoReloadFootBallPnlDisactive()
    {
        LeanTween.scale(infoReloadFootBallPnl, Vector3.zero, time).setEase(type);
    }

    public void InfoToEndFootBallPnlActive()
    {
        LeanTween.scale(infoToEndFootBallPnl, Vector3.one, time).setEase(type);
    }

    public void InfoToEndFootBallPnlDisactive()
    {
        LeanTween.scale(infoToEndFootBallPnl, Vector3.zero, time).setEase(type);
    }


}

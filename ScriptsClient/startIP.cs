using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class startIP : MonoBehaviour
{


    public string inputIP;
    public string inputPort="4444";
    public TMP_InputField txtIP;
    public TMP_InputField txtPort;
    public Client GetClient;
    public Button btnConnect,btnStart;
    public AnimationUI GetAnimationUI;
    public GameObject btnRace, btnFootBall;
    // Start is called before the first frame update
    void Start()
    {
       // GetAnimationUI.StartIPPnlActive();
        bool bIP = PlayerPrefs.HasKey("ip");
        Debug.Log(bIP);
        if (!bIP)
        {

        }
        else
        {
            inputIP = PlayerPrefs.GetString("ip");
            inputPort = PlayerPrefs.GetString("port");
            txtIP.text = inputIP;   
            txtPort.text = inputPort;   
        }


    }

    // Update is called once per frame
    void Update()
    {
        ButtonCheck();
    }

    public void ButtonCheck()
    {
        if (txtIP.text.Length > 1&&txtPort.text.Length>1)
        {
            
        }
        if(txtIP.text.Length == 0 || txtPort.text.Length == 0)
        {
            btnConnect.interactable = false;
        }
        else
        {
            btnConnect.interactable = true;
        }

        if (GetClient.connect)
        {
            btnStart.interactable = true;
        }
        else
        {
            btnStart.interactable = false;
        }

       
    }

    public void ConnectServer()
    {

        GetClient.ConnectToTcpServer();
        GetClient.ip= txtIP.text;

        int.TryParse(txtPort.text, out GetClient.port);
        PlayerPrefs.SetString("ip", txtIP.text);
        PlayerPrefs.SetString ("port", txtPort.text);   
    }

    public void StartMenu()
    {
        GetAnimationUI.StartIPPnlDisactive();
        btnRace.GetComponent<BoxCollider2D>().enabled = true;
        btnFootBall.GetComponent<BoxCollider2D>().enabled = true;
    }


}

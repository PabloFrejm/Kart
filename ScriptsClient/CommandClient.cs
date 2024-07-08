using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CommandClient: MonoBehaviour
{
    public Client GetClient;
    public float currentTime;
    public bool startGame;
  
    public setTimerReloadFootball GetReloadFootball;
    public setTimerReloadRace GetReloadRace;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      recieveCommand(); 
    }

    public void recieveCommand()
    {
        if (startGame)
        {
            var command = GetClient.serverMessage;

            if (command == "Cart" + float.TryParse(command, out _))
            {
                string[] t = StartGame.GameCommand.Split(';');
                int.TryParse(t[1], out Cart.count);
            }
        }
    }

    public void SendCommandRace()                { GetClient.SendMessage("Race"); }
    public void SendCommandFootBall()            { GetClient.SendMessage("Football"); }
    public void SendCommandStartRace()           { GetClient.SendMessage("StartRace"); }
    public void SendCommandStartFootBall()       { GetClient.SendMessage("StartFootBall"); }
    public void SendCommandStopRace()            { GetClient.SendMessage("StopRace"); }
    public void SendCommandStopFootBall()        { GetClient.SendMessage("StopFootBall" ); }
    public void SendCommandPauseRace()           { GetClient.SendMessage("PauseRace"); }
    public void SendCommandPauseFootBall()       { GetClient.SendMessage("PauseFootBall"); }
    public void SendCommandUnPauseRace()         { GetClient.SendMessage("UnPauseRace"); }
    public void SendCommandUnPauseFootBall()     { GetClient.SendMessage("UnPauseFootBall"); }
    public void SendCommandTimeReloadRace()      { GetClient.SendMessage("TimeReloadRace;" + GetReloadRace.reloadTime); }
    public void SendCommandTimeReloadFootBall()  { GetClient.SendMessage("TimeReloadFootBall;" + GetReloadFootball.reloadTime); }
    public void SendCommandMapCount(int mapCount)            { GetClient.SendMessage("MapCount;" + mapCount); }
}

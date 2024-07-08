using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using UnityEngine;

public class Client : MonoBehaviour
{
   
    private TcpClient socketConnection;
    private Thread clientReceiveThread;
    public AnimationUI GetAnimationUI;
    public bool connect, c;
    public string ip;
    NetworkStream stream;
  

    public int port;
    public string serverMessage;
    public float serverMessage4;
    public List<string> data = new List<string>();
    public bool hex;
    public string msg;
    public float pos;
    public double doubleVal;
    public Int64 int64Val;
    public int p;
    // Use this for initialization 	
    void Start()
    {
       // ConnectToTcpServer();
    }
    // Update is called once per frame
    void Update()
    {
        

       
        if (socketConnection != null)
        {
            connect = socketConnection.Connected;

        }
        if(!connect)
        {
            GetAnimationUI.StartIPPnlActive();  
        }
       

    }
    /// <summary> 	
    /// Setup socket connection. 	
    /// </summary> 	
    public void ConnectToTcpServer()
    {
        try
        {

            clientReceiveThread = new Thread(new ThreadStart(ListenForData));
            clientReceiveThread.IsBackground = true;
            clientReceiveThread.Start();
           
        }
        catch (Exception e)
        {
           
             socketConnection.Close(); 
                // connect = false;
                Debug.Log("On client connect exception " + e);
        }
    }
    /// <summary> 	
    /// Runs in background clientReceiveThread; Listens for incomming data. 	
    /// </summary>     
    private void ListenForData()
    {
        try
        {
            socketConnection = new TcpClient(ip, port);
           

            Byte[] bytes = new Byte[1024];
            while (true)
            {
               		
                 stream = socketConnection.GetStream();
              
                

                    int length;
                    // Read incomming stream into byte arrary. 					
                    while ((length = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        var incommingData = new byte[length];
                        Array.Copy(bytes, 0, incommingData, 0, length);
                     // Convert byte array to string message. 						
                    //  
                     // serverMessage=Encoding.Unicode.GetString(incommingData);
                        string t = BitConverter.ToString(incommingData);
                        string newT = t.Substring(0, 2);
                       Debug.Log(newT);
                    
                    
                    if (newT == "65")
                       
                    {
                      
                        serverMessage = BitConverter.ToString(incommingData, 25);
                        doubleVal = BitConverter.ToDouble(incommingData, 9);
                       

                    }
                        

                     

                }
                
            } 

        }
        catch (SocketException socketException)
        {
           


            Debug.Log("Socket exception: 23" + socketException);
        }
    }
    /// <summary> 	
    /// Send message to server using socket connection. 	
    /// </summary> 	
    public new void SendMessage(string msg)
    {
        if (socketConnection == null)
        {
            return;
        }
        try
        {
            // Get a stream object for writing. 			
            NetworkStream stream = socketConnection.GetStream();
            if (stream.CanWrite)
            {
               // string clientMessage = "This is a message from one of your clients.";
                // Convert string message to byte array.                 
                byte[] clientMessageAsByteArray = Encoding.ASCII.GetBytes(msg);
                // Write byte array to socketConnection stream.                 
                stream.Write(clientMessageAsByteArray, 0, clientMessageAsByteArray.Length);
                Debug.Log("Client sent his message - should be received by server");
            }
        }
        catch (SocketException socketException)
        {
            Debug.Log("Socket exception: " + socketException);
        }
    }

    public void closeN()
    {
        if (socketConnection != null)
        {
            if (!stream.CanWrite)
            {
                stream.Close();
            }
        }
    }


    public void ConvertHexToPosition()
    {

        

    }
}
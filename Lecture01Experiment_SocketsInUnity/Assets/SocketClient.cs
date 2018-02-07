using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


using System;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;
using System.Threading;
public class SocketClient : MonoBehaviour {
    Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

    IPEndPoint ipLocal = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9235);

    bool connected = false;

    public Text textBox;
    public Text debugLog;

    int ID = 0;
    float startTimeDelta = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        startTimeDelta += Time.deltaTime;
		if(connected == false)
        {
            try
            {
                s.Connect(ipLocal);
                connected = true;
                Thread.Sleep(1000);
            }
            catch (Exception)
            {
                Thread.Sleep(1000);
            }
        }
        

        if(connected)
        {
            int dataToSend = (int)startTimeDelta;
            String msg =  dataToSend.ToString();
            ID++;
            ASCIIEncoding encoder = new ASCIIEncoding();
            byte[] buffer = encoder.GetBytes(msg);
            
            try
            {
                textBox.text = msg;
                int bytesSent = s.Send(buffer);
            }
            catch(System.Exception e)
            {
                Debug.Log(e);
            }

            Thread.Sleep(1000);
        }
        
	}
}

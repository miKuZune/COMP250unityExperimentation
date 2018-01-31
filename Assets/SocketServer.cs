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


public class SocketServer : MonoBehaviour {

    Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

    IPEndPoint ipLocal = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9235);

    public Text textBox;
    public Text debugBox;

    Socket newConnection;

    bool connected = false;

    // Update is called once per frame
    void Update () {
        if(!connected)
        {
            s.Bind(ipLocal);
            s.Listen(4);
            textBox.text = "Waiting for client ...";

            newConnection = s.Accept();
            connected = true;
        }
        else
        {
            byte[] buffer = new byte[4096];

            try
            {
                int result = newConnection.Receive(buffer);
                if (result > 0)
                {
                    ASCIIEncoding encoder = new ASCIIEncoding();
                    String recdMsg = encoder.GetString(buffer, 0, result);
                    textBox.text = "Recieved: " + recdMsg;
                    Debug.Log(recdMsg);
                }
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net.Sockets;
using System.Text;

public class UDPSender : MonoBehaviour
{
    // broadcast address
    public string host = "127.0.0.1"; // change host
    public int port = 3333;
    private UdpClient client;

    void Start()
    {
        client = new UdpClient();
        client.Connect(host, port);
    }

    void Update() // for debug
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)) { // vibe 0.5sec
            UDPSend(1);
        } else if(Input.GetKeyDown(KeyCode.Alpha2)) { // vibe 2sec
            UDPSend(2);
        } else if(Input.GetKeyDown(KeyCode.Alpha3)) { // solenoid
            UDPSend(3);
        }
    }

    
    void OnApplicationQuit()
    {
        client.Close();
    }

    public void UDPSend(int mode = 0) {
        /*
        0: undefined
        1: vibe 0.5sec
        2: vibe 2.0sec
        3: solenoid
        */
        byte[] dgram = Encoding.UTF8.GetBytes(mode.ToString());
        client.Send(dgram, dgram.Length);
    }
}

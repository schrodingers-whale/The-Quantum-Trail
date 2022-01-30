using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

// namespace Client {
    
//     class Program {

//         static void Main(string[] args)
//         {
//             ExecuteClient();
//         }

//         static void ExecuteClient()
//         {
//             try{
//                 //Establish the remote endpoint
//                 //for the socket. This example
//                 //uses port 25001 on the localhost
//                 IPHostEntry iphost = Dns.GetHostEntry(DNs.GetHostName());
//                 IPAdress ipAddr = ipHost.AddressList[0];
//                 IPEndPoint localEndPoint = new 
//             }
//         }
//     }
// }

public class InputControlScript : MonoBehaviour
{

    private InputField input;

    void Awake() {
        input = GameObject.Find ("InputField").GetComponent<InputField>();
    }
    public void GetInput(string gate) {
        Debug.Log("Entered Input: " + gate);
        input.text = ""; 
    }
}

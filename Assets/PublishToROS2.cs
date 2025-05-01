using UnityEngine;
using Unity.Robotics.ROSTCPConnector;
using RosMessageTypes.Std;
using UnityEngine.Rendering;
using System;

public class TestPublisher : MonoBehaviour
{
    ROSConnection ros;

    void Start()
    {
        ros = ROSConnection.GetOrCreateInstance();
        // Explicitly set the ROS IP and Port in Unity
        //ros.RosIPAddress = "127.0.0.1"; // Set this to your ROS2 VM's IP address
        //ros.RosPort = 10000; // The default port for ROS TCP Connector
        ros.RegisterPublisher<StringMsg>("/unity_to_ros"); //topic that will publish to; echo this topic and will see messages
    }




    void Update()
    {    
        float moveDirection = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StringMsg msg = new StringMsg("Hello from Unity!");
            ros.Publish("/unity_to_ros", msg); //send message to topic
            Debug.Log("Sent message to ROS2");
        }

        if (Convert.ToBoolean(moveDirection))
        {
            StringMsg msg2 = new StringMsg(Convert.ToString(moveDirection));
            ros.Publish("/unity_to_ros", msg2); //send message to topic
            Debug.Log("Sent move direction to ros");
        }
    }
}
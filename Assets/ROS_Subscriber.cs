//using UnityEngine;
//using Unity.Robotics.ROSTCPConnector;
//using RosMessageTypes.Franka;

//public class ROSSubscriber : MonoBehaviour
//{
//    ROSConnection ros;
//    public string topicName = "/abc"; // The topic to subscribe to; call this in ros2 terminal

//    void Start()
//    {
//        ros = ROSConnection.GetOrCreateInstance();
//        ros.Subscribe<FrankaRobotStateMsg>(topicName, ReceiveMessage);
//        Debug.Log("Subscribed to topic: " + topicName);
//    }

//    private void ReceiveMessage(FrankaRobotStateMsg msg)
//    {
//        double[] P = msg.measured_joint_state.position;
//        Debug.Log("Received message: " + msg.measured_joint_state.ToString()); //read data from ros2
//    }
//}
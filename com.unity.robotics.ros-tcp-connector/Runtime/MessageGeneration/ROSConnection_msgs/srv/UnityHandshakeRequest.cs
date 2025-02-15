//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using RosMessageGeneration;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.RosTcpEndpoint
{
    public class UnityHandshakeRequest : Message
    {
        public const string RosMessageName = "ros_tcp_endpoint/UnityHandshake";

        public string ip;
        public ushort port;

        public UnityHandshakeRequest()
        {
            this.ip = "";
            this.port = 0;
        }

        public UnityHandshakeRequest(string ip, ushort port)
        {
            this.ip = ip;
            this.port = port;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.Add(SerializeString(this.ip));
            listOfSerializations.Add(BitConverter.GetBytes(this.port));

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            var ipStringBytesLength = DeserializeLength(data, offset);
            offset += 4;
            this.ip = DeserializeString(data, offset, ipStringBytesLength);
            offset += ipStringBytesLength;
            this.port = BitConverter.ToUInt16(data, offset);
            offset += 2;

            return offset;
        }

        public override string ToString()
        {
            return "UnityHandshakeRequest: " +
            "\nip: " + ip.ToString() +
            "\nport: " + port.ToString();
        }
    }
}

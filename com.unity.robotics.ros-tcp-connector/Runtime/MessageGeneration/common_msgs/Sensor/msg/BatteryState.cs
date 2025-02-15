//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using RosMessageGeneration;
using RosMessageTypes.Std;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Sensor
{
    public class BatteryState : Message
    {
        public const string RosMessageName = "sensor_msgs/BatteryState";

        //  Constants are chosen to match the enums in the linux kernel
        //  defined in include/linux/power_supply.h as of version 3.7
        //  The one difference is for style reasons the constants are
        //  all uppercase not mixed case.
        //  Power supply status constants
        public const byte POWER_SUPPLY_STATUS_UNKNOWN = 0;
        public const byte POWER_SUPPLY_STATUS_CHARGING = 1;
        public const byte POWER_SUPPLY_STATUS_DISCHARGING = 2;
        public const byte POWER_SUPPLY_STATUS_NOT_CHARGING = 3;
        public const byte POWER_SUPPLY_STATUS_FULL = 4;
        //  Power supply health constants
        public const byte POWER_SUPPLY_HEALTH_UNKNOWN = 0;
        public const byte POWER_SUPPLY_HEALTH_GOOD = 1;
        public const byte POWER_SUPPLY_HEALTH_OVERHEAT = 2;
        public const byte POWER_SUPPLY_HEALTH_DEAD = 3;
        public const byte POWER_SUPPLY_HEALTH_OVERVOLTAGE = 4;
        public const byte POWER_SUPPLY_HEALTH_UNSPEC_FAILURE = 5;
        public const byte POWER_SUPPLY_HEALTH_COLD = 6;
        public const byte POWER_SUPPLY_HEALTH_WATCHDOG_TIMER_EXPIRE = 7;
        public const byte POWER_SUPPLY_HEALTH_SAFETY_TIMER_EXPIRE = 8;
        //  Power supply technology (chemistry) constants
        public const byte POWER_SUPPLY_TECHNOLOGY_UNKNOWN = 0;
        public const byte POWER_SUPPLY_TECHNOLOGY_NIMH = 1;
        public const byte POWER_SUPPLY_TECHNOLOGY_LION = 2;
        public const byte POWER_SUPPLY_TECHNOLOGY_LIPO = 3;
        public const byte POWER_SUPPLY_TECHNOLOGY_LIFE = 4;
        public const byte POWER_SUPPLY_TECHNOLOGY_NICD = 5;
        public const byte POWER_SUPPLY_TECHNOLOGY_LIMN = 6;
        public Header header;
        public float voltage;
        //  Voltage in Volts (Mandatory)
        public float temperature;
        //  Temperature in Degrees Celsius (If unmeasured NaN)
        public float current;
        //  Negative when discharging (A)  (If unmeasured NaN)
        public float charge;
        //  Current charge in Ah  (If unmeasured NaN)
        public float capacity;
        //  Capacity in Ah (last full capacity)  (If unmeasured NaN)
        public float design_capacity;
        //  Capacity in Ah (design capacity)  (If unmeasured NaN)
        public float percentage;
        //  Charge percentage on 0 to 1 range  (If unmeasured NaN)
        public byte power_supply_status;
        //  The charging status as reported. Values defined above
        public byte power_supply_health;
        //  The battery health metric. Values defined above
        public byte power_supply_technology;
        //  The battery chemistry. Values defined above
        public bool present;
        //  True if the battery is present
        public float[] cell_voltage;
        //  An array of individual cell voltages for each cell in the pack
        //  If individual voltages unknown but number of cells known set each to NaN
        public float[] cell_temperature;
        //  An array of individual cell temperatures for each cell in the pack
        //  If individual temperatures unknown but number of cells known set each to NaN
        public string location;
        //  The location into which the battery is inserted. (slot number or plug)
        public string serial_number;
        //  The best approximation of the battery serial number

        public BatteryState()
        {
            this.header = new Header();
            this.voltage = 0.0f;
            this.temperature = 0.0f;
            this.current = 0.0f;
            this.charge = 0.0f;
            this.capacity = 0.0f;
            this.design_capacity = 0.0f;
            this.percentage = 0.0f;
            this.power_supply_status = 0;
            this.power_supply_health = 0;
            this.power_supply_technology = 0;
            this.present = false;
            this.cell_voltage = new float[0];
            this.cell_temperature = new float[0];
            this.location = "";
            this.serial_number = "";
        }

        public BatteryState(Header header, float voltage, float temperature, float current, float charge, float capacity, float design_capacity, float percentage, byte power_supply_status, byte power_supply_health, byte power_supply_technology, bool present, float[] cell_voltage, float[] cell_temperature, string location, string serial_number)
        {
            this.header = header;
            this.voltage = voltage;
            this.temperature = temperature;
            this.current = current;
            this.charge = charge;
            this.capacity = capacity;
            this.design_capacity = design_capacity;
            this.percentage = percentage;
            this.power_supply_status = power_supply_status;
            this.power_supply_health = power_supply_health;
            this.power_supply_technology = power_supply_technology;
            this.present = present;
            this.cell_voltage = cell_voltage;
            this.cell_temperature = cell_temperature;
            this.location = location;
            this.serial_number = serial_number;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.AddRange(header.SerializationStatements());
            listOfSerializations.Add(BitConverter.GetBytes(this.voltage));
            listOfSerializations.Add(BitConverter.GetBytes(this.temperature));
            listOfSerializations.Add(BitConverter.GetBytes(this.current));
            listOfSerializations.Add(BitConverter.GetBytes(this.charge));
            listOfSerializations.Add(BitConverter.GetBytes(this.capacity));
            listOfSerializations.Add(BitConverter.GetBytes(this.design_capacity));
            listOfSerializations.Add(BitConverter.GetBytes(this.percentage));
            listOfSerializations.Add(new[]{this.power_supply_status});
            listOfSerializations.Add(new[]{this.power_supply_health});
            listOfSerializations.Add(new[]{this.power_supply_technology});
            listOfSerializations.Add(BitConverter.GetBytes(this.present));
            
            listOfSerializations.Add(BitConverter.GetBytes(cell_voltage.Length));
            foreach(var entry in cell_voltage)
                listOfSerializations.Add(BitConverter.GetBytes(entry));
            
            listOfSerializations.Add(BitConverter.GetBytes(cell_temperature.Length));
            foreach(var entry in cell_temperature)
                listOfSerializations.Add(BitConverter.GetBytes(entry));
            listOfSerializations.Add(SerializeString(this.location));
            listOfSerializations.Add(SerializeString(this.serial_number));

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            offset = this.header.Deserialize(data, offset);
            this.voltage = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.temperature = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.current = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.charge = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.capacity = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.design_capacity = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.percentage = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.power_supply_status = data[offset];;
            offset += 1;
            this.power_supply_health = data[offset];;
            offset += 1;
            this.power_supply_technology = data[offset];;
            offset += 1;
            this.present = BitConverter.ToBoolean(data, offset);
            offset += 1;
            
            var cell_voltageArrayLength = DeserializeLength(data, offset);
            offset += 4;
            this.cell_voltage= new float[cell_voltageArrayLength];
            for(var i = 0; i < cell_voltageArrayLength; i++)
            {
                this.cell_voltage[i] = BitConverter.ToSingle(data, offset);
                offset += 4;
            }
            
            var cell_temperatureArrayLength = DeserializeLength(data, offset);
            offset += 4;
            this.cell_temperature= new float[cell_temperatureArrayLength];
            for(var i = 0; i < cell_temperatureArrayLength; i++)
            {
                this.cell_temperature[i] = BitConverter.ToSingle(data, offset);
                offset += 4;
            }
            var locationStringBytesLength = DeserializeLength(data, offset);
            offset += 4;
            this.location = DeserializeString(data, offset, locationStringBytesLength);
            offset += locationStringBytesLength;
            var serial_numberStringBytesLength = DeserializeLength(data, offset);
            offset += 4;
            this.serial_number = DeserializeString(data, offset, serial_numberStringBytesLength);
            offset += serial_numberStringBytesLength;

            return offset;
        }

        public override string ToString()
        {
            return "BatteryState: " +
            "\nheader: " + header.ToString() +
            "\nvoltage: " + voltage.ToString() +
            "\ntemperature: " + temperature.ToString() +
            "\ncurrent: " + current.ToString() +
            "\ncharge: " + charge.ToString() +
            "\ncapacity: " + capacity.ToString() +
            "\ndesign_capacity: " + design_capacity.ToString() +
            "\npercentage: " + percentage.ToString() +
            "\npower_supply_status: " + power_supply_status.ToString() +
            "\npower_supply_health: " + power_supply_health.ToString() +
            "\npower_supply_technology: " + power_supply_technology.ToString() +
            "\npresent: " + present.ToString() +
            "\ncell_voltage: " + System.String.Join(", ", cell_voltage.ToList()) +
            "\ncell_temperature: " + System.String.Join(", ", cell_temperature.ToList()) +
            "\nlocation: " + location.ToString() +
            "\nserial_number: " + serial_number.ToString();
        }
    }
}

﻿using Newtonsoft.Json;
using System;


namespace PlacePodApiClient.Models {

    /// <summary>
    /// Represents an event reported up to the cloud from the PlacePod.
    /// </summary>
    internal class SensorHistoryLog {

        /// <summary>
        /// Placepod Sensor ID from the barcode.
        /// </summary>
        [JsonProperty("sensorId")]
        public string SensorId { get; set; }

        /// <summary>
        /// Internal counter that represents the number of uplink packets that the PlacePod has sent.
        /// </summary>
        [JsonProperty("packetCounter")]
        public int PacketCounter { get; set; }

        /// <summary>
        /// What type of mode the sensor reports. Currently two possibilities:
        ///     - CarPresence
        ///     - CarCounter
        /// </summary>
        [JsonProperty("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// String representation of the value of CarPresence.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// State of sensor. Only valid if mode is "CarPresence". Possibilities:
        /// -2      =   Error
        /// -1/null =   Sensor doesn't have car presence.
        /// 0       = 	Initialization/startup
        /// 1       = 	No Car Present (vacant)
        /// 2       = 	Car Entering Space
        /// 3       = 	Parked Car Detected (occupied)
        /// 4       = 	Car Leaving Space
        /// 10      =    Recalibrating
        /// </summary>
        [JsonProperty("carPresence")]
        public int? CarPresence { get; set; }

        /// <summary>
        /// Current number of cars that have passed the sensor. Only valid if mode is "CarCounter".
        /// </summary>
        [JsonProperty("carCounter")]
        public int? CarCounter { get; set; }

        /// <summary>
        /// Was the log a keep alive message?
        /// </summary>
        [JsonProperty("keepAlive")]
        public bool KeepAlive { get; set; }

        /// <summary>
        /// Time Event was received UTC.
        /// </summary>
        [JsonProperty("serverTime")]
        public DateTime? ServerTime { get; set; }

        /// <summary>
        /// Time from gateway. This may not be accurate since gateway may have clock skew and/or incorrect time settings.
        /// </summary>
        [JsonProperty("gatewayTime")]
        public DateTime? GatewayTime { get; set; }

        /// <summary>
        /// Time from Sentral coprocessor in ticks.
        /// </summary>
        [JsonProperty("sentralTime")]
        public UInt32 SentralTime { get; set; }

        /// <summary>
        /// Sensor's current RSSI (received signal strength indication) status.
        /// </summary>
        [JsonProperty("rssi")]
        public double Rssi { get; set; }

        /// <summary>
        /// Sensor's current SNR (signal-to-noise ratio) status.
        /// </summary>
        [JsonProperty("snr")]
        public double Snr { get; set; }

        /// <summary>
        /// Temperature in celcius.
        /// </summary>
        [JsonProperty("temperature")]
        public double Temperature { get; set; }

        /// <summary>
        /// Battery Voltage.
        /// </summary>
        [JsonProperty("battery")]
        public double Battery { get; set; }
    }
}

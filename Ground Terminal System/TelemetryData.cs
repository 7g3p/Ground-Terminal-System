using System;
using System.Collections.Generic;
using System.Text;

namespace Ground_Terminal_System
{
    public class TelemetryData
    {
        public string aircraftTailNumber { get; set; }
        public DateTime timestamp { get; set; }
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }
        public double weight { get; set; }
        public double altitude { get; set; }
        public double pitch { get; set; }
        public double bank { get; set; }

        public TelemetryData(string atNum, DateTime ts, double _x, double _y, double _z, double w, double alt, double p, double b)
        {
            aircraftTailNumber = atNum;
            timestamp = ts;
            x = _x;
            y = _y;
            z = _z;
            weight = w;
            altitude = alt;
            pitch = p;
            bank = b;
        }
    }
}

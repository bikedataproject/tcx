﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TCX.Domain
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "HeartRateInBeatsPerMinute_t")]
    public class HeartRateInBeatsPerMinute : HeartRateValue
    {
        /// <remarks/>
        public byte Value { get; set; }
    }
}
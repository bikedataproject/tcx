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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "SpeedType_t")]
    public enum SpeedType
    {
        /// <remarks/>
        Pace,
        /// <remarks/>
        Speed,
    }
}

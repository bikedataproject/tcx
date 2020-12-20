using System;
using System.IO;
using System.Xml.Serialization;
using TCX.Domain;

namespace TCX
{
    public static class Parser
    {
        public static TrainingCenterDatabase Parse(Stream file)
        {
            var serializer = new XmlSerializer(typeof(TrainingCenterDatabase));
            return serializer.Deserialize(file) as TrainingCenterDatabase;
        }

        public static TrainingCenterDatabase Parse(string tcx)
        {
            var serializer = new XmlSerializer(typeof(TrainingCenterDatabase));
            using var reader = new StringReader(tcx);
            return serializer.Deserialize(reader) as TrainingCenterDatabase;
        }
    }
}

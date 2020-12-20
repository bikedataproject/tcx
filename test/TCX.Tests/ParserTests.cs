using Xunit;

namespace TCX.Tests
{
    public class ParserTests
    {
        [Fact]
        public void Parser_Parse_String1_ShouldContainTrack()
        {
            var tcx = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>\r\n<TrainingCenterDatabase xmlns=\"http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2\">\r\n    <Activities>\r\n        <Activity Sport=\"Biking\">\r\n            <Id>2020-11-14T14:46:02.000+01:00</Id>\r\n            <Lap StartTime=\"2020-11-14T14:46:02.000+01:00\">\r\n                <TotalTimeSeconds>2834.0</TotalTimeSeconds>\r\n                <DistanceMeters>27681.420000000002</DistanceMeters>\r\n                <Calories>584</Calories>\r\n                <Intensity>Active</Intensity>\r\n                <TriggerMethod>Manual</TriggerMethod>\r\n                <Track>\r\n                    <Trackpoint>\r\n                        <Time>2020-11-14T14:46:02.000+01:00</Time>\r\n                        <Position>\r\n                            <LatitudeDegrees>51.266576647758484</LatitudeDegrees>\r\n                            <LongitudeDegrees>4.77831494808197</LongitudeDegrees>\r\n                        </Position>\r\n                        <AltitudeMeters>16.3</AltitudeMeters>\r\n                        <DistanceMeters>0.0</DistanceMeters>\r\n                    </Trackpoint>\r\n                    <Trackpoint>\r\n                        <Time>2020-11-14T14:46:03.000+01:00</Time>\r\n                        <Position>\r\n                            <LatitudeDegrees>51.26654493808746</LatitudeDegrees>\r\n                            <LongitudeDegrees>4.778298258781433</LongitudeDegrees>\r\n                        </Position>\r\n                        <AltitudeMeters>16.1</AltitudeMeters>\r\n                        <DistanceMeters>0.0</DistanceMeters>\r\n                    </Trackpoint>\r\n                    <Trackpoint>\r\n                        <Time>2020-11-14T14:46:04.000+01:00</Time>\r\n                        <Position>\r\n                            <LatitudeDegrees>51.26650655269623</LatitudeDegrees>\r\n                            <LongitudeDegrees>4.77828323841095</LongitudeDegrees>\r\n                        </Position>\r\n                        <AltitudeMeters>16.1</AltitudeMeters>\r\n                        <DistanceMeters>1.17</DistanceMeters>\r\n                    </Trackpoint>\r\n                </Track>\r\n            </Lap>\r\n            <Creator xsi:type=\"Device_t\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">\r\n                <UnitId>0</UnitId>\r\n                <ProductID>0</ProductID>\r\n            </Creator>\r\n        </Activity>\r\n    </Activities>\r\n</TrainingCenterDatabase>\r\n";
            
            var result = TCX.Parser.Parse(tcx);
            
            Assert.NotNull(result);
            Assert.NotNull(result.Activities);
            Assert.Single(result.Activities.Activity);
            Assert.NotNull(result.Activities.Activity[0]);
            Assert.NotNull(result.Activities.Activity[0].Lap);
            Assert.Single(result.Activities.Activity[0].Lap);
            Assert.NotNull(result.Activities.Activity[0].Lap[0]);
            Assert.NotNull(result.Activities.Activity[0].Lap[0].Track);
            Assert.True(result.Activities.Activity[0].Lap[0].Track.Count > 2);
        }
    }
}
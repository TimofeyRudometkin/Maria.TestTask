using FluentAssertions;
using Maria.TestTask.MeasurementPlanner.Model;
using Maria.TestTask.MeasurementPlanner.UI.Data;
using Xunit;

namespace Maria.TestTask.MeasurementPlanner.UI.Tests
{
    public class MeasurementRepository_Test
    {
        [Fact]
        public void GetAll_Success_AsExpected()
        {
            var sut = new MeasurementRepository();

            var actual = sut.GetAll();

            actual.Should().BeOfType<Measuring>();
        }
    }
}

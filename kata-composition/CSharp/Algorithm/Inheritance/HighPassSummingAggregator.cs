using System.Collections.Generic;
using System.Linq;

namespace Algorithm.Inheritance
{
    /// <summary>
    /// Should filter out measurements with an X or Y that are less than or equal to 2
    /// You'll need to inherit and override methods from other classes in the inheritance folder
    /// </summary>
    public class HighPassSummingAggregator : SummingAggregator
    {
        protected override IEnumerable<Measurement> FilterMeasurements(IEnumerable<Measurement> measurements) 
            => measurements.Where(m => m.X > 2 && m.Y > 2);

        public HighPassSummingAggregator(IEnumerable<Measurement> measurements) : base(measurements)
        {
        }
    }    
}
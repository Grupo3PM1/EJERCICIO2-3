using System;
using System.Collections.Generic;
using System.Text;

namespace PM02RestApi.Models
{
    public class LatLongcs
    {
        public class Example
        {
            public IList<double> latlng { get; set; }

            public static implicit operator double(Example v)
            {
                throw new NotImplementedException();
            }
        }

    }
}

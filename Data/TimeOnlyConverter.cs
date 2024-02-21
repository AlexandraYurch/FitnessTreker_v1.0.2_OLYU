using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessTreker_v1._0._2_OLYU.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FitnessTreker_v1._0._2_OLYU.Data
{
    public class TimeOnlyConverter : ValueConverter<TimeOnly, TimeSpan>
    {
        public TimeOnlyConverter() : base(
        timeOnly => timeOnly.ToTimeSpan(),
        timeSpan => TimeOnly.FromTimeSpan(timeSpan))
        { }
    }
}

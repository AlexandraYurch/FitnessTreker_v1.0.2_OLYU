// See https://aka.ms/new-console-template for more information
using FitnessTreker_v1._0._2_OLYU.Data;
using FitnessTreker_v1._0._2_OLYU.Models;
using System.Diagnostics;

Console.WriteLine("Hello, World!");
using (var context = new Gym())
{
    var std = new Schedule()
    {
        
        Date = DateTime.Parse("01/06/2024"),
        StartEndWH = DateTime.Parse("01/06/2024 09:00 AM")


    };
    context.Schedules.Add(std);

    // or
    // context.Add<Student>(std);

    context.SaveChanges();
}


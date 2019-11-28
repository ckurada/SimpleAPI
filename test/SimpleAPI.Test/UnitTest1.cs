using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
       
       WeatherForecastController controller = new WeatherForecastController();

       [Fact]
       public void GetReturnsAnArray()
       {
        var returnValue = controller.Get();
        Assert.True(returnValue != null);
       }
    }
}

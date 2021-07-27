using System;
using Xunit;

namespace ToyRobot.UnitTests
{
    public class RobotTests
    {
        [Fact]
        public void Robot_Report_0_1_N_AfterPlaced_0_0_N_AndSingleMove()
        {
            //arrange
            Robot robot = new Robot();
            //act
            string result = robot.command("PLACE 0,0,NORTH");
            result = robot.command("MOVE");
            result = robot.command("REPORT");
            //assert
            Assert.Equal("0,1,NORTH", result);
        }

    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RoverTests
{
    [TestClass]
    public class RoverShould
    {
        private Rover rover;

        public RoverShould()
        {
            rover = new Rover();
        }

        [TestMethod]
        [DataRow("R", "0:0:E")]
        [DataRow("RR", "0:0:S")]
        [DataRow("RRR", "0:0:W")]
        [DataRow("RRRR", "0:0:N")]

        public void rotate_right(string command, string position)
        {
            Assert.AreEqual(rover.Execute(command) , position);
        }

        [TestMethod]
        [DataRow("L", "0:0:W")]
        [DataRow("LL", "0:0:S")]
        [DataRow("LLL", "0:0:E")]
        [DataRow("LLLL", "0:0:N")]

        public void rotate_left(string command, string position)
        {
            Assert.AreEqual(rover.Execute(command), position);
        }
        [TestMethod]
        [DataRow("M", "0:1:N")]
        [DataRow("MM", "0:2:N")]
        public void move_forward(string command, string position)
        {
            Assert.AreEqual(rover.Execute(command), position);
        }

        [TestMethod]
        [DataRow("RM", "1:0:E")]
        [DataRow("RMLMMM", "1:3:N")]
        public void rotate_move_forward(string command, string position)
        {
            Assert.AreEqual(rover.Execute(command), position);
        }
    }
}
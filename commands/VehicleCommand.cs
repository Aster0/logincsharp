
using GTANetworkAPI;
class VehicleCommand {

       [Command] // Don't forget to add the Command Attribute
        public static void TestCmd(Player sender) // Method must be static!
        {
            NAPI.Util.ConsoleOutput("TestCommand Invoked!");
        }
}
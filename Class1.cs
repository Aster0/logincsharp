using System;
using GTANetworkAPI;


namespace login
{
    public class Class1 : Script
    {
        public Class1()
        {
            new FileManager();

      

   
        }

        [RemoteEvent("onPlayerJoin")]
        public void onPlayerJoin(Player player, string username, string password)
        {
     

            if(FileManager.getMap().ContainsKey(password)) // login successfully
            {
                if(FileManager.getMap()[password].getUsername() == username) // check if correct username
                {
                    player.TriggerEvent("loginResults", 1); // send to client that login is successfully
                }
                else
                    player.TriggerEvent("loginResults", 0); // send to client that login is unsuccessful
              
            }
            else
            {
                player.TriggerEvent("loginResults", 0); // send to client that login is unsuccessful
            }

       
        }

        [ServerEvent(Event.ChatMessage)]
        public void OnChatMessage(Player player, string message)
        {
            if(message.StartsWith("spawnVeh"))
            {
                Console.WriteLine("spawning");
                VehicleHash veh = NAPI.Util.VehicleNameToModel("CHIMERA");
                NAPI.Vehicle.CreateVehicle(veh, player.Position, 0, 0, 0, "Om4n3k");
            }
        }

        [Command("spawnveh", "~b~/spawnveh ~w~[vehicle]")]
        public void spawnVehicle(Player player, string vehicle)
        {
                Console.WriteLine("spawning");
                VehicleHash veh = NAPI.Util.VehicleNameToModel(vehicle);
                NAPI.Vehicle.CreateVehicle(veh, player.Position, 0, 0, 0, "Om4n3k");
        }

        [Command("despawnveh")]
        public void despawnVehicle(Player player)
        {
            

              

                foreach (Vehicle vehicle in NAPI.Pools.GetAllVehicles())
                {
                     vehicle.Delete();
                }
        }

        

        



     
        
            
    }

    
}
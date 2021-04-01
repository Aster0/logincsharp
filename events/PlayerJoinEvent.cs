
using GTANetworkAPI;
using System;


namespace Events  {

    class PlayerJoinEvent {


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
        
}

}

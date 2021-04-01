
using System;
using System.Collections.Generic;

class FileManager
{
    static private Dictionary<string, User> map =
                new Dictionary<string, User>();

    static public Dictionary<string, User> getMap()
    {
        return map; 
    }
    public FileManager()
    {
        string lines = System.IO.File.ReadAllText(@"dotnet/resources/login/login_details.json");


        parseJsonToMap(lines);




       
    }


    private void parseJsonToMap(String lines)
    {
        

            Console.WriteLine(lines);

            foreach(string line in lines.Replace("{","").Replace("}","").Replace("\"", "").Split(", "))
            {

                string username = line.Split(" : ")[0];
                string password = line.Split(" : ")[1];

               
                User user = new User(username, password);

                map.Add(password, user); // save password as identifier
            }

    




            
    }
}
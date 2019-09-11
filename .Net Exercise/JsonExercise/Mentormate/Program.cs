using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Mentormate
{
    class NBAPlayer
    {
        public NBAPlayer(string name, int playingSince, string posiiton, int rating)
        {
            this.Name = name;
            this.PlayingSince = playingSince;
            this.Position = posiiton;
            this.Rating = rating;
        }
        public string Name { get; set; }
        public int PlayingSince { get; set; }
        public string Position { get; set; }
        public int Rating { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Add all NBAPlayers
            List<NBAPlayer> allNbaPlayer = new List<NBAPlayer>();
            allNbaPlayer.Add(new NBAPlayer("Luka Doncic", 2018, "SG", 87));
            allNbaPlayer.Add(new NBAPlayer("Thomas Welsh", 2018, "C", 67));
            allNbaPlayer.Add(new NBAPlayer("Trae Young", 2018, "PG", 84));
            allNbaPlayer.Add(new NBAPlayer("Stephen Curry", 2009, "PG", 95));
            allNbaPlayer.Add(new NBAPlayer("Giannis Antetokounmpo", 2012, "SF", 96));
            allNbaPlayer.Add(new NBAPlayer("Jayson Tatum", 2017, "SF", 84));
            allNbaPlayer.Add(new NBAPlayer("LeBron James", 2003, "SF", 96));


            string filepath = @"..\..\..\..\nbaplayers.json";
            // Create new json file 
            CreateJsonFile(filepath, allNbaPlayer);

            allNbaPlayer.Clear();
            ReadJsonFile(filepath);
        }
        public static void ReadJsonFile(string filepath)
        {
            int maximumYearForQualified = 2014;
            int minimumRating = 80;

            string pathForNewFile = @"..\..\..\..\newNbaPlayer.txt.txt";

            string json = File.ReadAllText(filepath);
            var playerList = JsonConvert.DeserializeObject<List<NBAPlayer>>(json);
            var newPlayers = new List<NBAPlayer>();
            foreach (var item in playerList)
            {
                if (item.Rating >= minimumRating &&
                   item.PlayingSince >= maximumYearForQualified)
                {
                    newPlayers.Add(item);
                }
            }
            newPlayers.OrderByDescending(r => r.Rating);

            PrintReport(pathForNewFile, newPlayers);

        }
        public static void PrintReport(string pathForNewFile, List<NBAPlayer> newPlayers)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Name, Rating");
            foreach (var item in newPlayers)
            {
                string information = item.Name.ToString() + ", " + item.Rating.ToString();
                stringBuilder.AppendLine(information);

            }
            File.AppendAllText(pathForNewFile, stringBuilder.ToString());
        }
        public static void CreateJsonFile(string filepath, List<NBAPlayer> allNbaPlayer)
        {
            string JSONresult;
            int currIndex = 0;
            using (var streamWriter = new StreamWriter(filepath, true))
            {
                streamWriter.Write('[');
                foreach (var item in allNbaPlayer)
                {
                    if (currIndex != allNbaPlayer.Count - 1)
                    {
                        JSONresult = JsonConvert.SerializeObject(item);
                        streamWriter.WriteLine(JSONresult.ToString()+',');
                        currIndex++;
                    }
                    else {
                        JSONresult = JsonConvert.SerializeObject(item);
                        streamWriter.WriteLine(JSONresult.ToString());
                        streamWriter.Write(']');
                        streamWriter.Close();
                    }
                }
            }
        }
        public static void CheckJsonFileIsExist(string filepath, List<NBAPlayer> allNbaPlayer)
        {
            if (File.Exists(filepath))
            {
              File.Delete(filepath);
               CreateJsonFile(filepath, allNbaPlayer);
            }
            else if (!File.Exists(filepath))
            {
             CreateJsonFile(filepath, allNbaPlayer);
            }
          }
        }
    }


using System;
using System.IO;

namespace AnimalExhiliration
{
	public class Initialiser
	{

        static readonly string textFile =
            "/Users/pete/Library/Mobile Documents/com~apple~CloudDocs/<3 Faruq <3/AnimalExhiliration/AnimalExhiliration/hobbyanimals.txt";
        string[] lines;
        HobbyAnimals hobby { get; set; }
        List<char> moods { get; set; }

        public Initialiser()
		{
            if (File.Exists(textFile))
            {
                lines = File.ReadAllLines(textFile);
                hobby = new();
                moods = new();

                int i = 0;
                int j = 0;

                foreach (string line in lines)
                {
                    Console.WriteLine(line);

                    i++;

                    if (i == 1)
                        //number of animals
                        j = int.Parse(line.Trim());

                    else if (i > 1 && i <= 1 + j)
                    {
                        //animals
                        switch (line.Substring(0, 1)) {
                            case "F":
                                hobby.AddAnimal(new Fish(line.Substring(2, line.LastIndexOf(" ")-2),
                                                          int.Parse(line.Substring(line.LastIndexOf(" ")))));
                                break;

                            case "B":
                                hobby.AddAnimal(new Bird(line.Substring(2, line.LastIndexOf(" ")-2),
                                                          int.Parse(line.Substring(line.LastIndexOf(" ")))));
                                break;

                            case "D":
                                hobby.AddAnimal(new Dog(line.Substring(2, line.LastIndexOf(" ")-2),
                                                          int.Parse(line.Substring(line.LastIndexOf(" ")))));
                                break;

                        }
                    }
                    else
                    {
                        //moods
                        foreach (char c in line) {
                            moods.Add(c);
                        }

                    }

                }
                    //Console.WriteLine(line);
            }

            
        }
        
        public HobbyAnimals GetHobbyAnimals()
        {
            return hobby;
        }

        public List<char> GetMoods()
        {
            return moods;
        }
    }
}


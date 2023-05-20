using System;

namespace AnimalExhiliration
{
	public class HobbyAnimals
	{
		readonly List<Animal> animals;

		public HobbyAnimals()
		{
			animals = new();
		}

		public void AddAnimal(Animal animal)
		{
			animals.Add(animal);
		}

		public void Feed(char mood)
		{
			List<Animal> deadAnimals = new();
			foreach (Animal a in animals)
			{
				if (!a.Feed(mood)) {
					deadAnimals.Add(GetAnimalByName(a.Name));
				}

                /*
				 * this (below) would throuw IllegalStateExc so we're
				 * collecting dead records in a separate
				 * collection (above) and remove them
				 * once the iteration here is over
				 */
                //animals.Remove(a);
            }

            foreach (Animal killThis in deadAnimals) {
				animals.Remove(killThis);
            }
        }

		public List<int> HowIsEveryOne()
		{
			List<int> Exhilirations = new();

			foreach (Animal a in animals)
			{
				if (a.isAlive())
				{
					Exhilirations.Add(a.HowAreYou(true));
				}

			}
			return Exhilirations;

		}

		public Animal GetAnimal(int index)
		{
			return animals[index];
		}

		public Animal GetAnimalByName(string name) {
			Animal ret = new();
			foreach (Animal a in animals) {
				if (a.Name == name)
					ret = a;
			}
			return ret;
		}


	}
}


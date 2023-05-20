using System;
namespace AnimalExhiliration
{
	public class Cathy
	{

		protected char Mood { get; set; }

		public void FeedAnimals(HobbyAnimals hobbyAnimals) {
			hobbyAnimals.Feed(Mood);
		}

		public static bool DoAnimalsElevateMood(HobbyAnimals hobbyAnimals) {

			bool ret = true;

			foreach(int exl in hobbyAnimals.HowIsEveryOne())
			{
				if (exl < 5) ret = false;
			}
			return ret;

		}

		public char FeelBetter(char oldMood)
		{
			switch (oldMood)
			{
				case 'b':
					Mood = 'o';
					break;

				case 'o':
					Mood = 'g';
					break;

                case 'g':
                    Mood = 'g';
                    break;
            }
			return Mood;
		}

        public char FeelWorse(char oldMood)
        {
            switch (oldMood)
            {
                case 'g':
                    Mood = 'o';
                    break;

                case 'o':
                    Mood = 'b';
                    break;

                case 'b':
                    Mood = 'b';
                    break;
            }
            return Mood;

        }
    }
    
}


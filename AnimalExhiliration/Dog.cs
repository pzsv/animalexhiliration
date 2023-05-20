using System;
namespace AnimalExhiliration
{
	public class Dog : Animal 
	{
        public Dog(string name, int exhiliration)
		{
            Name = name;
            Type = "dog";
            Exhiliration = exhiliration;

            g = 3;
            o = 0;
            b = -10;

        }

    }
}


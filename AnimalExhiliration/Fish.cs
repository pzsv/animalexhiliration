using System;
namespace AnimalExhiliration
{
	public class Fish : Animal 
	{
        public Fish(string name, int exhiliration)
		{
            Name = name;
            Type = "fish";
            Exhiliration = exhiliration;

            g = 1;
            o = -3;
            b = -5;

        }

    }
}


using System;
namespace AnimalExhiliration
{
    public class Bird : Animal
    {
        public Bird(string name, int exhiliration)
        {
            Name = name;
            Type = "bird";
            Exhiliration = exhiliration;
            g = 2;
            o = -1;
            b = -3;

        }

    }
}


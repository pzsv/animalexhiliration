/* Exhiliration change:
 * 
 *          Bad Ord Good
 * Fish      -5  -3   1
 * Birds     -3  -1   2
 * Dogs     -10   0   3
 * 
 * 
 * Care
 *          Bad Ord Good
 * Fish               x
 * Birds              x
 * Dogs          x    x
 * 
 * 
 */
namespace AnimalExhiliration;

public class Program
{
    static bool verbose = true;

    public static void Main()
    {
        Initialiser ini = new();
        Cathy cathy = new();
        HobbyAnimals hobbyAnimals = ini.GetHobbyAnimals();

        /*
         * Iterate trough the initial
         * list of moods we have read from the file
         */
        List<char> moods = ini.GetMoods();
        for (int i = 0; i < moods.Count; i++) {

            print(verbose, "base mood today", Char.ToString(moods[i]));

            /*
             * Cathy's mood change based on animals'
             * exhiliration and added to base mood
             */
            if (Cathy.DoAnimalsElevateMood(hobbyAnimals))
            {

                moods[i] = cathy.FeelBetter(moods[i]);
                print(verbose, "Cathy's mood elevated, new mood: ", Char.ToString(moods[i]));

            }
            else {
                moods[i] = cathy.FeelWorse(moods[i]);
                print(verbose, "Cathy's mood dropped, new mood: ", Char.ToString(moods[i]));

            }

            /*
             * Now that Cathy knows how she feels,
             * she feeds her animals. Also, the
             * ones not surviving the current day
             * will be deleted from the collection here
             */
            cathy.FeedAnimals(hobbyAnimals);

        }


        /*
         * 
         */
        List<int> finalExhilirationLevels = hobbyAnimals.HowIsEveryOne(); //exhiliration level of all animals alive
        List<int> idxMinFinalExhilirationLevels = new(); //collection to store indices
        int minValueExhiliration = finalExhilirationLevels.Min(); //the smallest exhiliration in the set
        //int cursor = 0;

        int currIdxExhiliration = -1; //index variable to iterate through exhilirations (would be worth throwing an exception when it's -1

        foreach (int currValueExhiliration in finalExhilirationLevels) {

            currIdxExhiliration++;

            /*
             * add current index to the list where
             * value matches the minimum 
             * found above
             */
            if (currValueExhiliration == minValueExhiliration)
                idxMinFinalExhilirationLevels.Add(currIdxExhiliration);

        }

        /*
         * log found minimums on stdout
         */
        foreach (int i in idxMinFinalExhilirationLevels)
        {
            print(verbose, "minimum exhiliration found in animal(index)",
                (hobbyAnimals.GetAnimal(i)).Name + "(" + i + ")");
        }


        /*
         * Old logic of minimumsearch 
         * via List<>.RemoveRange()
         * 
         *
        do
        {

            int minExhIdx = finalExh.IndexOf(minExh);

            if (minExhIdx == -1) break;

            minimumsIndexes.Add(minExhIdx+cursor);

            //TODO
            cursor = minExhIdx;

            finalExh.RemoveRange(0, minExhIdx + 1);

        } while (finalExh.Count() > 0);
        */

    }

    /*
     * Simple console logger helper
     * 
     */
    static void print(bool verbose, string msg, string data) {
        if (verbose)
        {
            Console.WriteLine((DateTime.Now).ToString("yyyy-MM-ddTHH:mm:ss") + " : " +
                msg + " : " +
                data);
        }
    }
}



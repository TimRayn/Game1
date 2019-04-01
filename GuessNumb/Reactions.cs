using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumb
{
    public class Reactions
    {
        public void Win()
        {
            Random rand = new Random();
            int phraseVar = rand.Next(1, 4);
            switch (phraseVar)
            {
                case 1:
                    Console.WriteLine("Ого, ничего себе, ты угадал(а)! С тобой интересно играть, поиграй со мной еще.\n(Хотите поиграть еще?)\n(Y/N)");
                    // Не, тут надо через как-то ивенты замутить
                    // Хз, как пока
                    // Todo: Замутить все, шоб работало
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    public class InsertNumber
    {
        public static int Get(int firstNum, int secondNum, int i, int j)
        {
            //проверка на условие что i<=j
            if (i <= j)
            {
                // представление в 2 форме первого числа в массиве 
                char[] numFirst = Generator(firstNum);
                // представлние в 2 форме второго числа в массиве 
                char[] numSecond = Generator(secondNum);
                int count = j - i + 1;
                //вот тут спорный вопрос по поводу какие элемнты нужно брать, но исходя из картинки с Git сделал так
                char[] numHelp = numSecond.Take(count).ToArray();
                string answerNum = null;
                for (int x = i; x <= j; x++)
                {
                    numFirst[x] = numHelp[x - i];
                }
                foreach (var number in numFirst.Reverse().ToArray())
                {

                    answerNum += number;
                }
                return Convert.ToInt32(answerNum, 2);
            }
            //выдает ошибку что не прошло условие 
            else { throw new Exception("Error (i>j)"); }
        }
        // перевод числа в 2 систему исчесления
        private static char[] Generator(int number)
        {
            string num = Convert.ToString(number, 2);
            char[] answer = new char[32];
            int size = 32 - num.Count();
            for (int i = 0; i < size; i++)
            {
                num = "0" + num;
            }
            var answerHelp = num.ToArray().Reverse();
            answer = answerHelp.ToArray();

            return answer;
        }
    }
}

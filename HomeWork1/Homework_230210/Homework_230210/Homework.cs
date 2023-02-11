namespace Homework_230210
{
    internal class Homework
    {
        static void Main(string[] args)
        {
            // 월요일 숙제
            #region

            /*
            float num1;
            float num2;
            float num3;
            float result1;
            float result2;
            string input1;
            string input2;
            string input3;

            System.Console.WriteLine("첫 번째 숫자를 입력해주세요.");
            input1 = System.Console.ReadLine();

            System.Console.WriteLine("두 번째 숫자를 입력해주세요.");
            input2 = System.Console.ReadLine();

            // 형변환
            num1 = float.Parse(input1);
            num2 = float.Parse(input2);

            result1 = num1 + num2;
            System.Console.WriteLine(result1);

            result1 = num1 - num2;
            System.Console.WriteLine(result1);

            result1 = num1 * num2;
            System.Console.WriteLine(result1);

            result1 = num1 / num2;
            System.Console.WriteLine(result1);

            result1 = num1 % num2;
            System.Console.WriteLine(result1);

            System.Console.WriteLine("새로운 숫자 하나를 입력해주세요");
            input3 = System.Console.ReadLine();

            // 형변환
            num3 = float.Parse(input3);

            // 초기화
            result2 = num1 + num2;

            result2 += num3;
            System.Console.WriteLine(result2);

            result2 -= num3;
            System.Console.WriteLine(result2);

            result2 *= num3;
            System.Console.WriteLine(result2);

            result2 /= num3;
            System.Console.WriteLine(result2);

            result2 %= num3;
            System.Console.WriteLine(result2);


            // 증감연산자
            System.Console.WriteLine(num3++);

            System.Console.WriteLine(++num3);

            System.Console.WriteLine(num3--);

            System.Console.WriteLine(--num3);
            */

            #endregion

            // 수요일 숙제
            #region

            
            float num1;
            float num2;
            float result;
            string input1;
            string input2;

            System.Console.WriteLine("첫 번째 숫자를 입력해주세요");
            input1 = Console.ReadLine();

            System.Console.WriteLine("두 번째 숫자를 입력해주세요");
            input2 = Console.ReadLine();

            // 형변환
            num1 = float.Parse(input1);
            num2 = float.Parse(input2);

            result = num1 + num2;

            if (result <= 10)
            {
                Console.WriteLine("숫자의 합이 10 이하입니다.");
            }
            else if (result <= 20)
            {
                System.Console.WriteLine("숫자의 합이 10보다 크고 20 이하입니다.");
            }
            else if (num1 <= 30)
            {
                System.Console.WriteLine("숫자의 합이 20보다 크고 30 이하입니다.");
            }
            else
            {
                System.Console.WriteLine("숫자의 합이 30보다 큽니다.");
            }
            
            if (num1 % 2 == 0)

            #endregion



        }
    }
}
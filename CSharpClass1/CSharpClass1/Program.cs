using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpClass1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Write 쓰는 법
            System.Console.Write("Hello World");
            // WriteLine 쓰는 법
            System.Console.WriteLine("제 이름은 김준겸 입니다");
            System.Console.Write("저는 19살 입니다");
            System.Console.WriteLine("저는 백석고등학교 학생입니다");
            System.Console.Write("저는 현재 인천 서구에 거주하고 있습니다");
            System.Console.WriteLine("제 생일은 8월 5일입니다");
            System.Console.Write("저는 이제 할 말이 없습니다");
            System.Console.WriteLine("감사합니다");
            System.Console.Write("저는 2월 초에 스키장에 가요");
            System.Console.Write("네");

            // 이건 주석입니다. 아무리 써도 코드에 영향을 주지 않습니다.


            // String 데이터 자료형
            String myName;
            String myAge;
            String mySchool;
            String myHome;
            String myTMI;

            myName = "제 이름은 김준겸 입니다";
            myAge = "저는 19살입니다";
            mySchool = "저는 백석고등학교에 다닙니다";
            myHome = "저는 인천 서구에 살고 있습니다";
            myTMI = "저는 2월달에 스키장에 가서 보드를 탈 거에요";

            System.Console.WriteLine(myName);
            System.Console.WriteLine(myAge);
            System.Console.WriteLine(mySchool);
            System.Console.WriteLine(myHome);
            System.Console.WriteLine(myTMI);

            */

            // ReadLine();

            /*

            string inputName; // 이름
            string inputHome; // 주소
            string inputAge; // 나이
            string inputSex; // 성별




            // 이름
            System.Console.WriteLine("이름을 입력해주세요");
            inputName = System.Console.ReadLine();
            // 주소
            System.Console.WriteLine("주소를 입력해주세요");
            inputHome = System.Console.ReadLine();
            // 나이
            System.Console.WriteLine("나이를 입력해주세요");
            inputAge = System.Console.ReadLine();
            // 성별
            System.Console.WriteLine("성별을 입력해주세요");
            inputSex = System.Console.ReadLine();

            // 출력 이름
            System.Console.Write("당신의 이름은 : ");
            System.Console.WriteLine(inputName);
            // 출력 주소
            System.Console.Write("당신의 주소는 : ");
            System.Console.WriteLine(inputHome);
            // 출력 나이
            System.Console.Write("당신의 나이는 : ");
            System.Console.WriteLine(inputAge);
            // 출력 성별
            System.Console.Write("당신의 성별은 : ");
            System.Console.WriteLine(inputSex);

            // 다른 출력 방법
            //System.Console.WriteLine("당신의 이름은 : " + inputName);
            //System.Console.WriteLine("당신의 주소는 : " + inputHome);
            //System.Console.WriteLine("당신의 나이는 : " + inputAge);
            //System.Console.WriteLine("당신의 성별은 : " + inputSex);

            System.Console.Write($"당신의 이름은 {inputName} 이고, 당신의 나이는 {inputAge} 입니다");
            System.Console.Write("당신의 이름은 {0} 이고, 당신의 나이는 {1} 입니다", inputName, inputAge);

            */

            //System.Console.WriteLine(int.MaxValue);
            //System.Console.WriteLine(int.MinValue);

            // 나의 태어난 년도 입력
            // 지금 나이 도출하기

            /*
            String myBirthStr;
            int myBirth;
            String myAge;

            System.Console.WriteLine("당신의 출생년도는 몇년도입니까? (네 자리 숫자로만 입력해주세요)");
            myBirthStr = System.Console.ReadLine();

            myBirth = Convert.ToInt32(myBirthStr);

            myAge = (2023 - myBirth).ToString();

            System.Console.WriteLine("당신의 만 나이는 : " + myAge);
            */

            //            System.Console.Write
            //(@"      ㅁ
            //     ㅁㅁ
            //    ㅁㅁㅁ
            //   ㅁㅁㅁㅁ
            //  ㅁㅁㅁㅁㅁ
            // ㅁㅁㅁㅁㅁㅁ
            //ㅁㅁㅁㅁㅁㅁㅁ");

            /*

            // 1. 변수형 종류 주석으로 작성 후, 각 변수형들의 최대값 최소값 출력하기
            // char
            System.Console.WriteLine(char.MaxValue);
            System.Console.WriteLine(char.MinValue);
            // int
            System.Console.WriteLine(int.MaxValue);
            System.Console.WriteLine(int.MinValue);
            // long
            System.Console.WriteLine(long.MaxValue);
            System.Console.WriteLine(long.MinValue);
            // float
            System.Console.WriteLine(float.MaxValue);
            System.Console.WriteLine(float.MinValue);
            // double
            System.Console.WriteLine(double.MaxValue);
            System.Console.WriteLine(double.MinValue);

            // 2. string으로 이름 나이 입력 받고, 출력하기
            // 나이는 출생연도만 입력받기
            string inputBirth;
            string outputBirth;
            int myAge;

            System.Console.WriteLine("당신의 출생연도는 몇 년도인가요? (네 자리 숫자로만 입력해주세요)");
            inputBirth = System.Console.ReadLine();

            myAge = Convert.ToInt32(inputBirth);

            outputBirth = (2023 - myAge).ToString();

            System.Console.WriteLine("당신의 만 나이는 : " + outputBirth);

            // 3. @사용해서 별 그리기
     System.Console.WriteLine(@"
          **
         ****
   ***************
      *********
       ********
     ***    ***
");
            // 4. int값을 float 로 캐스팅하기
            // 3.12 를 int 값으로 캐스팅(형변환)하기
            float f = 3.12f;
            int i = (int)f;

            */

            /*
            // 이름을 입력받는다.
            // 입력 받은 이름의 길이를 숫자로 바꾸고
            // 받은 숫자를 출력한다.
            string name;
            int nameLength;

            Console.WriteLine("이름을 입력해주세요");
            name = Console.ReadLine();

            nameLength = name.Length;

            Console.WriteLine(nameLength);
            */

            /*
            // int형 5칸 짜리 배열 5개 만들고
            // string형 5칸 짜리 배열 5개 만들기
            int[] i1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] i2 = new int[5] { 9, 8, 7, 6, 5 };
            int[] i3 = new int[5] { 12, 23, 34, 45, 56 };
            int[] i4 = new int[5] { 456, 324, 85, 2456, 6743 };
            int[] i5 = new int[5] { 121212, 824, 2, 44, 2 };

            string[] str1 = new string[5] { "안", "녕", "하", "세", "요" };
            string[] str2 = new string[5] { "하나", "둘", "셋", "넷", "다섯" };
            string[] str3 = new string[5] { "Good", "Hi", "Name", "Home", "Yes" };
            string[] str4 = new string[5] { "네", "아니요", "Hello", "ㅇㅇ", "네" };
            string[] str5 = new string[5] { "rm", "wrrw", "dwdad", "w", "www" };

            int[] LaterArray;

            System.Console.WriteLine("배열의 크기는?");
            string ArraySize;
            ArraySize = System.Console.ReadLine();

            LaterArray = new int[Convert.ToInt32(ArraySize)];


            string[] lang = new string[3];
            lang[0] = "c";
            lang[1] = "C++";
            lang[2] = "C#";

            System.Console.WriteLine($"0번 값은 {lang[0]} 입니다");
            lang[0] = "개졸려";
            System.Console.WriteLine($"0번 값은 {lang[0]} 입니다");



            */

            // 식당에 음식이 떡볶이, 김밥, 라면, 라뽂이가 있다.
            // 이 중에 숫자를 입력받으면
            // 입력 받은 값은 비어있게 된다.

            // 최초 음식들과
            // 숫자를 입력받았을 때 음식을 출력하고

            // 비어있게 되었다 라는 결과값도 출력하라.

            string[] food = new string[5] { "", "떡볶이", "김밥", "라면", "라볶이" };
            string strNum;
            int num;


            System.Console.WriteLine("식당에 떡볶이, 김밥, 라면, 라볶이가 있습니다.");
            System.Console.WriteLine("먹고 싶은 음식의 번호를 입력해주세요.");
            strNum = System.Console.ReadLine();

            // 형변환
            num = Convert.ToInt32(strNum);

            System.Console.WriteLine(food[num] + "를 고르셨습니다");

            food[num] = ""; // 먹은 음식 지우기

            System.Console.WriteLine("남은 음식은 " + food[1] + "," + food[2] + "," + food[3] + "," + food[4] + "이 있습니다") ;

            //숫자를 ㅇㅣㅂ력해주세요 리드라인으로 받기


            //    입력받은 숫자에 해당하는 값을 라이트라인

            //    하고 그 번호의 음식을 배열에서 지운다

            //    스트링 재정의 떡뽁이 따옴표 떡볶이

            //    그리고 남은 값 모두 출력
        }
    }
}

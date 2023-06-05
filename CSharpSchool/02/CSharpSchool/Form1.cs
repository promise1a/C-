using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpSchool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_clear_Click(object sender, EventArgs e)
        {

            ClearResult();
        }

        private void ClearResult()
        {
            this.tbox_result.Clear();
        }

        private void WriteLine(object obj)
        {
             Write(string.Format("{0}\r\n", obj));
        }
        private void Write(string aText)
        {
            this.tbox_result.AppendText(aText);
        }

        private void Write(object obj)
        {
            Write(string.Format("{0}", obj));
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hello C3 Programing...!");
            WriteLine("Hello C3 Programing...!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*
            char _buff = (char)254;
            Write("254 => ");
            WriteLine(_buff);

            _buff = (char)(_buff + 1);
            Write("255 => ");
            WriteLine(_buff);

            _buff = (char)(_buff + 1);
            Write("256 => ");
            WriteLine(_buff);

            _buff = (char)(_buff + 1);
            Write("257 => ");
            WriteLine(_buff);
            */

            WriteLine((5 + 3) * 2);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            WriteLine(10 % 5);
            WriteLine(7 % 3);
        }

        private void dpkr_1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            WriteLine(1 + 2);
            WriteLine(1 - 2);
            WriteLine(1 * 2);
            WriteLine(/*(double)*/1 / 2); // 정수/정수 = 정수(소수점이하는 버림)
            WriteLine(1 % 2);

            WriteLine("---------------");
            WriteLine(1.0 + 2);
            WriteLine(1.0 - 2);
            WriteLine(1.0 * 2);
            WriteLine(/*(double)*/1.0 / 2); // 실수/정수 = 실수
            WriteLine(1.0 % 2);


        }

        private void button7_Click(object sender, EventArgs e)
        {
            WriteLine(4 % 3);
            WriteLine(-4 % 3);
            WriteLine(4 % -3);
            WriteLine(-4 % -3);
            // C#에서 나머지 연산자의 부호는 왼쪽 피연산자의 부호를 따름
            // 오른쪽 피연산자의 부호는 전혀 상관 X
        }

        private void button11_Click(object sender, EventArgs e)
        {
            WriteLine(5.0 % 2.2);
            WriteLine(50 % 22);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            WriteLine('A');
            WriteLine('가');
            WriteLine('나');

        }

        private void button13_Click(object sender, EventArgs e)
        {
            WriteLine("안녕하세요");
            //문자 문자열
            //char char[] <= C
            //char string <= C#
            // '' " "

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Console.WriteLine("한빛\t아카데미");
            Console.WriteLine("한빛\n아카데미");
            Console.WriteLine("\"아카데미\"");
            WriteLine("한빛\r\n아카데미");

            /*
             \" => 큰따옴표
            \t => 탭 강   아   지
            \n => 줄바꿈
            */

        }

        private void button15_Click(object sender, EventArgs e)
        {
            WriteLine("가나다" + "라마" + "바사아" + "자차카타" + "파하");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            WriteLine("안AB녕C하세요"[1]);
            WriteLine("안AB녕C하세요"[3]);
            WriteLine("안AB녕C하세요"[5]);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            WriteLine("안녕하세요"[100]);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Console.WriteLine('가' + '힣');
            Console.WriteLine("가" + "힣");
        }

        private void button20_Click(object sender, EventArgs e)
        {
/*
== 같다
!= 다르다
>
<
>=
<=
*/
            WriteLine(52 < 273);
            WriteLine(52 > 273);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            WriteLine(!true);
            WriteLine(!false);
            WriteLine(!(52<273));
            WriteLine(!(52>273));
        }

        private void button22_Click(object sender, EventArgs e)
        {
            WriteLine(DateTime.Now);
            WriteLine(DateTime.Now.Hour);

            //1
            WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour);
            WriteLine(3 < DateTime.Now.Hour && DateTime.Now.Hour < 8);
            
            //2
            WriteLine(8 < DateTime.Now.Hour || DateTime.Now.Hour < 3);
            WriteLine(DateTime.Now.Hour < 8 && 3 < DateTime.Now.Hour);

            //1이 2보다 가독성이 더 좋은 코드임
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int a = 273;
            int b = 52;

            WriteLine(a + b);
            WriteLine(a - b);
            WriteLine(a * b);
            WriteLine(a / b);
            WriteLine(a % b);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            int a = 2147483640;
            int b = 52273;

            WriteLine(a + b);

            uint a2 = 4294967295;
            WriteLine(a2);
            a2 += 1; // a2를 1 증가
            WriteLine(a2);
            a2 += 1; // a2를 1 증가
            WriteLine(a2);
            a2 += 1; // a2를 1 증가
            WriteLine(a2);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            WriteLine(int.MaxValue);
            WriteLine(int.MinValue);

        }

        private void button29_Click(object sender, EventArgs e)
        {
            WriteLine(long.MaxValue);
            WriteLine(long.MinValue);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //부동소수점 double 사용
            double double1 = 0.1;
            double double2 = 1;

            if (double1 + double2 == 1.1)
                WriteLine("값 일치");
            else
                WriteLine("일치하지 않음");


            //고정소수점 decimal 사용         
            decimal decimal1 = 0.1M;
            decimal decimal2 = 1.1M;

            if (decimal1 + decimal2 == 1.2M)
                WriteLine("값 일치");
            else
                WriteLine("일치하지 않음");



        }

        private void button30_Click(object sender, EventArgs e)
        {
            double a = 52.273;
            double b = 103.32;

            WriteLine(a+ b);
            WriteLine(a-b);
            WriteLine(a*b);
            WriteLine(a/b);
            WriteLine(a % b);

        }

        private void button31_Click(object sender, EventArgs e)
        {
            char a = 'a';
            WriteLine(a);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            WriteLine("int: " + sizeof(int));
            WriteLine("long: " + sizeof(long));
            WriteLine("float: " + sizeof(float));
            WriteLine("double: " + sizeof(double));
            WriteLine("char: " + sizeof(char));



            /*
            안시코드 1byte
            유니코드 2byte
            멀티코드 2byte
             
             */

        }

        private void button33_Click(object sender, EventArgs e)
        {
            char a = 'a';
            char b = 'b';
            
            // ASCII코드
            WriteLine(a + b);   // 97 + 98 => 195
            WriteLine(a - b);   // 97 - 98 => -1
            WriteLine(a * b);   // 97 * 98 => 9506
            WriteLine(a / b);   // 97 / 98 => 0
            WriteLine(a % b);   // 97 % 98 => 97

        }

        private void button34_Click(object sender, EventArgs e)
        {
            string message = "안녕하세요";

            WriteLine(message + "!");
            WriteLine(message[0]);
            WriteLine(message[1]);
            WriteLine(message[2]);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            //WriteLine("string : " + sizeof(string));
            string _buffer = "강아지";
            WriteLine("강아지: " + _buffer.Length);    // 문자열 길이
            WriteLine("강아지: " + (_buffer.Length)*(sizeof(char)) + "byte");  // 바이트 크기
        }

        private void button36_Click(object sender, EventArgs e)
        {
            bool one = 10 < 0;
            bool other = 20 > 100;

            WriteLine(one);
            WriteLine(other);

            // 0은 거짓 1은 참
            // 0만 거짓, 다른 값이 들어가면 참

            bool _buff = Convert.ToBoolean(1);
            WriteLine("1 => " + _buff);
            _buff = Convert.ToBoolean(0);
            WriteLine("1 => " + _buff);
            _buff = Convert.ToBoolean(-1);
            WriteLine("1 => " + _buff);
            
        }

        private void button37_Click(object sender, EventArgs e)
        {
            /*
            int a = 0;
            int b = a + 3;
            a = a + 3; // a += 3;
            a = a - 3; // a -= 3;
            a = a * 3; // a *= 3;
            a = a / 3; // a /= 3;
            */

            int output = 0;
            output += 52;
            WriteLine(output);
            output += 273;
            WriteLine(output);
            output += 103;
            WriteLine(output);

        }

        private void button38_Click(object sender, EventArgs e)
        {
            int output = 0;
            output = output + 52;
            WriteLine(output);
            output = output + 273;
            WriteLine(output);
            output = output + 103;
            WriteLine(output);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            string output = "hello ";
            WriteLine(output);
            output += "world ";
            WriteLine(output);
            output += "!";

            WriteLine(output);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            string output = "hello ";
            WriteLine(output);
            output = output + "world ";
            WriteLine(output);
            output = output + "!";

            WriteLine(output) ;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            /*
            a++, ++a => a+= 1, a= a+1
            b--, --b => b-= 1, b= b-1
            c = a++; , c = ++a;
            */


            int number = 10;
            WriteLine(number);
            number++;
            WriteLine(number);
            number--;
            WriteLine(number);

        }

        private void button42_Click(object sender, EventArgs e)
        {
            int number = 10;
            WriteLine(number);
            WriteLine(number++);
            WriteLine(number--);
            WriteLine(number);
            WriteLine("-----------------");
            number = 10;
            WriteLine(number);
            WriteLine(++number);
            WriteLine(--number);
            WriteLine(number);


        }

        private void button45_Click(object sender, EventArgs e)
        {
            int number = 10;
            WriteLine(number);
            number++;
            number++;
            WriteLine(number);
            WriteLine(number);
            number--;
            number--;
            WriteLine(number);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            // 변수를 선언합니다.
            int _int = 273;
            long _long = 522731033265;
            float _float = 52.273F;
            double _double = 52.273;
            char _char = '글';
            string _string = "문자열";

            // 출력합니다.
            WriteLine(_int.GetType());
            WriteLine(_long.GetType());
            WriteLine(_float.GetType());
            WriteLine(_double.GetType());
            WriteLine(_char.GetType());
            WriteLine(_string.GetType());
        }

        private void button47_Click(object sender, EventArgs e)
        {
            WriteLine((273).GetType());
            WriteLine((522731033265L).GetType());
            WriteLine((52.273F).GetType());
            WriteLine((52.273).GetType());
            WriteLine(('자').GetType());
            WriteLine(("문자열").GetType());
        }

        /* 
        실수(가변)
        float 4바이트
        double 8바이트
        if(100 / 7 == 1000 / 70){
            참이 아닌 경우가 생길 수도 있음.. >> 가변실수라서
        }

        #c 고정실수
        double(부동소수점)과 demical(고정소수점)

         */


        /*
논리연산자

not(!)     참 => 거짓, 거짓 => 참

or(||)      참 or 거짓 => 참, 거짓 or 참 => 참, 참 or 참 => 참, 거짓 or 거짓 => 거짓
(둘 중 하나라도 참이면 참)

and(&&)     참 and 거짓 => 거짓, 거짓 and 참 => 거짓, 참 or 참 => 참, 거짓 or 거짓 => 거짓
(둘 모두 참이어야 참)

*/

    }
}


// 자료형
/*
 
변수 자료형
상수 const 자료형

숫자 : 정수(int, long) + 실수(float, double)
        int 4바이트 32비트
        long 8바이트 64비트

문자 : 문자(char), 문자열(string)

조합 : 구조체, 배열, 클래스


주석

2의 8승 256
char 8비트 0b0000 0000 => signed cahr -128~127
byte 8비트 0b0000 0000 => unsigned char 0~255
        254 + 1 => 255
        255 + 1 => 0

    0001 0010 0011 0100

    254 => 1111 1110
    255 => 1111 1111
    256 => 0001 0000 0000 => 0
    1      0000 0001
    2      0000 0010
 
short => signed short int
int => signed int(정수)
long => signed long int

uint Int32 Int64
string(문자열) 

// 보기 - 출력 - form1 디자인 - f5




 */
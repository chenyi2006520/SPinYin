using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace SPinYinAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer hello = new SpeechSynthesizer();
            while (true)
            {
                string str = "请输入您的名字";
                hello.Speak(str);  //Speak(string),Speak加上字符串类型的参数
                string youName = Console.ReadLine();
                if (youName == "quit")
                {
                    hello.Speak("拜拜。再见。");  //Speak(string),Speak加上字符串类型的参数
                    return;
                }
                hello.Speak("你好" + youName);  //Speak(string),Speak加上字符串类型的参数 
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TrumpPair
{
    class Program
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="パーティ情報"></param>
        static void Main(string[] args)
        {
            ///ループ用変数          
            bool loop = true;
            int I = 0;
            int i = 0;
            ///カード枚数用変数           
            int CardNum = 4;

            int number = 0;

            int pair = 0;

            // 配列を作成
            Card[] cards = new Card[CardNum];

            //ペア保存用変数
            var num = new int[4];



            // インスタンス生成
            for (i = 0; i < CardNum; i++)
            {// プレイヤー人数分ループ
                cards[i] = new Card();
            }

            // ステータス入力
            for (i = 0; i < CardNum; i++)
            {
                loop = true;
                while (loop == true)
                {
                    Console.Write(i + 1);
                    Console.Write("枚目のカードの数字を入力 >");


               
                                

                    if (int.TryParse(Console.ReadLine(), out number))
                    {
                        if (number > 4 || number <= 0)
                        {
                            Console.WriteLine("範囲外の数字が入力されました。やり直してください。");
                        }
                        else
                        {
                            num[i] = number;
                           loop = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("数字ではない文字列が入力されました。やり直してください。");
                    }
               }
            }

            ///プレイヤー情報出力
            Console.WriteLine("\nカード情報\n\n ");  // 文字列を表示
            int Inum = 3;

            for (i = 0; i < CardNum; i++)
            {
                //カード枚数分ループ
                Console.Write("{0}枚目 : ", i + 1);  // 文字列を表示

                Console.Write("{0}\n", num[i]);  // 文字列を表示

                for (I = 0; I < Inum; I++)
                {

                    //Console.Write("{0}\n", num[i]);  // 文字列を表示
                    //Console.Write("{0}\n", num[I + i + 1]);  // 文字列を表示

                    //合致する数字があった場合
                    if (num[i] == num[I + i + 1])
                    {
                        pair++;
                    }
                }
                //ループ上限を下げる
                Inum--;
                
            }
            
            if(CardNum < pair)
            {
                pair = CardNum;

            }
            Console.Write("ペア数 : {0}\n", pair);  // 文字列を表示




            switch (pair)
            {
                case 4: Console.WriteLine("Four Card"); break;
                case 3: Console.WriteLine("Three Card"); break;
                case 2: Console.WriteLine("Two Pair"); break;
                case 1: Console.WriteLine("One Pair"); break;
                default: Console.WriteLine("No hands"); break;
            }

            Console.Write("\nエンターを押して閉じる");
            Console.ReadLine();

        }
    }
}

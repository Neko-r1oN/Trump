using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TrumpPair
{
    class Card
    {
        private bool loop = true;
        private int CardNum = 0;
        private int PairNum = 0;    //ペア合致数保存変数



        /// <summary>
        /// ステータス入力処理
        /// </summary>
        public void CreateCard()
        {
            for (int i = 1; i <= 4; i++)
            {

                while (loop == true)
                {
                    Console.Write("\n", i, "番目のカードの数値を入力＞ ");  // 文字列を表示

                    if (int.TryParse(Console.ReadLine(), out CardNum))
                    {
                        if (CardNum > 4 || CardNum <= 0)
                        {
                            Console.WriteLine("範囲外の数字が入力されました。やり直してください。");

                        }
                        else
                        {
                            loop = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("数字ではない文字列が入力されました。やり直してください。");


                    }
                }

            }

        }
        public void ShowCard()
        {

            Console.WriteLine("数字：{0}\n", CardNum);
        }
        public void CheckCard(int Card1, int Card2, int Card3, int Card4)
        {
            var s = new int[4];
            var num = new int[4];
            foreach (var e in s)
                num[e - 1]++;

            var max = 0;
            var cnt2 = 0;
            foreach (var e in num)
            {
                if (e > max) max = e;
                if (e == 2) cnt2++;
            }

            switch (max)
            {
                case 4: Console.WriteLine("Four Card"); break;
                case 3: Console.WriteLine(cnt2 == 1 ? "Full House" : "Three Card"); break;
                case 2: Console.WriteLine(cnt2 == 2 ? "Two Pair" : "One Pair"); break;
                default: Console.WriteLine("No hands"); break;
            }
        }

    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptanalysis_of_the_affine_cipher
{
    class Program
    {
        public struct alfavit
        {
            public int number;
            public char name;
        }
        public struct com
        {
            public char name;
            public short value;
        }

        static void Main(string[] args)
        {
            string text = "бсиьбжгаоялплцкщдцаэглшнокжцкшгезогльнглщишияжлжгишкдгибжшксицкщгляябцерлкгэхицкъглскокшгкзихлояигдшазяокэкяжкхс";
            string text1 = null;
            bool CH;
            int index = 0;
            ConsoleKeyInfo m = new ConsoleKeyInfo();

            //  string text_1=null;
            alfavit[] all = new alfavit[32];
            alfavit[] mas = new alfavit[32];
            mas[0] = new alfavit { name = 'а' };
            mas[1] = new alfavit { name = 'б' };
            mas[2] = new alfavit { name = 'в' };
            mas[3] = new alfavit { name = 'г' };
            mas[4] = new alfavit { name = 'д' };
            mas[5] = new alfavit { name = 'е' };
            mas[6] = new alfavit { name = 'ж' };
            mas[7] = new alfavit { name = 'з' };
            mas[8] = new alfavit { name = 'и' };
            mas[9] = new alfavit { name = 'й' };
            mas[10] = new alfavit { name = 'к' };
            mas[11] = new alfavit { name = 'л' };
            mas[12] = new alfavit { name = 'м' };
            mas[13] = new alfavit { name = 'н' };
            mas[14] = new alfavit { name = 'о' };
            mas[15] = new alfavit { name = 'п' };
            mas[16] = new alfavit { name = 'р' };
            mas[17] = new alfavit { name = 'с' };
            mas[18] = new alfavit { name = 'т' };
            mas[19] = new alfavit { name = 'у' };
            mas[20] = new alfavit { name = 'ф' };
            mas[21] = new alfavit { name = 'х' };
            mas[22] = new alfavit { name = 'ц' };
            mas[23] = new alfavit { name = 'ч' };
            mas[24] = new alfavit { name = 'ш' };
            mas[25] = new alfavit { name = 'щ' };
            mas[26] = new alfavit { name = 'ъ' };
            mas[27] = new alfavit { name = 'ы' };
            mas[28] = new alfavit { name = 'ь' };
            mas[29] = new alfavit { name = 'э' };
            mas[30] = new alfavit { name = 'ю' };
            mas[31] = new alfavit { name = 'я' };

            com[] slozno = new com[32];
            slozno[0] = new com { name = 'о', value = 14 };
            slozno[1] = new com { name = 'е', value = 5 };
            slozno[2] = new com { name = 'а', value = 0 };
            slozno[3] = new com { name = 'и', value = 8 };
            slozno[4] = new com { name = 'т', value = 18 };
            slozno[5] = new com { name = 'н', value = 13 };
            slozno[6] = new com { name = 'с', value = 17 };
            slozno[7] = new com { name = 'р', value = 16 };
            slozno[8] = new com { name = 'в', value = 2 };
            slozno[9] = new com { name = 'л', value = 11 };
            slozno[10] = new com { name = 'к', value = 10 };
            slozno[11] = new com { name = 'м', value = 12 };
            slozno[12] = new com { name = 'д', value = 4 };
            slozno[13] = new com { name = 'п', value = 15 };
            slozno[14] = new com { name = 'у', value = 19 };
            slozno[15] = new com { name = 'я', value = 21 };
            slozno[16] = new com { name = 'ы', value = 27 };
            slozno[17] = new com { name = 'з', value = 7 };
            slozno[18] = new com { name = 'ь', value = 28 };
            slozno[19] = new com { name = 'ъ', value = 26 };
            slozno[20] = new com { name = 'б', value = 1 };
            slozno[21] = new com { name = 'г', value = 3 };
            slozno[22] = new com { name = 'ч', value = 23 };
            slozno[23] = new com { name = 'й', value = 9 };
            slozno[24] = new com { name = 'х', value = 21 };
            slozno[25] = new com { name = 'ж', value = 6 };
            slozno[26] = new com { name = 'ю', value = 30 };
            slozno[27] = new com { name = 'ш', value = 24 };
            slozno[28] = new com { name = 'ц', value = 22 };
            slozno[29] = new com { name = 'щ', value = 25 };
            slozno[30] = new com { name = 'э', value = 29 };
            slozno[31] = new com { name = 'ф', value = 20 };

            string[] iskl = new string[] { "йь", "ць", "уь", "кь", "еь", "гь", "оь", "щь", "зь", "хь", "ъь", "фь", "ыь", "аь", "жь", "эь", "яь", "иь", "ьь", "юь",
                "йъ", "цъ", "уъ", "къ", "еъ", "нъ", "гъ", "шъ", "щъ", "зъ", "хъ", "фъ","ыъ", "аъ","пъ", "ръ","оъ", "лъ","дъ", "жъ","эъ", "яъ","чъ", "мъ","иъ", "ьъ","юъ", "йы",
                "уы", "ке","щы", "хы","ъы", "аы","оы", "эы","яы","иы","ьы","юы"};

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < mas.Length; j++)
                {
                    if (text[i] == mas[j].name)
                    {
                        mas[j].number++;
                        break;
                    }
                }
            }
            int a, d;
            int[] im = new int[4];
            char b, c;
            for (int i = 0; i < mas.Length; i++)
            {
                all[i] = mas[i];
            }

            for (int i = 0; i < all.Length; i++)
            {
                for (int j = i + 1; j < all.Length; j++)
                {
                    if (all[i].number < all[j].number)
                    {
                        a = all[i].number;
                        b = all[i].name;
                        all[i] = all[j];
                        all[j].number = a;
                        all[j].name = b;
                    }
                }
            }
            for (int i = 0; i < all.Length / 2; i++)
            {
                Console.WriteLine("{" + all[i].name + "}" + "-" + all[i].number);
            }
            int alfa = 0, betta = 0;
            try
            {
                for (int k = 0; k < all.Length - 1; k++)
                {
                    for (int i = 0; i < slozno.Length; i++)
                    {
                        for (int j = 0; j < slozno.Length; j++)
                        {
                            if (i == j)
                            {
                                continue;
                            }
                            for (int l = 0; l < mas.Length; l++)
                            {
                                if (all[k].name == mas[l].name)
                                {
                                    alfa = l;
                                }
                                if (all[k + 1].name == mas[l].name)
                                {
                                    betta = l;
                                }
                            }
                            alfa = alfa - betta;
                            if (alfa < 0)
                            {
                                alfa *= -1;
                            }

                            for (int q = 0; q < 32; q++)
                            {
                                if (q * alfa % 32 == 1)
                                {
                                    alfa = q;
                                    break;
                                }
                            }
                            a = slozno[i].value - slozno[j].value;
                            if (alfa - betta < 0)
                            {
                                a *= -1;
                            }
                            alfa = ((32 + a) * alfa) % 32;
                            a = 32;
                            d = alfa;
                            while (a != d)
                            {
                                if (a > d)
                                {
                                    a -= d;
                                }
                                else
                                {
                                    d -= a;
                                }
                            }
                            betta = (slozno[j].value - (betta * alfa)) % 32;
                            if (a != 1)
                            {
                                continue;
                            }
                            else
                            {
                                text1 = null;
                                for (int w = 0; w < text.Length; w++)
                                {
                                    for (int s = 0; s < 32; s++)
                                    {
                                        if (text[w] == mas[s].name)
                                        {
                                            if ((alfa * (s - betta)) < 0)
                                            {
                                                text1 += mas[((alfa * (s - betta)) * -1) % 32].name;
                                            }
                                            else
                                            {
                                                text1 += mas[(alfa * (s - betta)) % 32].name;
                                            }
                                            break;
                                        }
                                    }

                                }
                                for (int t = 0; t < iskl.Length; t++)
                                {
                                    if ((text1.IndexOf(iskl[t])) != -1)
                                    {
                                        break;
                                    }

                                    if (t == iskl.Length - 1)
                                    {
                                        Console.WriteLine("a=" + alfa + "  " + "b=" + betta);
                                        Console.WriteLine(text1);
                                        Console.WriteLine(k + " " + i + " " + j);
                                    }

                                }
                            }
                        }

                    }
                }
            }
            catch
            {
                Console.WriteLine("ITS ALL");
            }

        }
    }
}

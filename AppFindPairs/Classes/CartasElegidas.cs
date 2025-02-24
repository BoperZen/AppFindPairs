using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFindPairs.Classes
{
    internal static class CartasElegidas
    {
        public static List<string> GetCartas(int CantidadPares)
        {
            List<string> list = new List<string>();

            switch (CantidadPares)
            {
                case 4:
                    list.Add("picBox8");
                    list.Add("picBox9");
                    list.Add("picBox10");
                    list.Add("picBox11");
                    list.Add("picBox14");
                    list.Add("picBox15");
                    list.Add("picBox16");
                    list.Add("picBox17");
                    break;
                case 5:
                    list.Add("picBox3");
                    list.Add("picBox4");
                    list.Add("picBox8");
                    list.Add("picBox9");
                    list.Add("picBox10");
                    list.Add("picBox11");
                    list.Add("picBox14");
                    list.Add("picBox15");
                    list.Add("picBox16");
                    list.Add("picBox17");
                    break;
                case 6:
                    list.Add("picBox3");
                    list.Add("picBox4");
                    list.Add("picBox8");
                    list.Add("picBox9");
                    list.Add("picBox10");
                    list.Add("picBox11");
                    list.Add("picBox14");
                    list.Add("picBox15");
                    list.Add("picBox16");
                    list.Add("picBox17");
                    list.Add("picBox21");
                    list.Add("picBox22");
                    break;
                case 7:
                    list.Add("picBox2");
                    list.Add("picBox5");
                    list.Add("picBox3");
                    list.Add("picBox4");
                    list.Add("picBox8");
                    list.Add("picBox9");
                    list.Add("picBox10");
                    list.Add("picBox11");
                    list.Add("picBox14");
                    list.Add("picBox15");
                    list.Add("picBox16");
                    list.Add("picBox17");
                    list.Add("picBox21");
                    list.Add("picBox22");
                    break;
                case 8:
                    list.Add("picBox2");
                    list.Add("picBox5");
                    list.Add("picBox3");
                    list.Add("picBox4");
                    list.Add("picBox8");
                    list.Add("picBox9");
                    list.Add("picBox10");
                    list.Add("picBox11");
                    list.Add("picBox14");
                    list.Add("picBox15");
                    list.Add("picBox16");
                    list.Add("picBox17");
                    list.Add("picBox21");
                    list.Add("picBox22");
                    list.Add("picBox20");
                    list.Add("picBox23");
                    break;
                case 9:
                    list.Add("picBox7");
                    list.Add("picBox13");
                    list.Add("picBox2");
                    list.Add("picBox5");
                    list.Add("picBox3");
                    list.Add("picBox4");
                    list.Add("picBox8");
                    list.Add("picBox9");
                    list.Add("picBox10");
                    list.Add("picBox11");
                    list.Add("picBox14");
                    list.Add("picBox15");
                    list.Add("picBox16");
                    list.Add("picBox17");
                    list.Add("picBox21");
                    list.Add("picBox22");
                    list.Add("picBox20");
                    list.Add("picBox23");
                    break;
                case 10:
                    list.Add("picBox18");
                    list.Add("picBox12");
                    list.Add("picBox7");
                    list.Add("picBox13");
                    list.Add("picBox2");
                    list.Add("picBox5");
                    list.Add("picBox3");
                    list.Add("picBox4");
                    list.Add("picBox8");
                    list.Add("picBox9");
                    list.Add("picBox10");
                    list.Add("picBox11");
                    list.Add("picBox14");
                    list.Add("picBox15");
                    list.Add("picBox16");
                    list.Add("picBox17");
                    list.Add("picBox21");
                    list.Add("picBox22");
                    list.Add("picBox20");
                    list.Add("picBox23");
                    break;
                case 11:
                    list.Add("picBox1");
                    list.Add("picBox6");
                    list.Add("picBox18");
                    list.Add("picBox12");
                    list.Add("picBox7");
                    list.Add("picBox13");
                    list.Add("picBox2");
                    list.Add("picBox5");
                    list.Add("picBox3");
                    list.Add("picBox4");
                    list.Add("picBox8");
                    list.Add("picBox9");
                    list.Add("picBox10");
                    list.Add("picBox11");
                    list.Add("picBox14");
                    list.Add("picBox15");
                    list.Add("picBox16");
                    list.Add("picBox17");
                    list.Add("picBox21");
                    list.Add("picBox22");
                    list.Add("picBox20");
                    list.Add("picBox23");
                    break;
                case 12:
                    list.Add("picBox1");
                    list.Add("picBox6");
                    list.Add("picBox18");
                    list.Add("picBox12");
                    list.Add("picBox7");
                    list.Add("picBox13");
                    list.Add("picBox2");
                    list.Add("picBox5");
                    list.Add("picBox3");
                    list.Add("picBox4");
                    list.Add("picBox8");
                    list.Add("picBox9");
                    list.Add("picBox10");
                    list.Add("picBox11");
                    list.Add("picBox14");
                    list.Add("picBox15");
                    list.Add("picBox16");
                    list.Add("picBox17");
                    list.Add("picBox21");
                    list.Add("picBox22");
                    list.Add("picBox20");
                    list.Add("picBox23");
                    list.Add("picBox19");
                    list.Add("picBox24");
                    break;
            }

            return list;
        }
    }
}

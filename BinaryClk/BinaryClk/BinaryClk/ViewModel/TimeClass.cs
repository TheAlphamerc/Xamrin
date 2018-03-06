using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BinaryClk.ViewModel
{
    class TimeClass : INotifyPropertyChanged
    {
        DateTime datetime;
        string hh, mm, ss;
        public string color1 = "White";
        public string color2 = "White";
        public string color3 = "White";
        public string color4 = "White";

        public string color21 = "White";
        public string color22 = "White";
        public string color23 = "White";
        public string color24 = "White";

        public string color31 = "White";
        public string color32 = "White";
        public string color33 = "White";
        public string color34 = "White";

        public string color41 = "White";
        public string color42 = "White";
        public string color43 = "White";
        public string color44 = "White";

        public string color51 = "White";
        public string color52 = "White";
        public string color53 = "White";
        public string color54 = "White";

        public string color61 = "White";
        public string color62 = "White";
        public string color63 = "White";
        public string color64 = "White";

        public event PropertyChangedEventHandler PropertyChanged;

        public TimeClass()
        {

            this.datetime = DateTime.Now;
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {

                this.datetime = DateTime.Now;
                hh = datetime.Hour.ToString();
                mm = datetime.Minute.ToString();
                ss = datetime.Second.ToString();
                Hr();
                PropertyChanged(this, new PropertyChangedEventArgs("Datetime"));

                PropertyChanged(this, new PropertyChangedEventArgs("HH"));
                PropertyChanged(this, new PropertyChangedEventArgs("MM"));
                PropertyChanged(this, new PropertyChangedEventArgs("SS"));

                return true;
            });
        }

     //   public string T1 { set { t1 = value; } get { return t1; } }

        public string HH { set { hh = value; } get { return hh; } }
        public string MM { set { mm = value; } get { return mm; } }
        public string SS { set { ss = value; } get { return ss; } }
        public DateTime Datetime { set { datetime = value; } get { return datetime; } }

        public void Hr()
        {
            int[] days = new int[5] { 0, 1, 2, 4, 8 };
            string clr; int a = 0, b = 0, c = 0;
            bool flag1 = true;
           

            int SecondOnce = 0, c1 = 0, c2 = 0, c3 = 0, c4 = 0, c7 = 0,c9=0, eight = 8;
           
            SecondOnce = Convert.ToInt32(ss) % 10;

            for (int i = 0; i < 5 && flag1 == true; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    a = days[i]; // Tens 
                    b = days[j]; // Once
                    c = a + b;// Sum
                    if (SecondOnce == c && flag1 == true)
                    {
                        Console.WriteLine("{0},{1}", i, j);
                        flag1 = false;
                        clr = "Sb" + i.ToString();

                        if (a == 1 || b == 1)
                        {
                            c1++;
                        }
                        if (a == 2 || b == 2)
                        {
                            c2++;
                        }
                        if (a == 4 || b == 4)
                        {
                            c3++;
                        }
                        if (a == 8 || b == 8)
                        {
                            c4++;
                        }
                    }
                    if (SecondOnce == (c + 7) && flag1 == true)
                    {
                        flag1 = false;
                        c7++;
                    }


                }
            }
            if (SecondOnce == eight  || SecondOnce == 9)
            {
                 c4++;
            }
            if (SecondOnce == 9)
            {
                c9++;
            }

            bool flagc1 = true, flagc2 = true, flagc3 = true, flagc4 = true,flagc9 = true;
            for (int k = 0; k < 4; k++)
            {
                if (c1 > 0 && flagc1 == true)
                {
                    flagc1 = false;
                    color1 = "BlueViolet";
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb1"));   // 1

                }
               else if (c2 > 0 && flagc2 == true)
                {
                    flagc2 = false;
                    color2 = "BlueViolet";
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb2")); // 2
                }
               else if (c3 > 0 && flagc3 == true)
                {
                    flagc3 = false;
                    color3 = "BlueViolet";
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb3")); //4
                }
              else if (c4 > 0 && flagc4 == true)
                {
                    flagc4 = false;
                    color4 = "BlueViolet";
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb4")); //8
                }
                else if (c7 > 0 && flagc4 == true)
                {
                    flagc1 = false; flagc2 = false;    flagc3 = false;
                    color1 = "BlueViolet"; color2 = "BlueViolet"; color3 = "BlueViolet"; // 1 2 4
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb1"));
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb2"));
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb3"));
                }
                else if (c9 > 0 && flagc9 == true)
                {
                    flagc9 = false;
                    flagc1 = false;flagc4 = false;
                    color1 = "BlueViolet"; color4 = "BlueViolet";
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb4")); // 1 8
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb1"));
                }
                else
                {
                    if( flagc1 == true)
                    {
                        color1 = "White";
                        PropertyChanged(this, new PropertyChangedEventArgs("Sb1"));
                    }
                    if (flagc2 == true)
                    {
                        color2 = "White";
                        PropertyChanged(this, new PropertyChangedEventArgs("Sb2"));
                    }
                    if (flagc3 == true)
                    {
                        color3 = "White";
                        PropertyChanged(this, new PropertyChangedEventArgs("Sb3"));
                    }
                    if (flagc4 == true)
                    {
                        color4 = "White";
                        PropertyChanged(this, new PropertyChangedEventArgs("Sb4"));
                    }
                }
            }

            // ***********************************************************************************************
            int SecondTens = 0, c21 = 0, c22 = 0, c23 = 0, c24 = 0, c27 = 0, c29 = 0, eight_2 = 8;
            SecondTens = Convert.ToInt32(ss) / 10;

            bool flag2 = true;
            for (int i = 0; i < 5 && flag2 == true; i++)
            {
                for (int j = 0; j < 5 && flag2 == true; j++)
                {
                    a = days[i]; // Tens 
                    b = days[j]; // Once
                    c = a + b;// Sum
                    if (SecondTens == c && flag2 == true)
                    {
                    
                        flag2 = false;
                        if (a == 1 || b == 1)
                        {
                            c21++;
                        }
                        if (a == 2 || b == 2)
                        {
                            c22++;
                        }
                        if (a == 4 || b == 4)
                        {
                            c23++;
                        }
                        if (a == 8 || b == 8)
                        {
                            c24++;
                        }
                    }
                    if (SecondTens == (c + 7) && flag2 == true)
                    {
                        flag2 = false;
                        c27++;
                    }


                }
            }
            if (SecondTens == eight_2 || SecondTens == 9)
            {
                c24++;
            }
            if (SecondTens == 9)
            {
                c29++;
            }

            bool flagc21 = true, flagc22 = true, flagc23 = true, flagc24 = true, flagc29 = true;
            for (int k = 0; k < 4; k++)
            {
                if (c21 > 0 && flagc21 == true)
                {
                    flagc21 = false;
                    color21 = "BlueViolet";
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb21"));   // 1

                }
                else if (c22 > 0 && flagc22 == true)
                {
                    flagc22 = false;
                    color22 = "BlueViolet";
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb22")); // 2
                }
                else if (c23 > 0 && flagc23 == true)
                {
                    flagc23 = false;
                    color23 = "BlueViolet";
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb23")); //4
                }
                else if (c24 > 0 && flagc24 == true)
                {
                    flagc24 = false;
                    color24 = "BlueViolet";
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb24")); //8
                }
                else if (c27 > 0 && flagc24 == true)
                {
                    flagc21 = false; flagc22 = false; flagc23 = false;
                    color21 = "BlueViolet"; color22 = "BlueViolet"; color23 = "BlueViolet"; // 1 2 4
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb21"));
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb22"));
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb23"));
                }
                else if (c29 > 0 && flagc29 == true)
                {
                    flagc29 = false;
                    flagc21 = false; flagc24 = false;
                    color21 = "BlueViolet"; color24 = "BlueViolet";
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb24")); // 1 8
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb21"));
                }
                else
                {
                    if (flagc21 == true)
                    {
                        color21 = "White";
                        PropertyChanged(this, new PropertyChangedEventArgs("Sb21"));
                    }
                    if (flagc22 == true)
                    {
                        color22 = "White";
                        PropertyChanged(this, new PropertyChangedEventArgs("Sb22"));
                    }
                    if (flagc23 == true)
                    {
                        color23 = "White";
                        PropertyChanged(this, new PropertyChangedEventArgs("Sb23"));
                    }
                    if (flagc24 == true)
                    {
                        color24 = "White";
                        PropertyChanged(this, new PropertyChangedEventArgs("Sb24"));
                    }
                }
            }
            //************************************************************************************************

            // ***********************************************************************************************
            int MinuteOnce = 0, c31 = 0, c32 = 0, c33 = 0, c34 = 0, c37 = 0, c39 = 0, eight_3 = 8;
            MinuteOnce = Convert.ToInt32(mm) % 10;

            bool flag3 = true;
            for (int i = 0; i < 5 && flag3 == true; i++)
            {
                for (int j = 0; j < 5 && flag3 == true; j++)
                {
                    a = days[i]; // Tens 
                    b = days[j]; // Once
                    c = a + b;// Sum
                    if (MinuteOnce == c && flag3 == true)
                    {

                        flag3 = false;
                        if (a == 1 || b == 1)
                        {
                            c31++;
                        }
                        if (a == 2 || b == 2)
                        {
                            c32++;
                        }
                        if (a == 4 || b == 4)
                        {
                            c33++;
                        }
                        if (a == 8 || b == 8)
                        {
                            c34++;
                        }
                    }
                    if (MinuteOnce == (c + 7) && flag3 == true)
                    {
                        flag3 = false;
                        c37++;
                    }


                }
            }
            if (MinuteOnce == eight_3 || MinuteOnce == 9)
            {
                c3++;
            }
            if (MinuteOnce == 9)
            {
                c39++;
            }

            bool flagc31 = true, flagc32 = true, flagc33 = true, flagc34 = true, flagc39 = true;
            for (int k = 0; k < 4; k++)
            {
                if (c31 > 0 && flagc31 == true)
                {
                    flagc31 = false;
                    color31 = "BlueViolet";
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb31"));   // 1

                }
                else if (c32 > 0 && flagc32 == true)
                {
                    flagc32 = false;
                    color32 = "BlueViolet";
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb32")); // 2
                }
                else if (c33 > 0 && flagc23 == true)
                {
                    flagc33 = false;
                    color33 = "BlueViolet";
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb33")); //4
                }
                else if (c34 > 0 && flagc34 == true)
                {
                    flagc34 = false;
                    color34 = "BlueViolet";
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb34")); //8
                }
                else if (c37 > 0 && flagc34 == true)
                {
                    flagc31 = false; flagc32 = false; flagc33 = false;
                    color31 = "BlueViolet"; color32 = "BlueViolet"; color33 = "BlueViolet"; // 1 2 4
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb31"));
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb32"));
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb33"));
                }
                else if (c39 > 0 && flagc39 == true)
                {
                    flagc39 = false;
                    flagc31 = false; flagc34 = false;
                    color31 = "BlueViolet"; color34 = "BlueViolet";
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb34")); // 1 8
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb31"));
                }
                else
                {
                    if (flagc31 == true)
                    {
                        color31 = "White";
                        PropertyChanged(this, new PropertyChangedEventArgs("Sb31"));
                    }
                    if (flagc32 == true)
                    {
                        color32 = "White";
                        PropertyChanged(this, new PropertyChangedEventArgs("Sb32"));
                    }
                    if (flagc33 == true)
                    {
                        color33 = "White";
                        PropertyChanged(this, new PropertyChangedEventArgs("Sb33"));
                    }
                    if (flagc34 == true)
                    {
                        color34 = "White";
                        PropertyChanged(this, new PropertyChangedEventArgs("Sb34"));
                    }
                }
            }
            //************************************************************************************************

            //************************************************************************************************
            // MINUTE tENS
            // ***********************************************************************************************
            int MinuteTens = 0, c41 = 0, c42 = 0, c43 = 0, c44 = 0, c47 = 0, c49 = 0, eight_4 = 8;
            MinuteTens = Convert.ToInt32(mm) / 10;

            bool flag4 = true;
            for (int i = 0; i < 5 && flag4 == true; i++)
            {
                for (int j = 0; j < 5 && flag4 == true; j++)
                {
                    a = days[i]; // Tens 
                    b = days[j]; // Once
                    c = a + b;// Sum
                    if (MinuteTens == c && flag4 == true)
                    {

                        flag4 = false;
                        if (a == 1 || b == 1)
                        {
                            c41++;
                        }
                        if (a == 2 || b == 2)
                        {
                            c42++;
                        }
                        if (a == 4 || b == 4)
                        {
                            c43++;
                        }
                        if (a == 8 || b == 8)
                        {
                            c44++;
                        }
                    }
                    if (MinuteTens == (c + 7) && flag4 == true)
                    {
                        flag4 = false;
                        c47++;
                    }


                }
            }
            if (MinuteTens == eight_4 || MinuteTens == 9)
            {
                c44++;
            }
            if (MinuteTens == 9)
            {
                c49++;
            }

            bool flagc41 = true, flagc42 = true, flagc43 = true, flagc44 = true, flagc49 = true;
            for (int k = 0; k < 4; k++)
            {
                if (c41 > 0 && flagc41 == true)
                {
                    flagc41 = false;
                    color41 = "BlueViolet";
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb41"));   // 1

                }
                else if (c42 > 0 && flagc42 == true)
                {
                    flagc42 = false;
                    color42 = "BlueViolet";
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb42")); // 2
                }
                else if (c43 > 0 && flagc43 == true)
                {
                    flagc43 = false;
                    color43 = "BlueViolet";
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb43")); //4
                }
                else if (c44 > 0 && flagc44 == true)
                {
                    flagc44 = false;
                    color44 = "BlueViolet";
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb44")); //8
                }
                else if (c47 > 0 && flagc44 == true)
                {
                    flagc41 = false; flagc42 = false; flagc43 = false;
                    color41 = "BlueViolet"; color42 = "BlueViolet"; color43 = "BlueViolet"; // 1 2 4
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb41"));
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb42"));
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb43"));
                }
                else if (c49 > 0 && flagc49 == true)
                {
                    flagc49 = false;
                    flagc41 = false; flagc44 = false;
                    color41 = "BlueViolet"; color44 = "BlueViolet";
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb44")); // 1 8
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb41"));
                }
                else
                {
                    if (flagc41 == true)
                    {
                        color41 = "White";
                        PropertyChanged(this, new PropertyChangedEventArgs("Sb41"));
                    }
                    if (flagc42 == true)
                    {
                        color42 = "White";
                        PropertyChanged(this, new PropertyChangedEventArgs("Sb42"));
                    }
                    if (flagc43 == true)
                    {
                        color43 = "White";
                        PropertyChanged(this, new PropertyChangedEventArgs("Sb43"));
                    }
                    if (flagc44 == true)
                    {
                        color44 = "White";
                        PropertyChanged(this, new PropertyChangedEventArgs("Sb44"));
                    }
                }
            }

            //  ************************************************************************************************
            //     HOURS ONCE

            //            //************************************************************************************************
            //            // MINUTE tENS
            //            // ***********************************************************************************************
            int HourOnce = 0, c51 = 0, c52 = 0, c53 = 0, c54 = 0, c57 = 0, c59 = 0, eight_5 = 8;
            HourOnce = Convert.ToInt32(hh) % 10;

            bool flag5 = true;
            for (int i = 0; i < 5 && flag5 == true; i++)
            {
                for (int j = 0; j < 5 && flag5 == true; j++)
                {
                    a = days[i]; // Tens 
                    b = days[j]; // Once
                    c = a + b;// Sum
                    if (HourOnce == c && flag5 == true)
                    {

                        flag5 = false;
                        if (a == 1 || b == 1)
                        {
                            c51++;
                        }
                        if (a == 2 || b == 2)
                        {
                            c52++;
                        }
                        if (a == 4 || b == 4)
                        {
                            c53++;
                        }
                        if (a == 8 || b == 8)
                        {
                            c54++;
                        }
                    }
                    if (HourOnce == 7 && flag5 == true)
                    {
                        flag5 = false;
                        c57++;
                    }


                }
            }
            if (HourOnce == eight_5 || HourOnce == 9)
            {
                c54++;
            }
            if (HourOnce == 9)
            {
                c59++;
            }

            bool flagc51 = true, flagc52 = true, flagc53 = true, flagc54 = true, flagc59 = true ,StopElse=true;
            for (int k = 0; k < 4; k++)
            {
                if (c51 > 0 && flagc51 == true)
                {
                    flagc51 = false;
                    color51 = "BlueViolet";
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb51"));   // 1

                }
                else if (c52 > 0 && flagc52 == true)
                {
                    flagc52 = false;
                    color52 ="LightGreen";
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb52")); // 2
                }
                else if (c53 > 0 && flagc53 == true)
                {
                    flagc53 = false;
                    color53 = "BlueViolet";
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb53")); //4
                }
                else if (c54 > 0 && flagc54 == true)
                {
                    flagc54 = false;
                    color54 = "BlueViolet";
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb54")); //8
                }
                else if (c57 > 0)
                {
                    flagc51 = false; flagc52 = false; flagc53 = false;
                    color51 = "BlueViolet"; color52 = "BlueViolet"; color53 = "BlueViolet"; // 1 2 4
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb51"));
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb52"));
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb53"));
                }
                else if (c59 > 0 && flagc59 == true)
                {
                    flagc59 = false;
                    flagc51 = false; flagc54 = false;
                    color51 = "BlueViolet"; color54 = "BlueViolet";
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb54")); // 1 8
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb51"));
                }
                else
                { 
                        if (flagc51 == true)
                        {
                            color51 = "White";
                            PropertyChanged(this, new PropertyChangedEventArgs("Sb51"));
                        }
                        if (flagc52 == true)
                        {
                            color52 = "White";
                            PropertyChanged(this, new PropertyChangedEventArgs("Sb52"));
                        }
                        if (flagc53 == true)
                        {
                            color53 = "White";
                            PropertyChanged(this, new PropertyChangedEventArgs("Sb53"));
                        }
                        if (flagc54 == true)
                        {
                            color54 = "White";
                            PropertyChanged(this, new PropertyChangedEventArgs("Sb54"));
                        }
                       
                  
                    
                }
            }
            //************************************************************************************************
            //                     HOURS TENS
            int HourTens = 0, c61 = 0, c62 = 0, c63 = 0, c64 = 0, c67 = 0, c69 = 0, eight_6 = 8;
            HourTens = Convert.ToInt32(hh) / 10;

            bool flag6 = true;
            for (int i = 0; i < 5 && flag6 == true; i++)
            {
                for (int j = 0; j < 5 && flag6 == true; j++)
                {
                    a = days[i]; // Tens 
                    b = days[j]; // Once
                    c = a + b;// Sum
                    if (HourTens == c && flag6 == true)
                    {

                        flag6 = false;
                        if (a == 1 || b == 1)
                        {
                            c61++;
                        }
                        if (a == 2 || b == 2)
                        {
                            c62++;
                        }
                        if (a == 4 || b == 4)
                        {
                            c63++;
                        }
                        if (a == 8 || b == 8)
                        {
                            c64++;
                        }
                    }
                    if (HourTens == (c + 7) && flag6 == true)
                    {
                        flag6 = false;
                        c67++;
                    }


                }
            }
            if (HourTens == eight_6 || HourTens == 9)
            {
                c64++;
            }
            if (HourTens == 9)
            {
                c69++;
            }

            bool flagc61 = true, flagc62 = true, flagc63 = true, flagc64 = true, flagc69 = true;
            for (int k = 0; k < 4; k++)
            {
                if (c61 > 0 && flagc61 == true)
                {
                    flagc61 = false;
                    color61 = "BlueViolet";
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb61"));   // 1

                }
                else if (c62 > 0 && flagc62 == true)
                {
                    flagc62 = false;
                    color62 = "BlueViolet";
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb62")); // 2
                }
                else if (c63 > 0 && flagc63 == true)
                {
                    flagc63 = false;
                    color63 = "BlueViolet";
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb63")); //4
                }
                else if (c64 > 0 && flagc64 == true)
                {
                    flagc64 = false;
                    color64 = "BlueViolet";
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb64")); //8
                }
                else if (c67 > 0 && flagc64 == true)
                {
                    flagc61 = false; flagc62 = false; flagc63 = false;
                    color61 = "BlueViolet"; color62 = "BlueViolet"; color63 = "BlueViolet"; // 1 2 4
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb61"));
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb62"));
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb63"));
                }
                else if (c69 > 0 && flagc69 == true)
                {
                    flagc69 = false;
                    flagc61 = false; flagc64 = false;
                    color61 = "BlueViolet"; color64 = "BlueViolet";
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb64")); // 1 8
                    PropertyChanged(this, new PropertyChangedEventArgs("Sb61"));
                }
                else
                {
                    if (flagc61 == true)
                    {
                        color61 = "White";
                        PropertyChanged(this, new PropertyChangedEventArgs("Sb61"));
                    }
                    if (flagc62 == true)
                    {
                        color62 = "White";
                        PropertyChanged(this, new PropertyChangedEventArgs("Sb62"));
                    }
                    if (flagc63 == true)
                    {
                        color63 = "White";
                        PropertyChanged(this, new PropertyChangedEventArgs("Sb63"));
                    }
                    if (flagc64 == true)
                    {
                        color64 = "White";
                        PropertyChanged(this, new PropertyChangedEventArgs("Sb64"));
                    }
                }
            }
            //************************************************************************************************





        }

        public string Sb1 { set { color1 = value;  } get { return color1; } }
        public string Sb2 { set { color2 = value;  } get { return color2; } }
        public string Sb3 { set { color3 = value;  } get { return color3; } }
        public string Sb4 { set { color4 = value;  } get { return color4; } }

        public string Sb21 { set { color21 = value;  } get { return color21; } }
        public string Sb22 { set { color22 = value;  } get { return color22; } }
        public string Sb23 { set { color23 = value;  } get { return color23; } }
        public string Sb24 { set { color24 = value;  } get { return color24; } }


        public string Sb31 { set { color31 = value; } get { return color31; } }
        public string Sb32 { set { color32 = value; } get { return color32; } }
        public string Sb33 { set { color33 = value; } get { return color33; } }
        public string Sb34 { set { color34 = value; } get { return color34; } }

        public string Sb41 { set { color41 = value; } get { return color41; } }
        public string Sb42 { set { color42 = value; } get { return color42; } }
        public string Sb43 { set { color43 = value; } get { return color43; } }
        public string Sb44 { set { color44 = value; } get { return color44; } }


        public string Sb51 { set { color51 = value; } get { return color51; } }
        public string Sb52 { set { color52 = value; } get { return color52; } }
        public string Sb53 { set { color53 = value; } get { return color53; } }
        public string Sb54 { set { color54 = value; } get { return color54; } }

        public string Sb61 { set { color61 = value; } get { return color61; } }
        public string Sb62 { set { color62 = value; } get { return color62; } }
        public string Sb63 { set { color63 = value; } get { return color63; } }
        public string Sb64 { set { color64 = value; } get { return color64; } }


    }
}

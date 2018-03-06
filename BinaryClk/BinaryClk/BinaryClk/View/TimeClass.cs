//using System;
//using System.Collections.Generic;
//using System.Text;
//using Xamarin.Forms;
//using System.ComponentModel;
//using System.Runtime.CompilerServices;

//namespace BinaryClk.ViewModel
//{
//    class TimeClass : INotifyPropertyChanged
//    {
//        DateTime datetime;
//        string hh, mm, ss;
//        public string color1 = "White";
//        public string color2 = "White";
//        public string color3 = "White";
//        public string color4 = "White";

//        public string t1 = "TT";

//        public string color21 = "White";
//        public string color22 = "White";
//        public string color23 = "White";
//        public string color24 = "White";

//        public event PropertyChangedEventHandler PropertyChanged;

//        public TimeClass()
//        {

//            this.datetime = DateTime.Now;
//            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
//            {

//                this.datetime = DateTime.Now;
//                hh = datetime.Hour.ToString();
//                mm = datetime.Minute.ToString();
//                ss = datetime.Second.ToString();
//                Hr();
//                PropertyChanged(this, new PropertyChangedEventArgs("Datetime"));

//                PropertyChanged(this, new PropertyChangedEventArgs("HH"));
//                PropertyChanged(this, new PropertyChangedEventArgs("MM"));
//                PropertyChanged(this, new PropertyChangedEventArgs("SS"));

//                return true;
//            });
//        }

//        public string T1 { set { t1 = value; } get { return t1; } }

//        public string HH { set { hh = value; } get { return hh; } }
//        public string MM { set { mm = value; } get { return mm; } }
//        public string SS { set { ss = value; } get { return ss; } }
//        public DateTime Datetime { set { datetime = value; } get { return datetime; } }

//        public void Hr()
//        {
//            int[] days = new int[5] { 0, 1, 2, 4, 8 };
//            string clr; int a = 0, b = 0, c = 0;
//            bool flag1 = true;

//            int SecondOnce = 0, SecondTens = 0, c1 = 0, c2 = 0, c3 = 0, c4 = 0, c7 = 0,c9=0, eight = 8;
//            SecondTens = Convert.ToInt32(ss) / 10;
//            SecondOnce = Convert.ToInt32(ss) % 10;

//            for (int i = 0; i < 5 && flag1 == true; i++)
//            {
//                for (int j = 0; j < 5; j++)
//                {
//                    a = days[i]; // Tens 
//                    b = days[j]; // Once
//                    c = a + b;// Sum
//                    if (SecondOnce == c && flag1 == true)
//                    {
//                        Console.WriteLine("{0},{1}", i, j);
//                        flag1 = false;
//                        clr = "Sb" + i.ToString();

//                        if (a == 1 || b == 1)
//                        {
//                            c1++;
//                        }
//                        if (a == 2 || b == 2)
//                        {
//                            c2++;
//                        }
//                        if (a == 4 || b == 4)
//                        {
//                            c3++;
//                        }
//                        if (a == 8 || b == 8)
//                        {
//                            c4++;
//                        }
//                    }
//                    if (SecondOnce == (c + 7) && flag1 == true)
//                    {
//                        flag1 = false;
//                        c7++;
//                    }


//                }
//            }
//            if (SecondOnce == eight  || SecondOnce == 9)
//            {
//                 c4++;
//            }
//            if (SecondOnce == 9)
//            {
//                c9++;
//            }

//            bool flagc1 = true, flagc2 = true, flagc3 = true, flagc4 = true,flagc9 = true;
//            for (int k = 0; k < 4; k++)
//            {
//                if (c1 > 0 && flagc1 == true)
//                {
//                    flagc1 = false;
//                    color1 = "BlueViolet";
//                    PropertyChanged(this, new PropertyChangedEventArgs("Sb1"));   // 1

//                }
//               else if (c2 > 0 && flagc2 == true)
//                {
//                    flagc2 = false;
//                    color2 = "BlueViolet";
//                    PropertyChanged(this, new PropertyChangedEventArgs("Sb2")); // 2
//                }
//               else if (c3 > 0 && flagc3 == true)
//                {
//                    flagc3 = false;
//                    color3 = "BlueViolet";
//                    PropertyChanged(this, new PropertyChangedEventArgs("Sb3")); //4
//                }
//              else if (c4 > 0 && flagc4 == true)
//                {
//                    flagc4 = false;
//                    color4 = "BlueViolet";
//                    PropertyChanged(this, new PropertyChangedEventArgs("Sb4")); //8
//                }
//                else if (c7 > 0 && flagc4 == true)
//                {
//                    flagc1 = false; flagc2 = false;    flagc3 = false;
//                    color1 = "BlueViolet"; color2 = "BlueViolet"; color3 = "BlueViolet"; // 1 2 4
//                    PropertyChanged(this, new PropertyChangedEventArgs("Sb1"));
//                    PropertyChanged(this, new PropertyChangedEventArgs("Sb2"));
//                    PropertyChanged(this, new PropertyChangedEventArgs("Sb3"));
//                }
//                else if (c9 > 0 && flagc9 == true)
//                {
//                    flagc9 = false;
//                    flagc1 = false;flagc4 = false;
//                    color1 = "BlueViolet"; color4 = "BlueViolet";
//                    PropertyChanged(this, new PropertyChangedEventArgs("Sb4")); // 1 8
//                    PropertyChanged(this, new PropertyChangedEventArgs("Sb1"));
//                }
//                else
//                {
//                    if( flagc1 == true)
//                    {
//                        color1 = "White";
//                        PropertyChanged(this, new PropertyChangedEventArgs("Sb1"));
//                    }
//                    if (flagc2 == true)
//                    {
//                        color2 = "White";
//                        PropertyChanged(this, new PropertyChangedEventArgs("Sb2"));
//                    }
//                    if (flagc3 == true)
//                    {
//                        color3 = "White";
//                        PropertyChanged(this, new PropertyChangedEventArgs("Sb3"));
//                    }
//                    if (flagc4 == true)
//                    {
//                        color4 = "White";
//                        PropertyChanged(this, new PropertyChangedEventArgs("Sb4"));
//                    }
//                }
//            }
              
//        }

//        public string Sb1 { set { color1 = value;  } get { return color1; } }
//        public string Sb2 { set { color2 = value;  } get { return color2; } }
//        public string Sb3 { set { color3 = value;  } get { return color3; } }
//        public string Sb4 { set { color4 = value;  } get { return color4; } }

//        public string Sb21 { set { color21 = value;  } get { return color21; } }
//        public string Sb22 { set { color22 = value;  } get { return color22; } }
//        public string Sb23 { set { color23 = value;  } get { return color23; } }
//        public string Sb24
//        {
//            set { color24 = value;  }
//            get { return color24; }
//        }

//    }
//}

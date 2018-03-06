
//            //************************************************************************************************
//            // MINUTE tENS
//            // ***********************************************************************************************
//            int HourTens = 0, c61 = 0, c62 = 0, c63 = 0, c64 = 0, c67 = 0, c69 = 0, eight_6 = 28;
//            HourTens = Convert.ToInt32(mm) % 10;

//            bool flag6 = true;
//            for (int i = 0; i < 5 && flag6 == true; i++)
//            {
//                for (int j = 0; j < 5 && flag6 == true; j++)
//                {
//                    a = days[i]; // Tens 
//                    b = days[j]; // Once
//                    c = a + b;// Sum
//                    if (HourTens == c && flag6 == true)
//                    {

//                        flag6 = false;
//                        if (a == 1 || b == 1)
//                        {
//                            c61++;
//                        }
//                        if (a == 2 || b == 2)
//                        {
//                            c62++;
//                        }
//                        if (a == 4 || b == 4)
//                        {
//                            c63++;
//                        }
//                        if (a == 8 || b == 8)
//                        {
//                            c64++;
//                        }
//                    }
//                    if (HourTens == (c + 7) && flag6 == true)
//                    {
//                        flag6 = false;
//                        c67++;
//                    }


//                }
//            }
//            if (HourTens == eight_6 || HourTens == 9)
//            {
//                c4++;
//            }
//            if (HourTens == 9)
//            {
//                c69++;
//            }

//            bool flagc61 = true, flagc62 = true, flagc63 = true, flagc64 = true, flagc69 = true;
//            for (int k = 0; k < 4; k++)
//            {
//                if (c61 > 0 && flagc61 == true)
//                {
//                    flagc61 = false;
//                    color61 = "BlueViolet";
//                    PropertyChanged(this, new PropertyChangedEventArgs("Sb61"));   // 1

//                }
//                else if (c62 > 0 && flagc62 == true)
//                {
//                    flagc62 = false;
//                    color62 = "BlueViolet";
//                    PropertyChanged(this, new PropertyChangedEventArgs("Sb62")); // 2
//                }
//                else if (c63 > 0 && flagc63 == true)
//                {
//                    flagc63 = false;
//                    color63 = "BlueViolet";
//                    PropertyChanged(this, new PropertyChangedEventArgs("Sb63")); //4
//                }
//                else if (c64 > 0 && flagc64 == true)
//                {
//                    flagc64 = false;
//                    color64 = "BlueViolet";
//                    PropertyChanged(this, new PropertyChangedEventArgs("Sb64")); //8
//                }
//                else if (c67 > 0 && flagc64 == true)
//                {
//                    flagc61 = false; flagc62 = false; flagc63 = false;
//                    color61 = "BlueViolet"; color62 = "BlueViolet"; color63 = "BlueViolet"; // 1 2 4
//                    PropertyChanged(this, new PropertyChangedEventArgs("Sb61"));
//                    PropertyChanged(this, new PropertyChangedEventArgs("Sb62"));
//                    PropertyChanged(this, new PropertyChangedEventArgs("Sb63"));
//                }
//                else if (c69 > 0 && flagc69 == true)
//                {
//                    flagc69 = false;
//                    flagc61 = false; flagc64 = false;
//                    color61 = "BlueViolet"; color64 = "BlueViolet";
//                    PropertyChanged(this, new PropertyChangedEventArgs("Sb64")); // 1 8
//                    PropertyChanged(this, new PropertyChangedEventArgs("Sb61"));
//                }
//                else
//                {
//                    if (flagc61 == true)
//                    {
//                        color61 = "White";
//                        PropertyChanged(this, new PropertyChangedEventArgs("Sb61"));
//                    }
//                    if (flagc62 == true)
//                    {
//                        color62 = "White";
//                        PropertyChanged(this, new PropertyChangedEventArgs("Sb62"));
//                    }
//                    if (flagc63 == true)
//                    {
//                        color63 = "White";
//                        PropertyChanged(this, new PropertyChangedEventArgs("Sb63"));
//                    }
//                    if (flagc64 == true)
//                    {
//                        color64 = "White";
//                        PropertyChanged(this, new PropertyChangedEventArgs("Sb64"));
//                    }
//                }
//            }
//            //************************************************************************************************


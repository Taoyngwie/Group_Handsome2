enum MenuChooseTime { BM_BKT = 1, BKT_BM = 2}

class Program
{
    public static void Main(string[] args)
    {
        PrintMenuTime();
    }

    public static void PrintMenuTime()
    {
        Console.WriteLine("1.BangMod to BangKhunThian ");
        Console.WriteLine("2.BangKhunThian to BangMod");
        Console.Write("Please Input Menu : ");
        MenuChooseTime menuChooseTime = (MenuChooseTime)(int.Parse(Console.ReadLine()));
        PresentMenuChooseTime(menuChooseTime);
    }

    public static void PresentMenuChooseTime(MenuChooseTime menuChooseTime)
    {
        switch(menuChooseTime)
        {
            case MenuChooseTime.BM_BKT :
                ShowTimeBM_BKT();
                break;
            case MenuChooseTime.BKT_BM :
                showTimeBKT_BM();
                break;
            default:
                break;
        }
    }

    public static void ShowTimeBM_BKT()
    {
        Console.WriteLine("1. 07:30");
        Console.WriteLine("2. 08:00");
        Console.WriteLine("3. 08:15");
        Console.WriteLine("4. 08:30");
        Console.WriteLine("5. 12:00");
        Console.WriteLine("6. 14:00");
        Console.WriteLine("7. 16:00");

            int i = int.Parse(Console.ReadLine());
            if(i == 1)
            {
                return "07:30";
            }
            else if(i == 2)
            {
                return "08.00";
            }
            else if(i == 3)
            {
                return "08:15";
            }
            else if(i == 4)
            {
                return "08:30";
            }
            else if(i == 5)
            {
                return "12:00";
            }
            else if(i == 6)
            {
                return "14:00";
            }
            else if(i == 7)
            {
                return "16:00";
            }    
        
    }
    public static void showTimeBKT_BM()
    {
        Console.WriteLine("1. 07:00");
        Console.WriteLine("2. 10:00");
        Console.WriteLine("3. 13:00");
        Console.WriteLine("4. 15:00");
        Console.WriteLine("5. 16:30");
        Console.WriteLine("6. 17:00");
        Console.WriteLine("7. 17:30");
        Console.WriteLine("8. 18:00");
            int i = int.Parse(Console.ReadLine());
            if(i == 1)
            {
                return "07:00";
            }
            else if(i == 2)
            {
                return "10:00";
            }
            else if(i == 3)
            {
                return "13:00";
            }
            else if(i == 4)
            {
                return "15:00";
            } 
            else if(i == 5)
            {
                return "16:30";
            } 
            else if(i == 6)
            {
                return "17:00";
            } 
            else if(i == 7)
            {
                return "17:30";
            } 
            else if(i == 8)
            {
                return "18:30";
            }    
        
    }
    
}
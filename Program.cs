enum Menu {
    Register = 1, Login
}
enum MenuII {
    Register = 1, BangModToBangKhunTien, BangKhunTienToBangMod, Logout
}
class Program {
    static RegisterInfoList registerList;
    public static void DeclareQueue() {
        Queue<string> BM_BKT07_30 = new Queue<string>();
        Queue<string> BM_BKT08_00 = new Queue<string>();
        Queue<string> BM_BKT08_15 = new Queue<string>();
        Queue<string> BM_BKT08_30 = new Queue<string>();
        Queue<string> BM_BKT12_00 = new Queue<string>();
        Queue<string> BM_BKT14_00 = new Queue<string>();
        Queue<string> BM_BKT16_00 = new Queue<string>();

        Queue<string> BKT_BM07_00 = new Queue<string>();
        Queue<string> BKT_BM10_00 = new Queue<string>();
        Queue<string> BKT_BM13_00 = new Queue<string>();
        Queue<string> BKT_BM15_00 = new Queue<string>();
        Queue<string> BKT_BM16_30 = new Queue<string>();
        Queue<string> BKT_BM17_00 = new Queue<string>();
        Queue<string> BKT_BM17_30 = new Queue<string>();
        Queue<string> BKT_BM18_30 = new Queue<string>();
    }
    public static void main(string[] args) {
        
        DeclareQueue();
        while(true) {
            string text = DateTime.Now.ToLongTimeString();
            Console.WriteLine(text);
            Thread.Sleep(1000);//เรียกต่อ1วินาที

            if(text == "07:00:00" ) { //บางขุน
                Console.WriteLine("Time Table : 07:00:00");
                for(int Number = 0; Number <= BM_BKT07_30.GetLength()-1; Number++) {
                    Console.WriteLine("{0}. {1}", Number+1, BM_BKT07_30.Get(Number));
                }
            }
            else if(text == "07:30:00") {
                
            }
            else if(text == "08:00:00") {
                
            }
            else if(text == "08:15:00") {
                
            }
            else if(text == "08:30:00") {
                
            }
            else if(text == "07:00:00") { //บางขุน
                
            }
            else if(text == "10:00:00") { //บางขุน
                
            }
            else if(text == "12:00:00") {
                
            }
            else if(text == "13:00:00") { //บางขุน
                
            }
            else if(text == "14:00:00") {
                
            }
            else if(text == "15:00:00") { //บางขุน
                
            }
            else if(text == "16:00:00") {
                
            }
            else if(text == "16:30:00") { //บางขุน
                
            }
            else if(text == "17:00:00") { //บางขุน
                
            }
            else if(text == "17:30:00") { //บางขุน
                
            }
            else if(text == "18:30:00") { //บางขุน
                
            }
            PrepareRegisterListWhenProgramIsLoad();
            PrintMenuScreen();
        }
        
    }
    static void PrintMenuScreen()
    {
        Console.Clear();

        PrintFirstListMenu();
        InputMenuFromKeyboard();
    }

    static void PrintFirstListMenu()
    {
        Console.WriteLine("Welcome to KMUTT Bus Booking");
        Console.WriteLine("*******************************************************");
        Console.WriteLine("1. Register");
        Console.WriteLine("2. Login");
        Console.WriteLine("Any number to end this program.");
        Console.WriteLine("*******************************************************");
    }

    static void PrintSecondListMenu()
    {
        Console.WriteLine("Welcome to KMUTT Bus Booking");
        Console.WriteLine("*******************************************************");
        Console.WriteLine("1. Register");
        Console.WriteLine("2. BangMod - BangKhunTien");
        Console.WriteLine("3. BangKhunTie - BangMod");
        Console.WriteLine("4. Logout");
        Console.WriteLine("*******************************************************");
    }

    static void InputMenuFromKeyboard()
    {
        Console.Write("Please Input Menu: ");
        Menu menu = (Menu)(int.Parse(Console.ReadLine())); 

        PresentMenu(menu);
    }

    static void InputMenuIIFromKeyboard()
    {
        Console.Write("Please Input Menu: ");
        MenuII menuII = (MenuII)(int.Parse(Console.ReadLine())); 

        PresentMenu(menuII);
    }

    static void PresentMenu(Menu menu)
    {
        switch (menu)
        {
            case Menu.Register:
                ShowInputRegister();
                break;

            case Menu.Login:
                Login();
                break;

            default:
                break;
        }
    }

     static void PresentMenu(MenuII menuII)
    {
        switch (menuII)
        {
            case MenuII.Register:
                ShowInputRegister();
                break;

            case MenuII.BangModToBangKhunTien:
                Logout();
                break;

            case MenuII.BangKhunTienToBangMod:
                Logout();
                break;

            case MenuII.Logout:
                Logout();
                break;

            default:
                BlackToMenuII();
                break;
        }
    }

     static void ShowInputRegister()
    {
        Console.Clear();

        Console.WriteLine("Register for KMUTT Bus Booking");
        Console.WriteLine("*****************************************");

        Console.WriteLine("Input Your Type");
        Console.WriteLine("1.College Student.");
        Console.WriteLine("2.Teacher.");
            for(int i = 0; i  <= 0;)
            {
                int s = int.Parse(Console.ReadLine());
                if (s == 1)
                {
                    InputCollegeStudentInfoFromKeyboard();
                    i++;
                }

                else if (s == 3)
                {
                    InputTeacherInfoFromKeyboard();
                    i++;
                }

                else
                {
                    Console.WriteLine("Please Enter only 1 or 2 :");             
                }
            }
          BlackToMenu();
    } 

    static void InputCollegeStudentInfoFromKeyboard()
    {
        StudentInfo student = new StudentInfo(InputTitle(), InputName(), InputLast(),InputStudentID(),InputEmail(), InputPassword());
        Program.registerList.AddNewPerson(student);
    }

    static void InputTeacherInfoFromKeyboard()
    {
        TeacherInfo teacher = new TeacherInfo(InputTitle(), InputName(), InputLast(),InputEmail(), InputPassword());
        Program.registerList.AddNewPerson(teacher);
    }

    static void Login()
    {
        Console.WriteLine("Login");
        Console.WriteLine("***************************");
        Console.WriteLine("Input Email: ");
        string mail = Console.ReadLine();
        Console.WriteLine("Input Password: ");
        string pass = Console.ReadLine();

        if(mail == "exit")
        {
            PrintMenuScreen();
        }
        else if(Program.registerList.CheckLogin(mail, pass))
        {
            BlackToMenuII();
        }
        else
        {
            Login();
        }
    }

    static void Logout()
    {
        Console.Clear();
        BlackToMenu();
    }

    static void BlackToMenu()
    {
        Console.Clear();
        PrintFirstListMenu();
        InputMenuFromKeyboard();
    }

    static void BlackToMenuII()
    {
        Console.Clear();
        PrintSecondListMenu();
        InputMenuIIFromKeyboard();
    }

     static void PrepareRegisterListWhenProgramIsLoad()
    {
        Program.registerList = new RegisterInfoList();
    }

    static string InputName()
    {
        Console.Write("Name: ");

        return Console.ReadLine();
    }

    static string InputStudentID()
    {
        Console.Write("StudentID: ");

        return Console.ReadLine();
    }

    static string InputLast()
    {
        Console.Write("Last Name: ");

        return Console.ReadLine();
    }

    static string InputEmail()
    {
       Console.Write("Email: ");

        return Console.ReadLine(); 
    }

    static string InputPassword()
    {
       Console.Write("Password: ");

        return Console.ReadLine(); 
    }

    static string InputTitle()
    {
        Console.WriteLine("Input Your Title Name");
        Console.WriteLine("1.Mr.");
        Console.WriteLine("2.Mrs.");
        Console.WriteLine("3.Miss.");
        for(int i = 0; i  <= 0;)
            {
                int s = int.Parse(Console.ReadLine());
                if (s == 1)
                {
                    return  "Mr.";
                    i++;
                }

                else if (s == 2)
                {
                    return "Mrs.";
                    i++;
                }

                else if (s == 3)
                {
                    return "Miss.";
                    i++;
                }

                else
                {
                    Console.WriteLine("Please Enter only 1-3 :");             
                }
            }
            return null;
    }
    public static void TimeCheck() { //รับค่า Person login
        
    }
    
}
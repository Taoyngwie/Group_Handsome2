class Program {
    
    public static void main(string[] args) {
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
    public static void TimeCheck() { //รับค่า Person login
        while(true) {
            string text = DateTime.Now.ToLongTimeString();
            Console.WriteLine(text);
            Thread.Sleep(1000);//เรียกต่อ1วินาที

            if(text == "07:00:00" ) { //บางขุน
                for(int Number = 0; Number <= 1; Number++) {

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
        }
    }
    
}
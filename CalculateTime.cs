class CalculateTime {
    private Queue<string> BM_BKT07_30 = new Queue<string>();
    private Queue<string> BM_BKT08_00 = new Queue<string>();
    private Queue<string> BM_BKT08_15 = new Queue<string>();
    private Queue<string> BM_BKT08_30 = new Queue<string>();
    private Queue<string> BM_BKT12_00 = new Queue<string>();
    private Queue<string> BM_BKT14_00 = new Queue<string>();
    private Queue<string> BM_BKT16_00 = new Queue<string>();

    private Queue<string> BKT_BM07_00 = new Queue<string>();
    private Queue<string> BKT_BM10_00 = new Queue<string>();
    private Queue<string> BKT_BM13_00 = new Queue<string>();
    private Queue<string> BKT_BM15_00 = new Queue<string>();
    private Queue<string> BKT_BM16_30 = new Queue<string>();
    private Queue<string> BKT_BM17_00 = new Queue<string>();
    private Queue<string> BKT_BM17_30 = new Queue<string>();
    private Queue<string> BKT_BM18_30 = new Queue<string>();

    public CalculateTime(Queue<string> BM_BKT07_30, Queue<string> BM_BKT08_00, Queue<string> BM_BKT08_15, Queue<string> BM_BKT08_30, Queue<string> BM_BKT12_00, Queue<string> BM_BKT14_00
    ,Queue<string> BM_BKT16_00, Queue<string> BKT_BM07_00, Queue<string> BKT_BM10_00, Queue<string> BKT_BM13_00, Queue<string> BKT_BM15_00, Queue<string> BKT_BM16_30, Queue<string> BKT_BM17_00
    , Queue<string> BKT_BM17_30, Queue<string> BKT_BM18_30) 
    {
        this.BM_BKT07_30 = BM_BKT07_30;
        this.BM_BKT08_00 = BM_BKT08_00; 
        this.BM_BKT08_15 = BM_BKT08_15; 
        this.BM_BKT08_30 = BM_BKT08_30; 
        this.BM_BKT12_00 = BM_BKT12_00;  
        this.BM_BKT14_00 = BM_BKT14_00; 
        this.BM_BKT16_00 = BM_BKT16_00; 

        this.BKT_BM07_00 = BKT_BM07_00;
        this.BKT_BM10_00 = BKT_BM10_00; 
        this.BKT_BM13_00 = BKT_BM13_00; 
        this.BKT_BM15_00 = BKT_BM15_00; 
        this.BKT_BM16_30 = BKT_BM16_30; 
        this.BKT_BM17_00 = BKT_BM17_00; 
        this.BKT_BM17_30 = BKT_BM17_30;
        this.BKT_BM18_30 = BKT_BM18_30;    
    }
    public Queue<string> GetBM_BKT07_30() {
        return this.BM_BKT07_30;
    }
    public Queue<string> GetBM_BKT08_00() {
        return this.BM_BKT08_00;
    }
    public Queue<string> GetBM_BKT08_15() {
        return this.BM_BKT08_15;
    }
    public Queue<string> GetBM_BKT08_30() {
        return this.BM_BKT08_30;
    }
    public Queue<string> GetBM_BKT12_00() {
        return this.BM_BKT12_00;
    }
    public Queue<string> GetBM_BKT14_00() {
        return this.BM_BKT14_00;
    }
    public Queue<string> GetBM_BKT16_00() {
        return this.BM_BKT16_00;
    }
    public Queue<string> GetBKT_BM07_00() {
        return this.BKT_BM07_00;
    }
    public Queue<string> GetBKT_BM10_00() {
        return this.BKT_BM10_00;
    }
    public Queue<string> GetBKT_BM13_00() {
        return this.BKT_BM13_00;
    }
    public Queue<string> GetBKT_BM15_00() {
        return this.BKT_BM15_00;
    }
    public Queue<string> GetBKT_BM16_30() {
        return this.BKT_BM16_30;
    }
    public Queue<string> GetBKT_BM17_00() {
        return this.BKT_BM17_00;
    }
    public Queue<string> GetBKT_BM18_30() {
        return this.BKT_BM18_30;
    }
    

}
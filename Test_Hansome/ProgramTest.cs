namespace Test_Hansome;

public class ProgramTest
{
    Info mockInfoProgram = new Info("Mr.", "Satchapum", "Krailertrat");

    Program program = new Program();
    [Fact]
    public void TestPrintNotification()
    {
        bool IsTrueTime = false;
    }

    [Fact]
    public void ShowTimeBM_BKT_07_30()
    {

        Assert.Equal(Program.ShowTimeBM_BKT(), "07:30");
    }

    [Fact]
    public void ShowTimeBM_BKT_13_30()
    {

        Assert.Equal(Program.ShowTimeBM_BKT(), "13:30");
    }

    [Fact]
    public void showTimeBKT_BM_10_00()
    {

        Assert.Equal(Program.showTimeBKT_BM(), "10:00");
    }

    [Fact]
    public void InputTitleMr_()
    {

        Assert.Equal(Program.InputTitle(), "Mr.");
    }

    [Fact]
    public void InputTitleMr_()
    {

        Assert.Equal(Program.InputTitle(), "Mrs.");
    }



}
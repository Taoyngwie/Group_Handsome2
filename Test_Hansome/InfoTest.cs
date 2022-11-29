namespace Test_Hansome;

public class InfoTest
{
    Info mockInfo = new Info("Mr.", "Satchapum", "Krailertrat");

    [Fact]
    public void TestCreateNewStudent() {

        Assert.IsType<Info>(mockInfo);
    }

    [Fact]
    public void TestGetFullName() {

        Assert.Equal(mockInfo.GetFullName(), "Mr.Satchapum Krailertrat");
    }

    [Fact]
    public void TestGetTitle() {

        Assert.Equal(mockInfo.GetTitle(), "Mr.");
    }

    [Fact]
    public void TestGetName() {

        Assert.Equal(mockInfo.GetName(), "Satchapum");
    }

    [Fact]
    public void TestGetLastName() {

        Assert.Equal(mockInfo.GetLastName(), "Krailertrat");
    }
}
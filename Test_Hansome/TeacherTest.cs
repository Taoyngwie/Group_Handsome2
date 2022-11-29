namespace Test_Hansome;

public class TeacherTest
{
    TeacherInfo mockTeacher = new TeacherInfo("Mr.", "Satchapum", "Krailertrat", "Satchapum@gmail.com", "1234abc");

    [Fact]
    public void TestCreateNewStudent() {

        Assert.IsType<TeacherInfo>(mockTeacher);
    }

    [Fact]
    public void TestGetEmail() {

        Assert.Equal(mockTeacher.GetEmail(), "Satchapum@gmail.com");
    }

    [Fact]
    public void TestGetPassword() {

        Assert.Equal(mockTeacher.GetPassword(), "1234abc");
    }
}
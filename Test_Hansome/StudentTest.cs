namespace Test_Hansome;

public class StudentTest
{
    StudentInfo mockStudent = new StudentInfo("Mr.", "Satchapum", "Krailertrat", "64120501031", "Satchapum@gmail.com", "1234abc");

    [Fact]
    public void TestCreateNewStudent() {

        Assert.IsType<StudentInfo>(mockStudent);
    }

    [Fact]
    public void TestGetEmail() {

        Assert.Equal(mockStudent.GetEmail(), "Satchapum@gmail.com");
    }

    [Fact]
    public void TestGetPassword() {

        Assert.Equal(mockStudent.GetPassword(), "1234abc");
    }
}
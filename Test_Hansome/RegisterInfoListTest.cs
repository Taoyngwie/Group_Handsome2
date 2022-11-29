namespace Test_Hansome;

public class RegisterInfoListTest
{
    Info mockInfo = new Info("Mr.", "Satchapum", "Krailertrat");
    StudentInfo mockStudent = new StudentInfo("Mr.", "Satchapum", "Krailertrat", "64120501031", "Satchapum@gmail.com", "1234abc");
    TeacherInfo mockTeacher = new TeacherInfo("Mr.", "Satchapum", "Krailertrat", "Satchapum@gmail.com", "1234abc");
    private List<Info> registerInfoList;
    public RegisterInfoListTest()
    {
        this.registerInfoList = new List<Info>();
    }

    [Fact]
    public void TestCreateRegisterInfoList() {

        Assert.IsType<List<Info>>(registerInfoList);
    }

    [Fact]
    public void TestAddNewPerson() {
        registerInfoList.Add(mockInfo);

        Assert.Equal(registerInfoList[0], mockInfo);
    }

    [Fact]
    public void TestCheckLoginStudentTrue() {

        Assert.True(CheckLoginStudent("Satchapum@gmail.com", "1234abc"));
    }

    [Fact]
    public void TestCheckLoginTeacherTrue() {

        Assert.True(CheckLoginTeacher("Satchapum@gmail.com", "1234abc"));
    }

    [Fact]
    public void TestCheckLoginTeacherFalse() {

        Assert.False(CheckLoginTeacher("Nino@gmail.com", "1234abc"));
    }
    public void TestCheckLoginStudentFalse() {

        Assert.False(CheckLoginStudent("Nino@gmail.com", "1234abc"));
    }

    public void TestCheckRegister() {
        
    }

    public bool CheckLoginStudent(string email, string password)
    {   

        if(mockTeacher.GetEmail() == email && mockTeacher.GetPassword() == password)
        {
            return true;
        }
        return false;
    }

    public bool CheckLoginTeacher(string email, string password)
    {   
        if(mockStudent.GetEmail() == email && mockStudent.GetPassword() == password)
        {
            return true;
        }
        return false;
    }
    public bool CheckRegister(string email)
    {
         foreach(Info info in this.registerInfoList)
         {
            if(info is TeacherInfo teacherInfo)
            {
                if(teacherInfo.GetEmail() == email )
                {
                    return false;
                }
            }
            else if(info is StudentInfo studentInfo)
            {
                if(studentInfo.GetEmail() == email )
                {
                    return false;
                }
            }
         }  
         return true;
    }
    
}
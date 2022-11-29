using System.Collections.Generic;

public class RegisterInfoList
{
    private List<Info> registerInfoList;

    public RegisterInfoList()
    {
        this.registerInfoList = new List<Info>();
    }
    public Info CurrentLogin { get; set; }

    public void AddNewPerson(Info info)
    {
        this.registerInfoList.Add(info);
    }

    public bool CheckLogin(string email, string password)
    {
         foreach(Info info in this.registerInfoList)
         {
            if(info is TeacherInfo teacherInfo)
            {
                if(teacherInfo.GetEmail() == email && teacherInfo.GetPassword() == password)
                {
                    CurrentLogin = teacherInfo;
                    return true;
                }
            }
            else if(info is StudentInfo studentInfo)
            {
                if(studentInfo.GetEmail() == email && studentInfo.GetPassword() == password)
                {
                    CurrentLogin = studentInfo;
                    return true;
                }
            }
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
public class Student {
  //Data members
  int studendId;
  string studentName;

  //Default constructor
  public Student() {
    studendId = 101;
    studentName = "Anonymous";
  }

  //Parameterized Constructor
  public Student(int sid, string name) {
    studendId = sid;
    studentName = name;
  }

  //Member Functions
  public int getStudentId() {
    return studendId;
  }

  public string getStudentName() {
    return studentName;
  }
}
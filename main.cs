using System;

class MainClass {
  public static void Main (string[] args) {
    Faculty f1 = new Faculty();
    f1.DateOfEmployment = Convert.ToDateTime("01/02/2017");
    f1.Promote();
    f1.GrantTenure();
    f1.DateOfEmployment = Convert.ToDateTime("01/02/2013");
    f1.Promote();
    f1.DateOfEmployment = Convert.ToDateTime("08/02/2010");
    f1.Promote();
    f1.DateOfEmployment = Convert.ToDateTime("01/02/2000");
    f1.Promote();
    f1.Employer = "Tri-C";
    f1.Intro();
  }
}
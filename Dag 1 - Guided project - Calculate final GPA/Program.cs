string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int GennemsnitKaraktere = (course1Credit + course2Credit + course3Credit + course4Credit + course5Credit) / 5;


Console.WriteLine("Elevens Navn " + studentName);
Console.WriteLine("Karaktere for " + course1Name + " = " + course1Credit);
Console.WriteLine("Karaktere for " + course2Name + " = " + course2Credit);
Console.WriteLine("Karaktere for " + course3Name + " = " + course3Credit);
Console.WriteLine("Karaktere for " + course4Name + " = " + course4Credit);
Console.WriteLine("Karaktere for " + course5Name + " = " + course5Credit);
Console.WriteLine("Gennemsnitskaratere er = " + GennemsnitKaraktere);


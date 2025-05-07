using System.Collections;

namespace ClassesAndDataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("pippo", "de pippis", "male", 2000);
            Student student2 = new Student("paperoga", "de paperoni", 2000);
            Student student3 = new("paperoga", "de paperoni", 2000);  //si puo usare anche cosi in quanto è gia dichiarato Student
            Student student4 = new Student("Qui", "QUA", 2015);

            Teacher teacher1   = new Teacher { Name = "Archimede", Surname = "Pitagorico", Subject = "Math" };
            Teacher teacher2 = new Teacher { Name = "Pico" }; // solo required


            Student[] students = new Student[3];
            students[0] = student1; 
            students.Append(student2);
            students[2] = student3;
            students.Append(student4);

            ArrayList studentArrayList = new ArrayList();    //solo per retrocompatibilità, da nn usare, puo contenere tutti i tipi.
            studentArrayList.Add(student1);    
            studentArrayList.Add(student2);
            studentArrayList.Add(teacher1);

            List<Student>  studentList = new List<Student>(); //tipizzato come Student accetta solo Student, non Teacher ad esempio
            studentList.Add(student1);  
            studentList.Add(student2);

            Hashtable studentHashtable = new Hashtable();   //key value ma accetta tutto
            studentHashtable.Add("pippo", student1);
            studentHashtable.Add("pico", teacher1);
            studentHashtable.Add(5, teacher2);  //addirittura cosi

            Dictionary<string, Student> studentDictionary = new Dictionary<string, Student>();  
           studentDictionary


        }
    }
}

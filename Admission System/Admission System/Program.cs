using System;

namespace Admission_System
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*todo:
             * save input to another file
             * can exit without finishing 50 students
             * colors
             * 
             */




            Student[] student = new Student[50];

            
            int count = 0, ccs = 9, coe = 9, cbaa = 9, cte = 9, cas = 9;

            string strDept = "";
            string strCourse = "";
            string name = "";
            int age = 0;


        AddNew:
            bool isAccepting = (ccs == 10 && coe == 10 && cbaa == 10 && cte == 10 && cas == 10);
            if (isAccepting)
            {
                goto End;
            }
            AddNew();
            student[count] = new Student();
            goto MainMenu;

        // Main Menu
        MainMenu:
            MainMenu();
            int option = int.TryParse(Console.ReadKey().KeyChar.ToString(), out option) ? option : -1; 

            // Department Menu
            if (option == 1)
            {
            DepartmentMenu:
                //int dept = int.TryParse(Console.ReadLine(), out dept) ? dept : -1;
                int dept = int.TryParse(Console.ReadKey().KeyChar.ToString(), out dept) ? dept : -1;

                //check if still accepting
                if (dept == 1 && ccs >= 10) { NoLongerAccepting(); goto DepartmentMenu; }
                else if (dept == 2 && coe >= 10) { NoLongerAccepting(); goto DepartmentMenu; }
                else if (dept == 3 && cbaa >= 10) { NoLongerAccepting(); goto DepartmentMenu; }
                else if (dept == 4 && cte >= 10) { NoLongerAccepting(); goto DepartmentMenu; }
                else if (dept == 5 && cas >= 10) { NoLongerAccepting(); goto DepartmentMenu; }

                //ccs
                if (dept == 0)
                {
                    goto MainMenu;
                }
                while (true)
                {
                    if (dept == 1)
                    {
                        strDept = "CCS";
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("\t______________________________________________________________");
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t Course Options: ");
                        Console.WriteLine();
                        Console.WriteLine("\t\t [1] BS INFO");
                        Console.WriteLine("\t\t [2] BSCS");
                        Console.WriteLine("\t\t__________________________________________________");
                        Console.WriteLine();
                        Console.WriteLine("\t\t [0] Go to Department Options");
                        Console.WriteLine("\t______________________________________________________________");
                        Console.WriteLine();
                        Console.Write("\tEnter your chosen course [1,2,0]: ");
                        int course = int.TryParse(Console.ReadKey().KeyChar.ToString(), out course) ? course : -1;
                        if (course == 0)
                        {
                            goto DepartmentMenu;
                        }
                        else if (course == 1)
                        {
                            strCourse = "BS INFO";
                            goto MainMenu;
                        }
                        else if (course == 2)
                        {
                            strCourse = "BSCS";
                            goto MainMenu;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("\tInvalid Input");
                            Console.Write("\tPress any key to continue.");
                            Console.ReadKey();

                        }
                    }


                    //coe
                    else if (dept == 2)
                    {
                        strDept = "COE";
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("\t______________________________________________________________");
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t Course Options: ");
                        Console.WriteLine();
                        Console.WriteLine("\t\t [1] BS EE");
                        Console.WriteLine("\t\t [2] BS ECE");
                        Console.WriteLine("\t\t__________________________________________________");
                        Console.WriteLine();
                        Console.WriteLine("\t\t [0] Go to Department Options");
                        Console.WriteLine("\t______________________________________________________________");
                        Console.WriteLine();
                        Console.Write("\tEnter your chosen course [1,2,0]: ");
                        int course = int.TryParse(Console.ReadKey().KeyChar.ToString(), out course) ? course : -1;
                        if (course == 0)
                        {
                            goto DepartmentMenu;
                        }
                        else if (course == 1)
                        {
                            strCourse = "BS EE";
                            goto MainMenu;
                        }
                        else if (course == 2)
                        {
                            strCourse = "BS ECE";
                            goto MainMenu;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("\tInvalid Input");
                            Console.Write("\tPress any key to continue.");
                            Console.ReadKey();
                        }
                    }

                    //cbaa
                    else if (dept == 3)
                    {
                        strDept = "CBAA";
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("\t______________________________________________________________");
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t Course Options: ");
                        Console.WriteLine();
                        Console.WriteLine("\t\t [1] BSA");
                        Console.WriteLine("\t\t [2] BSBA");
                        Console.WriteLine("\t\t__________________________________________________");
                        Console.WriteLine();
                        Console.WriteLine("\t\t [0] Go to Department Options");
                        Console.WriteLine("\t______________________________________________________________");
                        Console.WriteLine();
                        Console.Write("\tEnter your chosen course [1,2,0]: ");
                        int course = int.TryParse(Console.ReadKey().KeyChar.ToString(), out course) ? course : -1;
                        if (course == 0)
                        {
                            goto DepartmentMenu;
                        }
                        else if (course == 1)
                        {
                            strCourse = "BSA";
                            goto MainMenu;
                        }
                        else if (course == 2)
                        {
                            strCourse = "BSBA";
                            goto MainMenu;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("\tInvalid Input");
                            Console.Write("\tPress any key to continue.");
                            Console.ReadKey();
                        }
                    }



                    //cte
                    else if (dept == 4)
                    {
                        strDept = "CTE";
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("\t______________________________________________________________");
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t Course Options: ");
                        Console.WriteLine();
                        Console.WriteLine("\t\t [1] BSED-MATHEMATICS");
                        Console.WriteLine("\t\t [2] BSED-ENGLISH");
                        Console.WriteLine("\t\t__________________________________________________");
                        Console.WriteLine();
                        Console.WriteLine("\t\t [0] Go to Department Options");
                        Console.WriteLine("\t______________________________________________________________");
                        Console.WriteLine();
                        Console.Write("\tEnter your chosen course [1,2,0]: ");
                        int course = int.TryParse(Console.ReadKey().KeyChar.ToString(), out course) ? course : -1;
                        if (course == 0)
                        {
                            goto DepartmentMenu;
                        }
                        else if (course == 1)
                        {
                            strCourse = "BSED-MATHEMATICS";
                            goto MainMenu;
                        }
                        else if (course == 2)
                        {
                            strCourse = "BSED-ENGLISH";
                            goto MainMenu;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("\tInvalid Input");
                            Console.Write("\tPress any key to continue.");
                            Console.ReadKey();
                        }
                    }

                    //cas
                    else if (dept == 5)
                    {
                        strDept = "CAS";
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("\t______________________________________________________________");
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t Course Options: ");
                        Console.WriteLine();
                        Console.WriteLine("\t\t [1] BS PSYCH");
                        Console.WriteLine("\t\t [2] BS BIO");
                        Console.WriteLine("\t\t__________________________________________________");
                        Console.WriteLine();
                        Console.WriteLine("\t\t [0] Go to Department Options");
                        Console.WriteLine("\t______________________________________________________________");
                        Console.WriteLine();
                        Console.Write("\tEnter your chosen course [1,2,0]: ");
                        int course = int.TryParse(Console.ReadKey().KeyChar.ToString(), out course) ? course : -1;
                        if (course == 0)
                        {
                            goto DepartmentMenu;
                        }
                        else if (course == 1)
                        {
                            strCourse = "BS PSYCH";
                            goto MainMenu;
                        }
                        else if (course == 2)
                        {
                            strCourse = "BS BIO";
                            goto MainMenu;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("\tInvalid Input");
                            Console.Write("\tPress any key to continue.");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("\tInvalid Input");
                        Console.Write("\tPress any key to continue.");
                        Console.ReadKey();
                        goto DepartmentMenu;
                    }
                }
            }

            else if (option == 2)
            {
                //name
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t______________________________________________________________");
                Console.WriteLine();
                Console.WriteLine("\t\t\t Personal Information: ");
                Console.WriteLine();
                Console.Write("\tEnter your full name: ");
                name = Console.ReadLine();
                // isAlpha()
                goto MainMenu;
            }
            else if (option == 3)
            {
            Age:
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t______________________________________________________________");
                Console.WriteLine();
                Console.WriteLine("\t\t\t Personal Information: ");
                Console.WriteLine();
                Console.Write("\tEnter your age: ");
                age = int.TryParse(Console.ReadLine(), out age) ? age : -1;
                if (age == -1)
                {
                    Console.WriteLine();
                    Console.WriteLine("\tInvalid Input");
                    Console.Write("\tPress any key to continue.");
                    Console.ReadKey();
                    goto Age;
                }
                goto MainMenu;
            }
            else if (option == 0)
            {
                if (strDept == "" || strCourse == "" || age == 0 || name == "")
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t______________________________________________________________");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t Incomplete Student Record. ");
                    Console.WriteLine("\t\t__________________________________________________");
                    Console.WriteLine();
                    Console.WriteLine("\t\t    Name   : " + name);
                    Console.WriteLine("\t\t    Age    : " + age);
                    Console.WriteLine("\t\tDepartment : " + strDept);
                    Console.WriteLine("\t\t   Course  : " + strCourse);
                    Console.WriteLine("\t\t__________________________________________________");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t No Student Record Added. ");
                    Console.WriteLine("\t______________________________________________________________");
                    Console.WriteLine();
                    Console.Write("\tPress any key to continue.");
                    Console.ReadKey();
                    goto MainMenu;
                }
                else if (strDept == "CCS")
                {
                    ccs++;
                    student[count].Department = strDept;
                    student[count].Course = strCourse;
                    student[count].Name = name;
                    student[count].Age = age;
                }
                else if (strDept == "COE")
                {
                    coe++;
                    student[count].Department = strDept;
                    student[count].Course = strCourse;
                    student[count].Name = name;
                    student[count].Age = age;
                }
                else if (strDept == "CBAA")
                {
                    cbaa++;
                    student[count].Department = strDept;
                    student[count].Course = strCourse;
                    student[count].Name = name;
                    student[count].Age = age;
                }
                else if (strDept == "CTE")
                {
                    cte++;
                    student[count].Department = strDept;
                    student[count].Course = strCourse;
                    student[count].Name = name;
                    student[count].Age = age;
                }
                else if (strDept == "CAS")
                {
                    cas++;
                    student[count].Department = strDept;
                    student[count].Course = strCourse;
                    student[count].Name = name;
                    student[count].Age = age;
                }
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t______________________________________________________________");
                Console.WriteLine();
                Console.WriteLine("\t\t\t Student Record Added. ");
                Console.WriteLine("\t\t__________________________________________________");
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t{0}/50", count + 1);
                student[count].showStudentDetails();
                Console.WriteLine("\t______________________________________________________________");
                Console.WriteLine();
                Console.Write("\tPress any key to continue.");
                Console.ReadKey();
                count++;

                //clear inputs
                strDept = "";
                strCourse = "";
                name = "";
                age = 0;

                goto AddNew;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("\tInvalid Input");
                Console.Write("\tPress any key to continue.");
                Console.ReadKey();



                goto MainMenu;
            }

        End:
            //
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t______________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("\t\t\t Admissions System: ");
            Console.WriteLine();
            Console.Write("\t\t\tAll departments are full.");
            Console.WriteLine();
            Console.WriteLine("\t______________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("\tPress any key to Continue.");
            Console.WriteLine();
            Console.ReadKey();
            goto Summary;
        //summary

        Summary:
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t______________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("\t\t\t Department Summary: ");
            Console.WriteLine();
            Console.WriteLine("\t\t [1] CCS |\t [2] COE |\t [3] CBAA\t");
            Console.WriteLine("\t\t [4] CTE |\t [5] CAS |");
            Console.WriteLine("\t\t__________________________________________________");
            Console.WriteLine();
            Console.WriteLine("\t\t [0] Exit");
            Console.WriteLine("\t______________________________________________________________");
            Console.WriteLine();
            Console.Write("\tEnter which department summary you want to list [1,2,3,4,5,0]: ");
            int summary = int.TryParse(Console.ReadKey().KeyChar.ToString(), out summary) ? summary : -1;


            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t______________________________________________________________");
            Console.WriteLine();

            if (summary == 1)
            {
                Console.WriteLine("\t\t\t CCS Summary: ");
                Console.WriteLine();
                Console.WriteLine("\t\t Name\t\t\t | Course");
                for (int i = 0; i < student.Length; i++)
                {
                    if (student[i].Department == "CCS")
                    {
                        Console.WriteLine("\t\t {0}\t\t\t | {1}", student[i].Name, student[i].Course);
                    }
                }
            }
            else if (summary == 2)
            {
                Console.WriteLine("\t\t\t COE Summary: ");
                Console.WriteLine();
                Console.WriteLine("\t\t Name\t\t\t | Course");
                for (int i = 0; i < student.Length; i++)
                {
                    if (student[i].Department == "COE")
                    {
                        Console.WriteLine("\t\t {0}\t\t\t | {1}", student[i].Name, student[i].Course);
                    }
                }
            }
            else if (summary == 3)
            {
                Console.WriteLine("\t\t\t CBAA Summary: ");
                Console.WriteLine();
                Console.WriteLine("\t\t Name\t\t\t | Course");
                for (int i = 0; i < student.Length; i++)
                {
                    if (student[i].Department == "CBAA")
                    {
                        Console.WriteLine("\t\t {0}\t\t\t | {1}", student[i].Name, student[i].Course);
                    }
                }
            }
            else if (summary == 4)
            {
                Console.WriteLine("\t\t\t CTE Summary: ");
                Console.WriteLine();
                Console.WriteLine("\t\t Name\t\t\t | Course");
                for (int i = 0; i < student.Length; i++)
                {
                    if (student[i].Department == "CTE")
                    {
                        Console.WriteLine("\t\t {0}\t\t\t | {1}", student[i].Name, student[i].Course);
                    }
                }
            }
            else if (summary == 5)
            {
                Console.WriteLine("\t\t\t CAS Summary: ");
                Console.WriteLine();
                Console.WriteLine("\t\t Name\t\t\t | Course");
                for (int i = 0; i < student.Length; i++)
                {
                    if (student[i].Department == "CAS")
                    {
                        Console.WriteLine("\t\t {0}\t\t\t | {1}", student[i].Name, student[i].Course);
                    }
                }
            }
            else if (summary == 0)
            {
                Environment.Exit(0);
            }
            Console.WriteLine("\t\t__________________________________________________");
            Console.WriteLine();
            Console.WriteLine("\t\t Press any key to continue.");
            Console.WriteLine("\t______________________________________________________________");
            Console.WriteLine();
            Console.ReadKey();
            goto Summary;


        }
        public static void AddNew()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t______________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("\t\t\t Admissions System: ");
            Console.WriteLine();
            Console.Write("\t\tPress any key to Add New Record.");
            Console.WriteLine();
            Console.WriteLine("\t______________________________________________________________");
            Console.WriteLine();

            Console.ReadKey();
        }
        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t______________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("\t\t\t Main Menu: ");
            Console.WriteLine();
            Console.WriteLine("\t\t [1] Department Menu");
            Console.WriteLine("\t\t [2] Name");
            Console.WriteLine("\t\t [3] Age");
            Console.WriteLine("\t\t__________________________________________________");
            Console.WriteLine();
            Console.WriteLine("\t\t [0] Submit");
            Console.WriteLine();
            Console.WriteLine("\t______________________________________________________________");
            Console.WriteLine();
            Console.Write("\tEnter an menu option [1,2,3,0]: ");
        }
        public static void DepartmentMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t______________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("\t\t\t Department Options: ");
            Console.WriteLine();
            Console.WriteLine("\t\t [1] CCS |\t [2] COE |\t [3] CBAA");
            Console.WriteLine("\t\t [4] CTE |\t [5] CAS |");
            Console.WriteLine("\t\t__________________________________________________");
            Console.WriteLine();
            Console.WriteLine("\t\t [0] Go to Main Menu");
            Console.WriteLine("\t______________________________________________________________");
            Console.WriteLine();
            Console.Write("\tEnter your chosen department [1,2,3,4,5,0]: ");
        }

        public static void NoLongerAccepting()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t______________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("\tThe department is full and is no longer accepting examiners.");
            Console.WriteLine();
            Console.WriteLine("\t______________________________________________________________");
            Console.WriteLine();
            Console.Write("\tPress any key to continue.");
            Console.ReadKey();
        }
    }

    class Student
    {
        private string name;
        private int age;
        private string department;
        private string course;

        //get and set
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public string Course
        {
            get { return course; }
            set { course = value; }
        }


        public void showStudentDetails()
        {
            Console.WriteLine("\t\t    Name   : " + name);
            Console.WriteLine("\t\t    Age    : " + age);
            Console.WriteLine("\t\tDepartment : " + department);
            Console.WriteLine("\t\t   Course  : " + course);
        }
    }
}

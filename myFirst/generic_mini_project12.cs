using System;
using System.Collections.Generic;
using System.Linq;

namespace myFirst
{
    internal class generic_mini_project12
    {
        // =================== MODULE 1: STUDENT ==================
      
        
        public class Student
        {
            public int StudentId { get; set; }
            public string StudentName { get; set; }
            public int Age { get; set; }
            public string Mobile { get; set; }
        }

        public class StudentManagement
        {
            private List<Student> students = new List<Student>();
            private Stack<string> undoStack;

            public StudentManagement(Stack<string> undoStackRef)
            {
                undoStack = undoStackRef;
            }

            public void AddStudent()
            {
                Console.Write("Enter Student ID: ");
                if (!int.TryParse(Console.ReadLine(), out int id))
                {
                    Console.WriteLine("❌ Invalid ID.");
                    return;
                }

                if (students.Any(s => s.StudentId == id))
                {
                    Console.WriteLine("❌ Student ID already exists!");
                    return;
                }

                Console.Write("Enter Student Name: ");
                string name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("❌ Name cannot be empty.");
                    return;
                }

                Console.Write("Enter Age: ");
                if (!int.TryParse(Console.ReadLine(), out int age))
                {
                    Console.WriteLine("❌ Invalid Age.");
                    return;
                }

                Console.Write("Enter Mobile Number: ");
                string mobile = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(mobile))
                {
                    Console.WriteLine("❌ Mobile cannot be empty.");
                    return;
                }

                students.Add(new Student { StudentId = id, StudentName = name, Age = age, Mobile = mobile });
                undoStack.Push($"DeleteStudent-{id}"); // save undo action
                Console.WriteLine("✔ Student added successfully!");
            }

            public void DisplayStudents()
            {
                if (students.Count == 0)
                {
                    Console.WriteLine("No students found.");
                    return;
                }

                Console.WriteLine("\n--- Student List ---");
                foreach (var s in students)
                    Console.WriteLine($"ID: {s.StudentId}, Name: {s.StudentName}, Age: {s.Age}, Mobile: {s.Mobile}");
            }

            public Student GetStudentById(int id)
            {
                return students.FirstOrDefault(s => s.StudentId == id);
            }

            public bool StudentExists(int id)
            {
                return students.Any(s => s.StudentId == id);
            }

            public void DeleteStudent(int id)
            {
                var student = GetStudentById(id);
                if (student != null)
                {
                    students.Remove(student);
                    undoStack.Push($"AddStudent-{student.StudentId}-{student.StudentName}-{student.Age}-{student.Mobile}");
                    Console.WriteLine("✔ Student deleted (can undo).");
                }
                else Console.WriteLine("❌ Student not found.");
            }
        }

        // =================== MODULE 2: COURSE ===================
        public class CourseManagement
        {
            private Dictionary<int, string> courses = new Dictionary<int, string>();
            private Stack<string> undoStack;

            public CourseManagement(Stack<string> undoStackRef)
            {
                undoStack = undoStackRef;
            }

            public void AddCourse()
            {
                Console.Write("Enter Course Code: ");
                if (!int.TryParse(Console.ReadLine(), out int code))
                {
                    Console.WriteLine("❌ Invalid code.");
                    return;
                }

                if (courses.ContainsKey(code))
                {
                    Console.WriteLine("❌ Course code already exists!");
                    return;
                }

                Console.Write("Enter Course Name: ");
                string name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("❌ Course name cannot be empty.");
                    return;
                }

                courses.Add(code, name);
                undoStack.Push($"DeleteCourse-{code}");
                Console.WriteLine("✔ Course added successfully!");
            }

            public void DisplayCourses()
            {
                if (courses.Count == 0)
                {
                    Console.WriteLine("No courses found.");
                    return;
                }

                Console.WriteLine("\n--- Course List ---");
                foreach (var c in courses.OrderBy(c => c.Key))
                    Console.WriteLine($"Code: {c.Key}, Name: {c.Value}");
            }

            public bool CourseExists(int code)
            {
                return courses.ContainsKey(code);
            }

            public string GetCourseName(int code)
            {
                return courses.TryGetValue(code, out string name) ? name : "Unknown";
            }

            public void DeleteCourse(int code)
            {
                if (courses.TryGetValue(code, out string name))
                {
                    courses.Remove(code);
                    undoStack.Push($"AddCourse-{code}-{name}");
                    Console.WriteLine("✔ Course deleted (can undo).");
                }
                else Console.WriteLine("❌ Course not found.");
            }
        }

        // =================== MODULE 3: ENROLLMENT ===================
        public class EnrollmentManagement
        {
            private HashSet<string> enrollments = new HashSet<string>();
            private StudentManagement studentManager;
            private CourseManagement courseManager;
            private Stack<string> undoStack;

            public EnrollmentManagement(StudentManagement sm, CourseManagement cm, Stack<string> undoStackRef)
            {
                studentManager = sm;
                courseManager = cm;
                undoStack = undoStackRef;
            }

            public void EnrollStudent()
            {
                Console.Write("Enter Student ID: ");
                if (!int.TryParse(Console.ReadLine(), out int studentId) || !studentManager.StudentExists(studentId))
                {
                    Console.WriteLine("❌ Student not found.");
                    return;
                }

                Console.Write("Enter Course Code: ");
                if (!int.TryParse(Console.ReadLine(), out int courseCode) || !courseManager.CourseExists(courseCode))
                {
                    Console.WriteLine("❌ Course not found.");
                    return;
                }

                string key = $"{studentId}-{courseCode}";
                if (!enrollments.Add(key))
                {
                    Console.WriteLine("❌ Student already enrolled in this course.");
                    return;
                }

                undoStack.Push($"CancelEnrollment-{studentId}-{courseCode}");
                Console.WriteLine("✔ Enrollment successful!");
            }

            public void DisplayEnrollments()
            {
                if (enrollments.Count == 0)
                {
                    Console.WriteLine("No enrollments found.");
                    return;
                }

                Console.WriteLine("\n--- Enrollment List ---");
                foreach (var e in enrollments)
                {
                    var parts = e.Split('-');
                    int sid = int.Parse(parts[0]);
                    int cid = int.Parse(parts[1]);
                    Console.WriteLine($"Student: {studentManager.GetStudentById(sid)?.StudentName} (ID: {sid}), Course: {courseManager.GetCourseName(cid)} (Code: {cid})");
                }
            }

            public void CancelEnrollment(int studentId, int courseCode)
            {
                string key = $"{studentId}-{courseCode}";
                if (enrollments.Remove(key))
                {
                    undoStack.Push($"EnrollStudent-{studentId}-{courseCode}");
                    Console.WriteLine("✔ Enrollment cancelled (can undo).");
                }
                else Console.WriteLine("❌ Enrollment not found.");
            }
        }

        // =================== MODULE 4: ADMISSION QUEUE ===================
        public class AdmissionQueue
        {
            private Queue<Student> waitingList = new Queue<Student>();

            public void AddToQueue(Student student)
            {
                waitingList.Enqueue(student);
                Console.WriteLine($"✔ {student.StudentName} added to admission queue.");
            }

            public void ProcessNext()
            {
                if (waitingList.Count == 0)
                {
                    Console.WriteLine("No students in the queue.");
                    return;
                }

                Student student = waitingList.Dequeue();
                Console.WriteLine($"✔ {student.StudentName} (ID: {student.StudentId}) has been admitted.");
            }

            public void DisplayQueue()
            {
                if (waitingList.Count == 0)
                {
                    Console.WriteLine("No students in the queue.");
                    return;
                }

                Console.WriteLine("\n--- Admission Queue ---");
                foreach (var s in waitingList)
                    Console.WriteLine($"ID: {s.StudentId}, Name: {s.StudentName}");
            }
        }

        // =================== MODULE 5: UNDO ===================
        public static void UndoLast(Stack<string> undoStack, StudentManagement sm, CourseManagement cm, EnrollmentManagement em)
        {
            if (undoStack.Count == 0)
            {
                Console.WriteLine("Nothing to undo.");
                return;
            }

            string action = undoStack.Pop();
            var parts = action.Split('-');

            switch (parts[0])
            {
                case "DeleteStudent":
                    sm.DeleteStudent(int.Parse(parts[1]));
                    break;
                case "AddStudent":
                    sm.AddStudent(); // simplified, could parse parameters to restore exact student
                    break;
                case "DeleteCourse":
                    cm.DeleteCourse(int.Parse(parts[1]));
                    break;
                case "AddCourse":
                    cm.AddCourse(); // simplified, could parse parameters
                    break;
                case "CancelEnrollment":
                    em.CancelEnrollment(int.Parse(parts[1]), int.Parse(parts[2]));
                    break;
                case "EnrollStudent":
                    em.EnrollStudent(); // simplified
                    break;
                default:
                    Console.WriteLine("Cannot undo this action.");
                    break;
            }
        }

        // =================== MAIN ===================
        static void Main(string[] args)
        {
            Stack<string> undoStack = new Stack<string>();
            StudentManagement sm = new StudentManagement(undoStack);
            CourseManagement cm = new CourseManagement(undoStack);
            EnrollmentManagement em = new EnrollmentManagement(sm, cm, undoStack);
            AdmissionQueue aq = new AdmissionQueue();

            while (true)
            {
                Console.WriteLine("\n--- MAIN MENU ---");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Delete Student");
                Console.WriteLine("4. Add Course");
                Console.WriteLine("5. View Courses");
                Console.WriteLine("6. Delete Course");
                Console.WriteLine("7. Enroll Student in Course");
                Console.WriteLine("8. View Enrollments");
                Console.WriteLine("9. Cancel Enrollment");
                Console.WriteLine("10. Add Student to Admission Queue");
                Console.WriteLine("11. Process Next Student");
                Console.WriteLine("12. View Admission Queue");
                Console.WriteLine("13. Undo Last Action");
                Console.WriteLine("0. Exit");
                Console.Write("Choose option: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": sm.AddStudent(); break;
                    case "2": sm.DisplayStudents(); break;
                    case "3":
                        Console.Write("Enter Student ID to delete: ");
                        if (int.TryParse(Console.ReadLine(), out int sidDel))
                            sm.DeleteStudent(sidDel);
                        break;
                    case "4": cm.AddCourse(); break;
                    case "5": cm.DisplayCourses(); break;
                    case "6":
                        Console.Write("Enter Course Code to delete: ");
                        if (int.TryParse(Console.ReadLine(), out int cidDel))
                            cm.DeleteCourse(cidDel);
                        break;
                    case "7": em.EnrollStudent(); break;
                    case "8": em.DisplayEnrollments(); break;
                    case "9":
                        Console.Write("Enter Student ID to cancel enrollment: ");
                        int sId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Course Code: ");
                        int cId = int.Parse(Console.ReadLine());
                        em.CancelEnrollment(sId, cId);
                        break;
                    case "10":
                        Console.Write("Enter Student ID to add to queue: ");
                        if (int.TryParse(Console.ReadLine(), out int queueId))
                        {
                            var student = sm.GetStudentById(queueId);
                            if (student != null) aq.AddToQueue(student);
                        }
                        break;
                    case "11": aq.ProcessNext(); break;
                    case "12": aq.DisplayQueue(); break;
                    case "13": UndoLast(undoStack, sm, cm, em); break;
                    case "0": return;
                    default: Console.WriteLine("❌ Invalid choice."); break;
                }
            }
        }
    }
}

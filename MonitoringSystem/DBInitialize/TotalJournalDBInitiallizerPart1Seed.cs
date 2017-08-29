using MonitoringSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MonitoringSystemModel;

namespace MonitoringSystem.Models
{
    public partial class TotalJournalDBInitializer : DropCreateDatabaseAlways<TotalJournalContext>
    {
        protected override void Seed(TotalJournalContext context)
        {
            GroupInit(ref context);
            #region studentsInit 
            List<Student> students4 = new List<Student>
            {
                new Student() { RecordBookNumberID = "436001", FirstName = "Катерина", LastName = "Андрющенко", MiddleName = "Сергеевна", GroupID = "641п", },
                new Student() { RecordBookNumberID = "436002", FirstName = "Денис", LastName = "Билецкий", MiddleName = "Романович", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436003", FirstName = "Илья", LastName = "Вирич", MiddleName = "Васильевич", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436004", FirstName = "Роман", LastName = "Гайдук", MiddleName = "Валерьевич", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436005", FirstName = "Борис", LastName = "Головкин", MiddleName = "Анатольевич", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436006", FirstName = "Артур", LastName = "Гулеватый", MiddleName = "Игоревич", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436007", FirstName = "Виталий", LastName = "Дворник", MiddleName = "Юрьевич", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436008", FirstName = "Михаил", LastName = "Дронов", MiddleName = "Эдуардович", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436009", FirstName = "Владислав", LastName = "Колесник", MiddleName = "Юрьевич", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436010", FirstName = "Артем", LastName = "Мирошниченко", MiddleName = "Валерьевич", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436011", FirstName = "Евгений", LastName = "Могилевский", MiddleName = "Романович", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436012", FirstName = "Катерина", LastName = "Плитник", MiddleName = "Витальевна", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436013", FirstName = "Вадим", LastName = "Рачков", MiddleName = "Сергеевич", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436014", FirstName = "Дмитрий", LastName = "Руденок", MiddleName = "Юрьевич", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436015", FirstName = "Оксана", LastName = "Ткаченко", MiddleName = "Витальевна", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436016", FirstName = "Артем", LastName = "Чуглазов", MiddleName = "Васильевич", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436017", FirstName = "Ростислав", LastName = "Шурухин", MiddleName = "Юрьевич", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436018", FirstName = "Александр", LastName = "Яценко", MiddleName = "Сергеевич", GroupID = "641п" },
                new Student() { RecordBookNumberID = "436019", FirstName = "Евгений", LastName = "Виноградный", MiddleName = "Олегович", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436020", FirstName = "Валерий", LastName = "Глянцев", MiddleName = "Олегович", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436021", FirstName = "Диана", LastName = "Грушко", MiddleName = "Александровна", GroupID = "642п" },

                new Student() { RecordBookNumberID = "436022", FirstName = "Анна", LastName = "Дорошенко", MiddleName = "Сергеевна", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436023", FirstName = "Александр", LastName = "Жуган", MiddleName = "Александрович", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436024", FirstName = "Александр", LastName = "Ильченко", MiddleName = "Анатольевич", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436025", FirstName = "Сергей", LastName = "Клименко", MiddleName = "Юрьевич", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436026", FirstName = "Юрий", LastName = "Кудринский", MiddleName = "Михайлович", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436027", FirstName = "Александр", LastName = "Кушнарев", MiddleName = "Александрович", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436028", FirstName = "Владислав", LastName = "Мокеев", MiddleName = "Олегович", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436029", FirstName = "Полина", LastName = "Надеева", MiddleName = "Егоровна", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436030", FirstName = "Владислав", LastName = "Овчаренко", MiddleName = "Витальевич", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436031", FirstName = "Денис", LastName = "Пилипенко", MiddleName = "Петрович", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436032", FirstName = "Владислав", LastName = "Рогинский", MiddleName = "Михайлович", GroupID = "642п" },

                new Student() { RecordBookNumberID = "436033", FirstName = "Ярослав", LastName = "Рягузов", MiddleName = "Алексеевич", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436034", FirstName = "Александр", LastName = "Силин", MiddleName = "Олегович", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436035", FirstName = "Руслан", LastName = "Тибилашвли", MiddleName = "Викторович", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436036", FirstName = "Андрей", LastName = "Турянский", MiddleName = "Олегович", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436037", FirstName = "Богдан", LastName = "Хон", MiddleName = "Игоревич", GroupID = "642п" },
                new Student() { RecordBookNumberID = "436038", FirstName = "Анастасия", LastName = "Чередник", MiddleName = "Юрьевна", GroupID = "642п" },

                new Student() { RecordBookNumberID = "436039", FirstName = "Олег", LastName = "Бордаков", MiddleName = "Васильевич", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436040", FirstName = "Александр", LastName = "Глущенко", MiddleName = "Эдуардович", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436041", FirstName = "Александр", LastName = "Драшпуль", MiddleName = "Юрьевич", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436042", FirstName = "Анастасия", LastName = "Дучкина", MiddleName = "Михайловна", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436043", FirstName = "Виталий", LastName = "Комаровский", MiddleName = "Константинович", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436044", FirstName = "Ирина", LastName = "Крайнюкова", MiddleName = "Сергеевна", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436045", FirstName = "Дмитрий", LastName = "Курдюков", MiddleName = "Семенович", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436046", FirstName = "Евгения", LastName = "Ламтюгова", MiddleName = " Ильинична", GroupID = "631пст", },
                new Student() { RecordBookNumberID = "436047", FirstName = "Илья", LastName = "Олешко", MiddleName = "Сергеевич", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436048", FirstName = "Евгений", LastName = "Погорельцев", MiddleName = "Семенович", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436049", FirstName = "Александр", LastName = "Савинков", MiddleName = "Максимович", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436050", FirstName = "Александр", LastName = "Сирота", MiddleName = "Юрьевич", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436051", FirstName = "Ксения", LastName = "Сич", MiddleName = "Сергеевна", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436052", FirstName = "Андрей", LastName = "Телешев", MiddleName = "Александрович", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436053", FirstName = "Олег", LastName = "Уманцев", MiddleName = "Сергеевич", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436054", FirstName = "Гриша", LastName = "Христенко", MiddleName = "Генадиевич", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436055", FirstName = "Сергей", LastName = "Четвернтный", MiddleName = "Олегович", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436056", FirstName = "Юрий", LastName = "Шевцов", MiddleName = "Александрович", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436057", FirstName = "Руслан", LastName = "Счастливый", MiddleName = "Витальевич", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436058", FirstName = "Роман", LastName = "Ющенко", MiddleName = "Семенович", GroupID = "631пст" },
                new Student() { RecordBookNumberID = "436059", FirstName = "Ярослав", LastName = "Яскевич", MiddleName = "Витальевич", GroupID = "631пст",  }
            };
            students4.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            #endregion studentsInit
            TeacherInit(ref context);
            #region subInit
            List<Subject> subjects = new List<Subject>
            {
                new Subject() { SubjectID = 1, SubjectName = "Основы программирования", SubjectType = SubjectType.Exam, Term = 1, TeacherID=8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 2, SubjectName = "Основы программной инженерии", SubjectType = SubjectType.Exam, Term = 1, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 3, SubjectName = "Компьтерная дискретная математика", SubjectType = SubjectType.Exam, Term = 2, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 4, SubjectName = "Основы программирования", SubjectType = SubjectType.Exam, Term = 2, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 5, SubjectName = "Групповая динамика и коммуникации", SubjectType = SubjectType.Credit, Term = 2, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 6, SubjectName = "Дискретные структуры", SubjectType = SubjectType.Exam, Term = 3, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 7, SubjectName = "Человеко-машинное взаимодействие", SubjectType = SubjectType.Exam, Term = 3, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 8, SubjectName = "Объектно-ориентированное программирование", SubjectType = SubjectType.Exam, Term = 3, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 9, SubjectName = "Теория вероятности и математическая статистика", SubjectType = SubjectType.Exam, Term = 3, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 10, SubjectName = "Профессиональная практика программной инженерии", SubjectType = SubjectType.Credit, Term = 3, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 11, SubjectName = "Алгоритмы и структуры данных", SubjectType = SubjectType.Exam, Term = 4, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 12, SubjectName = "Архитектура ЭОМ", SubjectType = SubjectType.Exam, Term = 4, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() {}  },
                new Subject() { SubjectID = 13, SubjectName = "Эмперические методы программной инженерии", SubjectType = SubjectType.Exam, Term = 4, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 14, SubjectName = "Конструирование программного обеспечения", SubjectType = SubjectType.Exam, Term = 4, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 15, SubjectName = "Организация компьтерных сетей", SubjectType = SubjectType.Exam, Term = 4, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 16, SubjectName = "Объектно-ориентированное программирование", SubjectType = SubjectType.Credit, Term = 4, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 17, SubjectName = "Инженерная и компьютерная графика", SubjectType = SubjectType.Exam, Term = 5, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 18, SubjectName = "Анализ требований к программному обеспечению", SubjectType = SubjectType.Exam, Term = 5, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 19, SubjectName = "Операционные системы", SubjectType = SubjectType.Exam, Term = 5, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 20, SubjectName = "Качество ПО и тестирование", SubjectType = SubjectType.Exam, Term = 5, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 21, SubjectName = "Английский язык", SubjectType = SubjectType.Credit, Term = 5, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 22, SubjectName = "Архитектура и проектирование ПО", SubjectType = SubjectType.Exam, Term = 6, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 23, SubjectName = "Базы данных", SubjectType = SubjectType.Exam, Term = 6, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 24, SubjectName = "Методы оптимизации и исследования операций", SubjectType = SubjectType.Exam, Term = 6, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 25, SubjectName = "Программирование интернет", SubjectType = SubjectType.Exam, Term = 6, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 26, SubjectName = "Системы искусственного интелекта", SubjectType = SubjectType.Exam, Term = 6, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 27, SubjectName = "Android", SubjectType = SubjectType.Credit, Term = 6, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 28, SubjectName = "Информационные технологии разработки ПО", SubjectType = SubjectType.Exam, Term = 7, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 29, SubjectName = "Безопасность программ и данных", SubjectType = SubjectType.Exam, Term = 7, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>()},
                new Subject() { SubjectID = 30, SubjectName = "Проектирование распределенных систем ЭОМ", SubjectType = SubjectType.Exam, Term = 7, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 31, SubjectName = "Проектный практикум", SubjectType = SubjectType.Credit, Term = 7, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 32, SubjectName = "Менеджмент проектов ПО", SubjectType = SubjectType.Exam, Term = 8, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 33, SubjectName = "Проектирование производственных экспертных систем", SubjectType = SubjectType.Exam, Term = 8, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 34, SubjectName = "Международные стандарты программной инженерии", SubjectType = SubjectType.Exam, Term = 8, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                new Subject() { SubjectID = 35, SubjectName = "Проектный практикум", SubjectType = SubjectType.Credit, Term = 8, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>()}
            };
            subjects.ForEach(s => context.Subjects.Add(s));
            context.SaveChanges();
            #endregion subInit
            foreach (var subject in context.Subjects)
            {
                foreach (var group in context.Groups)
                {
                    if (subject.Term == 7 || subject. Term == 8)
                    {
                        if (group.CourseNumber == 4)
                        {
                            subject.Groups.Add(group);
                        }
                    }
                    if (subject.Term == 5 || subject.Term == 6)
                    {
                        if (group.CourseNumber == 3)
                        {
                            subject.Groups.Add(group);
                        }
                    }
                    if (subject.Term == 3 || subject.Term == 4)
                    {
                        if (group.CourseNumber == 2)
                        {
                            subject.Groups.Add(group);
                        }
                    }
                    if (subject.Term == 1 || subject.Term == 2)
                    {
                        if (group.CourseNumber == 1)
                        {
                            subject.Groups.Add(group);
                        }
                    }
                }
            }
            context.SaveChanges();
            
            List<SubjectCP> subjectCPs = new List<SubjectCP>()
            {
                new SubjectCP() { SubjectCP_ID = 1, SubjectCPName = "Основы программирования(КП)", Term = 3, TeacherID = 1, Groups = new List<Group>() },
                new SubjectCP() { SubjectCP_ID = 2, SubjectCPName = "Объектно-ориентированное программирование(КП)", Term = 4, TeacherID = 1, Groups = new List<Group>() },
                new SubjectCP() { SubjectCP_ID = 3, SubjectCPName = "Алгоритмы и структуры данных(КП)", Term = 5, TeacherID = 1, Groups = new List<Group>() },
                new SubjectCP() { SubjectCP_ID = 4, SubjectCPName = "Операционные системы(КП)", Term = 6, TeacherID = 1, Groups = new List<Group>() },
                new SubjectCP() { SubjectCP_ID = 5, SubjectCPName = "Базы данных(КП)", Term = 7, TeacherID = 1 , Groups = new List<Group>()},
                new SubjectCP() { SubjectCP_ID = 6, SubjectCPName = "Проектирование распределенных систем ЭВМ(КП)", Term = 8, TeacherID = 1, Groups = new List<Group>() }
            };
            subjectCPs.ForEach(s => context.SubjectCPs.Add(s));
            context.SaveChanges();
            foreach (var subjectCP in context.SubjectCPs)
            {
                foreach (var group in context.Groups)
                {
                    if (subjectCP.Term == 7 || subjectCP.Term == 8)
                    {
                        if (group.CourseNumber == 4)
                        {
                            subjectCP.Groups.Add(group);
                        }
                    }
                    if (subjectCP.Term == 5 || subjectCP.Term == 6)
                    {
                        if (group.CourseNumber == 3)
                        {
                            subjectCP.Groups.Add(group);
                        }
                    }
                    if (subjectCP.Term == 3 || subjectCP.Term == 4)
                    {
                        if (group.CourseNumber == 2)
                        {
                            subjectCP.Groups.Add(group);
                        }
                    }
                    if (subjectCP.Term == 1 || subjectCP.Term == 2)
                    {
                        if (group.CourseNumber == 1)
                        {
                            subjectCP.Groups.Add(group);
                        }
                    }
                }
            }
            context.SaveChanges();

            //MarkInit(ref context);
            //SubjectCPInit(ref context);
            //CourseProjectLineInit(ref context);
            //ModuleInit(ref context);
            //HomeWorkInit(ref context);
            //AttendanceInit(ref context);

            //context.LabMaxPoints.Add(new LabMaxPoint() { LabMaxPointID = 1, LabNumber = 1, MaxPoint = 5, SubjectID = 32 });
            //context.LabMaxPoints.Add(new LabMaxPoint() { LabMaxPointID = 2, LabNumber = 2, MaxPoint = 5, SubjectID = 32 });
            //context.LabMaxPoints.Add(new LabMaxPoint() { LabMaxPointID = 3, LabNumber = 3, MaxPoint = 5, SubjectID = 32 });
            //context.HWMaxPoints.Add(new HWMaxPoint() { HWMaxPointID = 1, HWNumber = 1, MaxPoint = 15, SubjectID = 32 });
            //context.ModuleMaxPoints.Add(new ModuleMaxPoint() { ModuleMaxPointID = 3, ModuleNumber = 1, MaxPoint = 20, SubjectID = 32 });

            //context.AttMaxPoints.Add(new AttMaxPoint() { AttMaxPointID = 1, MaxAmount = 0, SubjectID = 32 });

            //context.FreeMarkFields.Add(new FreeMarkField() { FreeMarkFieldID = 1, FieldName = "Доп.баллы", FieldNumber = 1, FieldPoint = 5, RecordBookNumberID = "436001", SubjectID = 32 });
            //context.FreeMarkFields.Add(new FreeMarkField() { FreeMarkFieldID = 2, FieldName = "Доп.баллы", FieldNumber = 1, FieldPoint = 5, RecordBookNumberID = "436002", SubjectID = 32 });
            //context.FreeMarkFields.Add(new FreeMarkField() { FreeMarkFieldID = 3, FieldName = "Доп.баллы", FieldNumber = 1, FieldPoint = 5, RecordBookNumberID = "436003", SubjectID = 32 });
            //context.FreeMarkFieldMaxPoints.Add(new FreeMarkFieldMaxPoint() { FreeMarkFieldMaxPointID = 1, FieldName = "Доп.баллы", MaxPoint = 10, FieldNumber = 1, SubjectID = 32 });

            //context.CPLineMaxPoints.Add(new CPLineMaxPoint() { CPLineMaxPointID = 1, LineIndex = 1, LineName = "Постановка задачи", MaxPoint = 5, SubjectCPID = 6 });
            context.OneItemPoints.Add(new OneItemPoint() { OneItemPointID = 1, SubjectId = 32, Value = "1" });

            context.SaveChanges();
            base.Seed(context);
        }        
    }
}


#region comments
//context.Marks.Add(new Mark() { MarkID = 70, LabNumber = 1, RecordBookNumberID = "136003", AdditionalPoints = 1, TheMark = 3, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });
//context.Marks.Add(new Mark() { MarkID = 71, LabNumber = 2, RecordBookNumberID = "136003", AdditionalPoints = 3, TheMark = 5, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });
//context.Marks.Add(new Mark() { MarkID = 72, LabNumber = 3, RecordBookNumberID = "136003", AdditionalPoints = 3, TheMark = 2, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });



//context.Marks.Add(new Mark() { MarkID = 73, LabNumber = 1, RecordBookNumberID = "136004", AdditionalPoints = 3, TheMark = 3, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });
//context.Marks.Add(new Mark() { MarkID = 74, LabNumber = 2, RecordBookNumberID = "136004", AdditionalPoints = 2, TheMark = 5, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });
//context.Marks.Add(new Mark() { MarkID = 75, LabNumber = 3, RecordBookNumberID = "136004", AdditionalPoints = 3, TheMark = 3, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });

//context.Marks.Add(new Mark() { MarkID = 76, LabNumber = 1, RecordBookNumberID = "136004", AdditionalPoints = 1, TheMark = 5, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });
//context.Marks.Add(new Mark() { MarkID = 77, LabNumber = 2, RecordBookNumberID = "136004", AdditionalPoints = 2, TheMark = 2, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });
//context.Marks.Add(new Mark() { MarkID = 78, LabNumber = 3, RecordBookNumberID = "136004", AdditionalPoints = 3, TheMark = 2, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });

//context.Marks.Add(new Mark() { MarkID = 79, LabNumber = 1, RecordBookNumberID = "136004", AdditionalPoints = 1, TheMark = 5, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });
//context.Marks.Add(new Mark() { MarkID = 80, LabNumber = 2, RecordBookNumberID = "136004", AdditionalPoints = 2, TheMark = 1, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });
//context.Marks.Add(new Mark() { MarkID = 81, LabNumber = 3, RecordBookNumberID = "136004", AdditionalPoints = 2, TheMark = 4, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });

//context.Marks.Add(new Mark() { MarkID = 82, LabNumber = 1, RecordBookNumberID = "136004", AdditionalPoints = 3, TheMark = 5, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });
//context.Marks.Add(new Mark() { MarkID = 83, LabNumber = 2, RecordBookNumberID = "136004", AdditionalPoints = 3, TheMark = 4, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });
//context.Marks.Add(new Mark() { MarkID = 84, LabNumber = 3, RecordBookNumberID = "136004", AdditionalPoints = 0, TheMark = 2, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });

//context.Marks.Add(new Mark() { MarkID = 85, LabNumber = 1, RecordBookNumberID = "136004", AdditionalPoints = 2, TheMark = 4, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });
//context.Marks.Add(new Mark() { MarkID = 86, LabNumber = 2, RecordBookNumberID = "136004", AdditionalPoints = 1, TheMark = 5, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });
//context.Marks.Add(new Mark() { MarkID = 87, LabNumber = 3, RecordBookNumberID = "136004", AdditionalPoints = 3, TheMark = 3, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });

//context.Marks.Add(new Mark() { MarkID = 88, LabNumber = 1, RecordBookNumberID = "136004", AdditionalPoints = 2, TheMark = 3, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });
//context.Marks.Add(new Mark() { MarkID = 89, LabNumber = 2, RecordBookNumberID = "136004", AdditionalPoints = 3, TheMark = 2, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });
//context.Marks.Add(new Mark() { MarkID = 90, LabNumber = 3, RecordBookNumberID = "136004", AdditionalPoints = 2, TheMark = 5, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });

//context.Marks.Add(new Mark() { MarkID = 1, LabNumber = 1, RecordBookNumberID = "136004", AdditionalPoints = 3, TheMark = 5, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });
//context.Marks.Add(new Mark() { MarkID = 1, LabNumber = 2, RecordBookNumberID = "136004", AdditionalPoints = 2, TheMark = 1, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });
//context.Marks.Add(new Mark() { MarkID = 1, LabNumber = 3, RecordBookNumberID = "136004", AdditionalPoints = 3, TheMark = 3, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });

//context.Marks.Add(new Mark() { MarkID = 91, LabNumber = 1, RecordBookNumberID = "136004", AdditionalPoints = 2, TheMark = 5, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });
//context.Marks.Add(new Mark() { MarkID = 92, LabNumber = 2, RecordBookNumberID = "136004", AdditionalPoints = 3, TheMark = 4, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });
//context.Marks.Add(new Mark() { MarkID = 93, LabNumber = 3, RecordBookNumberID = "136004", AdditionalPoints = 1, TheMark = 4, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });



//context.Marks.Add(new Mark() { MarkID = 94, LabNumber = 1, RecordBookNumberID = "136005", AdditionalPoints = 2, TheMark = 5, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });
//context.Marks.Add(new Mark() { MarkID = 95, LabNumber = 2, RecordBookNumberID = "136005", AdditionalPoints = 2, TheMark = 4, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });
//context.Marks.Add(new Mark() { MarkID = 96, LabNumber = 3, RecordBookNumberID = "136005", AdditionalPoints = 2, TheMark = 4, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });

//context.Marks.Add(new Mark() { MarkID = 97, LabNumber = 1, RecordBookNumberID = "136005", AdditionalPoints = 2, TheMark = 4, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });
//context.Marks.Add(new Mark() { MarkID = 98, LabNumber = 2, RecordBookNumberID = "136005", AdditionalPoints = 3, TheMark = 5, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });
//context.Marks.Add(new Mark() { MarkID = 99, LabNumber = 3, RecordBookNumberID = "136005", AdditionalPoints = 1, TheMark = 3, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });

//context.Marks.Add(new Mark() { MarkID = 100, LabNumber = 1, RecordBookNumberID = "136005", AdditionalPoints = 1, TheMark = 5, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });
////context.Marks.Add(new Mark() { MarkID = 101, LabNumber = 2, RecordBookNumberID = "136005", AdditionalPoints = 1, TheMark = 3, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });
//context.Marks.Add(new Mark() { MarkID = 102, LabNumber = 3, RecordBookNumberID = "136005", AdditionalPoints = 3, TheMark = 2, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });

//context.Marks.Add(new Mark() { MarkID = 103, LabNumber = 1, RecordBookNumberID = "136005", AdditionalPoints = 3, TheMark = 5, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });
//context.Marks.Add(new Mark() { MarkID = 104, LabNumber = 2, RecordBookNumberID = "136005", AdditionalPoints = 3, TheMark = 1, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });
//context.Marks.Add(new Mark() { MarkID = 105, LabNumber = 3, RecordBookNumberID = "136005", AdditionalPoints = 3, TheMark = 4, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });

//context.Marks.Add(new Mark() { MarkID = 106, LabNumber = 1, RecordBookNumberID = "136005", AdditionalPoints = 2, TheMark = 5, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });
//context.Marks.Add(new Mark() { MarkID = 107, LabNumber = 2, RecordBookNumberID = "136005", AdditionalPoints = 3, TheMark = 4, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });
//context.Marks.Add(new Mark() { MarkID = 108, LabNumber = 3, RecordBookNumberID = "136005", AdditionalPoints = 0, TheMark = 3, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });

//context.Marks.Add(new Mark() { MarkID = 109, LabNumber = 1, RecordBookNumberID = "136005", AdditionalPoints = 3, TheMark = 2, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });
//context.Marks.Add(new Mark() { MarkID = 110, LabNumber = 2, RecordBookNumberID = "136005", AdditionalPoints = 0, TheMark = 4, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });
//context.Marks.Add(new Mark() { MarkID = 111, LabNumber = 3, RecordBookNumberID = "136005", AdditionalPoints = 2, TheMark = 5, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });

//context.Marks.Add(new Mark() { MarkID = 112, LabNumber = 1, RecordBookNumberID = "136005", AdditionalPoints = 1, TheMark = 4, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });
//context.Marks.Add(new Mark() { MarkID = 113, LabNumber = 2, RecordBookNumberID = "136005", AdditionalPoints = 3, TheMark = 2, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });
//context.Marks.Add(new Mark() { MarkID = 114, LabNumber = 3, RecordBookNumberID = "136005", AdditionalPoints = 3, TheMark = 3, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });

//context.Marks.Add(new Mark() { MarkID = 115, LabNumber = 1, RecordBookNumberID = "136005", AdditionalPoints = 0, TheMark = 3, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });
//context.Marks.Add(new Mark() { MarkID = 116, LabNumber = 2, RecordBookNumberID = "136005", AdditionalPoints = 3, TheMark = 3, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });
//context.Marks.Add(new Mark() { MarkID = 117, LabNumber = 3, RecordBookNumberID = "136005", AdditionalPoints = 1, TheMark = 2, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });



//context.Marks.Add(new Mark() { MarkID = 118, LabNumber = 1, RecordBookNumberID = "136039", AdditionalPoints = 3, TheMark = 3, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });
//context.Marks.Add(new Mark() { MarkID = 119, LabNumber = 2, RecordBookNumberID = "136039", AdditionalPoints = 0, TheMark = 5, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });
//context.Marks.Add(new Mark() { MarkID = 120, LabNumber = 3, RecordBookNumberID = "136039", AdditionalPoints = 3, TheMark = 3, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });

//context.Marks.Add(new Mark() { MarkID = 121, LabNumber = 1, RecordBookNumberID = "136039", AdditionalPoints = 2, TheMark = 5, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });
//context.Marks.Add(new Mark() { MarkID = 122, LabNumber = 2, RecordBookNumberID = "136039", AdditionalPoints = 2, TheMark = 4, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });
//context.Marks.Add(new Mark() { MarkID = 123, LabNumber = 3, RecordBookNumberID = "136039", AdditionalPoints = 3, TheMark = 3, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });

//context.Marks.Add(new Mark() { MarkID = 124, LabNumber = 1, RecordBookNumberID = "136039", AdditionalPoints = 1, TheMark = 5, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });
//context.Marks.Add(new Mark() { MarkID = 125, LabNumber = 2, RecordBookNumberID = "136039", AdditionalPoints = 3, TheMark = 1, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });
//context.Marks.Add(new Mark() { MarkID = 126, LabNumber = 3, RecordBookNumberID = "136039", AdditionalPoints = 0, TheMark = 5, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });

//context.Marks.Add(new Mark() { MarkID = 127, LabNumber = 1, RecordBookNumberID = "136039", AdditionalPoints = 0, TheMark = 2, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });
//context.Marks.Add(new Mark() { MarkID = 128, LabNumber = 2, RecordBookNumberID = "136039", AdditionalPoints = 3, TheMark = 4, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });
//context.Marks.Add(new Mark() { MarkID = 129, LabNumber = 3, RecordBookNumberID = "136039", AdditionalPoints = 1, TheMark = 5, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });

//context.Marks.Add(new Mark() { MarkID = 130, LabNumber = 1, RecordBookNumberID = "136039", AdditionalPoints = 1, TheMark = 3, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });
//context.Marks.Add(new Mark() { MarkID = 131, LabNumber = 2, RecordBookNumberID = "136039", AdditionalPoints = 2, TheMark = 2, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });
//context.Marks.Add(new Mark() { MarkID = 132, LabNumber = 3, RecordBookNumberID = "136039", AdditionalPoints = 3, TheMark = 3, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });

//context.Marks.Add(new Mark() { MarkID = 133, LabNumber = 1, RecordBookNumberID = "136039", AdditionalPoints = 2, TheMark = 5, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });
//context.Marks.Add(new Mark() { MarkID = 134, LabNumber = 2, RecordBookNumberID = "136039", AdditionalPoints = 3, TheMark = 2, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });
//context.Marks.Add(new Mark() { MarkID = 135, LabNumber = 3, RecordBookNumberID = "136039", AdditionalPoints = 0, TheMark = 2, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });

//context.Marks.Add(new Mark() { MarkID = 136, LabNumber = 1, RecordBookNumberID = "136039", AdditionalPoints = 0, TheMark = 4, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });
//context.Marks.Add(new Mark() { MarkID = 137, LabNumber = 2, RecordBookNumberID = "136039", AdditionalPoints = 3, TheMark = 1, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });
//context.Marks.Add(new Mark() { MarkID = 138, LabNumber = 3, RecordBookNumberID = "136039", AdditionalPoints = 2, TheMark = 5, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });

//context.Marks.Add(new Mark() { MarkID = 139, LabNumber = 1, RecordBookNumberID = "136039", AdditionalPoints = 2, TheMark = 5, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });
//context.Marks.Add(new Mark() { MarkID = 140, LabNumber = 2, RecordBookNumberID = "136039", AdditionalPoints = 1, TheMark = 5, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });
//context.Marks.Add(new Mark() { MarkID = 141, LabNumber = 3, RecordBookNumberID = "136039", AdditionalPoints = 3, TheMark = 5, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });



//context.Marks.Add(new Mark() { MarkID = 142, LabNumber = 1, RecordBookNumberID = "136040", AdditionalPoints = 0, TheMark = 5, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });
//context.Marks.Add(new Mark() { MarkID = 143, LabNumber = 2, RecordBookNumberID = "136040", AdditionalPoints = 0, TheMark = 3, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });
//context.Marks.Add(new Mark() { MarkID = 144, LabNumber = 3, RecordBookNumberID = "136040", AdditionalPoints = 2, TheMark = 3, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });

//context.Marks.Add(new Mark() { MarkID = 145, LabNumber = 1, RecordBookNumberID = "136040", AdditionalPoints = 1, TheMark = 2, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });
//context.Marks.Add(new Mark() { MarkID = 146, LabNumber = 2, RecordBookNumberID = "136040", AdditionalPoints = 2, TheMark = 4, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });
//context.Marks.Add(new Mark() { MarkID = 147, LabNumber = 3, RecordBookNumberID = "136040", AdditionalPoints = 3, TheMark = 4, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });

//context.Marks.Add(new Mark() { MarkID = 148, LabNumber = 1, RecordBookNumberID = "136040", AdditionalPoints = 3, TheMark = 1, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });
//context.Marks.Add(new Mark() { MarkID = 149, LabNumber = 2, RecordBookNumberID = "136040", AdditionalPoints = 1, TheMark = 5, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });
//context.Marks.Add(new Mark() { MarkID = 150, LabNumber = 3, RecordBookNumberID = "136040", AdditionalPoints = 1, TheMark = 5, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });

//context.Marks.Add(new Mark() { MarkID = 151, LabNumber = 1, RecordBookNumberID = "136040", AdditionalPoints = 1, TheMark = 4, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });
//context.Marks.Add(new Mark() { MarkID = 152, LabNumber = 2, RecordBookNumberID = "136040", AdditionalPoints = 3, TheMark = 4, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });
//context.Marks.Add(new Mark() { MarkID = 153, LabNumber = 3, RecordBookNumberID = "136040", AdditionalPoints = 3, TheMark = 5, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });

//context.Marks.Add(new Mark() { MarkID = 154, LabNumber = 1, RecordBookNumberID = "136040", AdditionalPoints = 0, TheMark = 2, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });
//context.Marks.Add(new Mark() { MarkID = 155, LabNumber = 2, RecordBookNumberID = "136040", AdditionalPoints = 3, TheMark = 3, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });
//context.Marks.Add(new Mark() { MarkID = 156, LabNumber = 3, RecordBookNumberID = "136040", AdditionalPoints = 0, TheMark = 1, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });

//context.Marks.Add(new Mark() { MarkID = 157, LabNumber = 1, RecordBookNumberID = "136040", AdditionalPoints = 3, TheMark = 3, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });
//context.Marks.Add(new Mark() { MarkID = 158, LabNumber = 2, RecordBookNumberID = "136040", AdditionalPoints = 3, TheMark = 1, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });
//context.Marks.Add(new Mark() { MarkID = 159, LabNumber = 3, RecordBookNumberID = "136040", AdditionalPoints = 0, TheMark = 3, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });

//context.Marks.Add(new Mark() { MarkID = 160, LabNumber = 1, RecordBookNumberID = "136040", AdditionalPoints = 3, TheMark = 2, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });
//context.Marks.Add(new Mark() { MarkID = 161, LabNumber = 2, RecordBookNumberID = "136040", AdditionalPoints = 2, TheMark = 1, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });
//context.Marks.Add(new Mark() { MarkID = 162, LabNumber = 3, RecordBookNumberID = "136040", AdditionalPoints = 3, TheMark = 4, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });

//context.Marks.Add(new Mark() { MarkID = 163, LabNumber = 1, RecordBookNumberID = "136040", AdditionalPoints = 2, TheMark = 2, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });
//context.Marks.Add(new Mark() { MarkID = 164, LabNumber = 2, RecordBookNumberID = "136040", AdditionalPoints = 3, TheMark = 4, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });
//context.Marks.Add(new Mark() { MarkID = 165, LabNumber = 3, RecordBookNumberID = "136040", AdditionalPoints = 0, TheMark = 3, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });



//context.Marks.Add(new Mark() { MarkID = 166, LabNumber = 1, RecordBookNumberID = "136041", AdditionalPoints = 0, TheMark = 4, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });
//context.Marks.Add(new Mark() { MarkID = 167, LabNumber = 2, RecordBookNumberID = "136041", AdditionalPoints = 3, TheMark = 3, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });
//context.Marks.Add(new Mark() { MarkID = 168, LabNumber = 3, RecordBookNumberID = "136041", AdditionalPoints = 2, TheMark = 5, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });

//context.Marks.Add(new Mark() { MarkID = 169, LabNumber = 1, RecordBookNumberID = "136041", AdditionalPoints = 3, TheMark = 1, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });
//context.Marks.Add(new Mark() { MarkID = 170, LabNumber = 2, RecordBookNumberID = "136041", AdditionalPoints = 1, TheMark = 2, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });
//context.Marks.Add(new Mark() { MarkID = 171, LabNumber = 3, RecordBookNumberID = "136041", AdditionalPoints = 3, TheMark = 5, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });

//context.Marks.Add(new Mark() { MarkID = 172, LabNumber = 1, RecordBookNumberID = "136041", AdditionalPoints = 3, TheMark = 1, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });
//context.Marks.Add(new Mark() { MarkID = 173, LabNumber = 2, RecordBookNumberID = "136041", AdditionalPoints = 2, TheMark = 5, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });
//context.Marks.Add(new Mark() { MarkID = 174, LabNumber = 3, RecordBookNumberID = "136041", AdditionalPoints = 3, TheMark = 2, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });

//context.Marks.Add(new Mark() { MarkID = 175, LabNumber = 1, RecordBookNumberID = "136041", AdditionalPoints = 3, TheMark = 5, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });
//context.Marks.Add(new Mark() { MarkID = 176, LabNumber = 2, RecordBookNumberID = "136041", AdditionalPoints = 1, TheMark = 2, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });
//context.Marks.Add(new Mark() { MarkID = 177, LabNumber = 3, RecordBookNumberID = "136041", AdditionalPoints = 3, TheMark = 4, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });

//context.Marks.Add(new Mark() { MarkID = 178, LabNumber = 1, RecordBookNumberID = "136041", AdditionalPoints = 2, TheMark = 2, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });
//context.Marks.Add(new Mark() { MarkID = 179, LabNumber = 2, RecordBookNumberID = "136041", AdditionalPoints = 3, TheMark = 3, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });
//context.Marks.Add(new Mark() { MarkID = 180, LabNumber = 3, RecordBookNumberID = "136041", AdditionalPoints = 0, TheMark = 2, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });

//context.Marks.Add(new Mark() { MarkID = 181, LabNumber = 1, RecordBookNumberID = "136041", AdditionalPoints = 0, TheMark = 3, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });
//context.Marks.Add(new Mark() { MarkID = 182, LabNumber = 2, RecordBookNumberID = "136041", AdditionalPoints = 3, TheMark = 3, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });
//context.Marks.Add(new Mark() { MarkID = 183, LabNumber = 3, RecordBookNumberID = "136041", AdditionalPoints = 2, TheMark = 3, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });

//context.Marks.Add(new Mark() { MarkID = 184, LabNumber = 1, RecordBookNumberID = "136041", AdditionalPoints = 3, TheMark = 3, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });
//context.Marks.Add(new Mark() { MarkID = 185, LabNumber = 2, RecordBookNumberID = "136041", AdditionalPoints = 2, TheMark = 4, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });
//context.Marks.Add(new Mark() { MarkID = 186, LabNumber = 3, RecordBookNumberID = "136041", AdditionalPoints = 2, TheMark = 2, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });

//context.Marks.Add(new Mark() { MarkID = 187, LabNumber = 1, RecordBookNumberID = "136041", AdditionalPoints = 2, TheMark = 2, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });
//context.Marks.Add(new Mark() { MarkID = 188, LabNumber = 2, RecordBookNumberID = "136041", AdditionalPoints = 2, TheMark = 2, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });
//context.Marks.Add(new Mark() { MarkID = 189, LabNumber = 3, RecordBookNumberID = "136041", AdditionalPoints = 1, TheMark = 3, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });



//context.Marks.Add(new Mark() { MarkID = 190, LabNumber = 1, RecordBookNumberID = "136019", AdditionalPoints = 1, TheMark = 5, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });
//context.Marks.Add(new Mark() { MarkID = 191, LabNumber = 2, RecordBookNumberID = "136019", AdditionalPoints = 3, TheMark = 4, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });
//context.Marks.Add(new Mark() { MarkID = 192, LabNumber = 3, RecordBookNumberID = "136019", AdditionalPoints = 2, TheMark = 5, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });

//context.Marks.Add(new Mark() { MarkID = 193, LabNumber = 1, RecordBookNumberID = "136019", AdditionalPoints = 3, TheMark = 4, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });
//context.Marks.Add(new Mark() { MarkID = 194, LabNumber = 2, RecordBookNumberID = "136019", AdditionalPoints = 0, TheMark = 5, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });
//context.Marks.Add(new Mark() { MarkID = 195, LabNumber = 3, RecordBookNumberID = "136019", AdditionalPoints = 3, TheMark = 3, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });

//context.Marks.Add(new Mark() { MarkID = 196, LabNumber = 1, RecordBookNumberID = "136019", AdditionalPoints = 2, TheMark = 5, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });
//context.Marks.Add(new Mark() { MarkID = 197, LabNumber = 2, RecordBookNumberID = "136019", AdditionalPoints = 3, TheMark = 5, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });
//context.Marks.Add(new Mark() { MarkID = 198, LabNumber = 3, RecordBookNumberID = "136019", AdditionalPoints = 3, TheMark = 3, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });

//context.Marks.Add(new Mark() { MarkID = 199, LabNumber = 1, RecordBookNumberID = "136019", AdditionalPoints = 1, TheMark = 3, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });
//context.Marks.Add(new Mark() { MarkID = 200, LabNumber = 2, RecordBookNumberID = "136019", AdditionalPoints = 3, TheMark = 4, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });
//context.Marks.Add(new Mark() { MarkID = 201, LabNumber = 3, RecordBookNumberID = "136019", AdditionalPoints = 0, TheMark = 3, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });

//context.Marks.Add(new Mark() { MarkID = 202, LabNumber = 1, RecordBookNumberID = "136019", AdditionalPoints = 1, TheMark = 3, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });
//context.Marks.Add(new Mark() { MarkID = 203, LabNumber = 2, RecordBookNumberID = "136019", AdditionalPoints = 4, TheMark = 2, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });
//context.Marks.Add(new Mark() { MarkID = 204, LabNumber = 3, RecordBookNumberID = "136019", AdditionalPoints = 2, TheMark = 5, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });

//context.Marks.Add(new Mark() { MarkID = 205, LabNumber = 1, RecordBookNumberID = "136019", AdditionalPoints = 1, TheMark = 4, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });
//context.Marks.Add(new Mark() { MarkID = 206, LabNumber = 2, RecordBookNumberID = "136019", AdditionalPoints = 3, TheMark = 2, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });
//context.Marks.Add(new Mark() { MarkID = 207, LabNmber = 3, RecordBookNumberID = "136019", AdditionalPoints = 3, TheMark = 5, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });

//context.Marks.Add(new Mark() { MarkID = 208, LabNumber = 1, RecordBookNumberID = "136019", AdditionalPoints = 3, TheMark = 5, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });
//context.Marks.Add(new Mark() { MarkID = 209, LabNumber = 2, RecordBookNumberID = "136019", AdditionalPoints = 3, TheMark = 3, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });
//context.Marks.Add(new Mark() { MarkID = 210, LabNumber = 3, RecordBookNumberID = "136019", AdditionalPoints = 2, TheMark = 4, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });

//context.Marks.Add(new Mark() { MarkID = 211, LabNumber = 1, RecordBookNumberID = "136019", AdditionalPoints = 1, TheMark = 5, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });
//context.Marks.Add(new Mark() { MarkID = 212, LabNumber = 2, RecordBookNumberID = "136019", AdditionalPoints = 1, TheMark = 5, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });
//context.Marks.Add(new Mark() { MarkID = 213, LabNumber = 3, RecordBookNumberID = "136019", AdditionalPoints = 2, TheMark = 4, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });



//context.Marks.Add(new Mark() { MarkID = 214, LabNumber = 1, RecordBookNumberID = "136020", AdditionalPoints = 3, TheMark = 5, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });
//context.Marks.Add(new Mark() { MarkID = 215, LabNumber = 2, RecordBookNumberID = "136020", AdditionalPoints = 3, TheMark = 4, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });
//context.Marks.Add(new Mark() { MarkID = 216, LabNumber = 3, RecordBookNumberID = "136020", AdditionalPoints = 2, TheMark = 3, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });

//context.Marks.Add(new Mark() { MarkID = 217, LabNumber = 1, RecordBookNumberID = "136020", AdditionalPoints = 3, TheMark = 4, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });
//context.Marks.Add(new Mark() { MarkID = 218, LabNumber = 2, RecordBookNumberID = "136020", AdditionalPoints = 1, TheMark = 3, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });
//context.Marks.Add(new Mark() { MarkID = 219, LabNumber = 3, RecordBookNumberID = "136020", AdditionalPoints = 3, TheMark = 5, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });

//context.Marks.Add(new Mark() { MarkID = 220, LabNumber = 1, RecordBookNumberID = "136020", AdditionalPoints = 2, TheMark = 4, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });
//context.Marks.Add(new Mark() { MarkID = 221, LabNumber = 2, RecordBookNumberID = "136020", AdditionalPoints = 3, TheMark = 4, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });
//context.Marks.Add(new Mark() { MarkID = 222, LabNumber = 3, RecordBookNumberID = "136020", AdditionalPoints = 2, TheMark = 3, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });

//context.Marks.Add(new Mark() { MarkID = 223, LabNumber = 1, RecordBookNumberID = "136020", AdditionalPoints = 1, TheMark = 5, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });
//context.Marks.Add(new Mark() { MarkID = 224, LabNumber = 2, RecordBookNumberID = "136020", AdditionalPoints = 1, TheMark = 4, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });
//context.Marks.Add(new Mark() { MarkID = 225, LabNumber = 3, RecordBookNumberID = "136020", AdditionalPoints = 0, TheMark = 4, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });

//context.Marks.Add(new Mark() { MarkID = 226, LabNumber = 1, RecordBookNumberID = "136020", AdditionalPoints = 1, TheMark = 3, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });
//context.Marks.Add(new Mark() { MarkID = 227, LabNumber = 2, RecordBookNumberID = "136020", AdditionalPoints = 3, TheMark = 5, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });
//context.Marks.Add(new Mark() { MarkID = 228, LabNumber = 3, RecordBookNumberID = "136020", AdditionalPoints = 2, TheMark = 5, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });

//context.Marks.Add(new Mark() { MarkID = 229, LabNumber = 1, RecordBookNumberID = "136020", AdditionalPoints = 1, TheMark = 3, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });
//context.Marks.Add(new Mark() { MarkID = 230, LabNumber = 2, RecordBookNumberID = "136020", AdditionalPoints = 0, TheMark = 2, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });
//context.Marks.Add(new Mark() { MarkID = 231, LabNumber = 3, RecordBookNumberID = "136020", AdditionalPoints = 3, TheMark = 5, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });

//context.Marks.Add(new Mark() { MarkID = 232, LabNumber = 1, RecordBookNumberID = "136020", AdditionalPoints = 1, TheMark = 5, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });
//context.Marks.Add(new Mark() { MarkID = 233, LabNumber = 2, RecordBookNumberID = "136020", AdditionalPoints = 3, TheMark = 4, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });
//context.Marks.Add(new Mark() { MarkID = 234, LabNumber = 3, RecordBookNumberID = "136020", AdditionalPoints = 2, TheMark = 4, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });

//context.Marks.Add(new Mark() { MarkID = 235, LabNumber = 1, RecordBookNumberID = "136020", AdditionalPoints = 1, TheMark = 3, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });
//context.Marks.Add(new Mark() { MarkID = 236, LabNumber = 2, RecordBookNumberID = "136020", AdditionalPoints = 5, TheMark = 5, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });
//context.Marks.Add(new Mark() { MarkID = 237, LabNumber = 3, RecordBookNumberID = "136020", AdditionalPoints = 2, TheMark = 4, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });



//context.Marks.Add(new Mark() { MarkID = 238, LabNumber = 1, RecordBookNumberID = "136021", AdditionalPoints = 3, TheMark = 3, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });
//context.Marks.Add(new Mark() { MarkID = 239, LabNumber = 2, RecordBookNumberID = "136021", AdditionalPoints = 3, TheMark = 4, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });
//context.Marks.Add(new Mark() { MarkID = 240, LabNumber = 3, RecordBookNumberID = "136021", AdditionalPoints = 2, TheMark = 2, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });

//context.Marks.Add(new Mark() { MarkID = 241, LabNumber = 1, RecordBookNumberID = "136021", AdditionalPoints = 3, TheMark = 5, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });
//context.Marks.Add(new Mark() { MarkID = 242, LabNumber = 2, RecordBookNumberID = "136021", AdditionalPoints = 1, TheMark = 3, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });
//context.Marks.Add(new Mark() { MarkID = 243, LabNumber = 3, RecordBookNumberID = "136021", AdditionalPoints = 3, TheMark = 5, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });

//context.Marks.Add(new Mark() { MarkID = 244, LabNumber = 1, RecordBookNumberID = "136021", AdditionalPoints = 2, TheMark = 4, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });
//context.Marks.Add(new Mark() { MarkID = 245, LabNumber = 2, RecordBookNumberID = "136021", AdditionalPoints = 3, TheMark = 4, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });
//context.Marks.Add(new Mark() { MarkID = 246, LabNumber = 3, RecordBookNumberID = "136021", AdditionalPoints = 2, TheMark = 5, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });

//context.Marks.Add(new Mark() { MarkID = 247, LabNumber = 1, RecordBookNumberID = "136021", AdditionalPoints = 1, TheMark = 5, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });
//context.Marks.Add(new Mark() { MarkID = 248, LabNumber = 2, RecordBookNumberID = "136021", AdditionalPoints = 1, TheMark = 5, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });
//context.Marks.Add(new Mark() { MarkID = 249, LabNumber = 3, RecordBookNumberID = "136021", AdditionalPoints = 0, TheMark = 5, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });

//context.Marks.Add(new Mark() { MarkID = 250, LabNumber = 1, RecordBookNumberID = "136021", AdditionalPoints = 1, TheMark = 3, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });
//context.Marks.Add(new Mark() { MarkID = 251, LabNumber = 2, RecordBookNumberID = "136021", AdditionalPoints = 3, TheMark = 5, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });
//context.Marks.Add(new Mark() { MarkID = 252, LabNumber = 3, RecordBookNumberID = "136021", AdditionalPoints = 2, TheMark = 5, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });

//context.Marks.Add(new Mark() { MarkID = 253, LabNumber = 1, RecordBookNumberID = "136021", AdditionalPoints = 1, TheMark = 3, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });
//context.Marks.Add(new Mark() { MarkID = 254, LabNumber = 2, RecordBookNumberID = "136021", AdditionalPoints = 0, TheMark = 5, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });
//context.Marks.Add(new Mark() { MarkID = 255, Labumber = 3, RecordBookNumberID = "136021", AdditionalPoints = 3, TheMark = 5, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });

//context.Marks.Add(new Mark() { MarkID = 256, LabNumber = 1, RecordBookNumberID = "136021", AdditionalPoints = 1, TheMark = 5, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });
//context.Marks.Add(new Mark() { MarkID = 257, LabNumber = 2, RecordBookNumberID = "136021", AdditionalPoints = 3, TheMark = 4, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });
//context.Marks.Add(new Mark() { MarkID = 258, LabNumber = 3, RecordBookNumberID = "136021", AdditionalPoints = 2, TheMark = 5, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });

//context.Marks.Add(new Mark() { MarkID = 259, LabNumber = 1, RecordBookNumberID = "136021", AdditionalPoints = 1, TheMark = 5, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });
//context.Marks.Add(new Mark() { MarkID = 260, LabNumber = 2, RecordBookNumberID = "136021", AdditionalPoints = 5, TheMark = 5, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });
//context.Marks.Add(new Mark() { MarkID = 261, LabNumber = 3, RecordBookNumberID = "136021", AdditionalPoints = 2, TheMark = 4, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });



//context.Marks.Add(new Mark() { MarkID = 262, LabNumber = 1, RecordBookNumberID = "136022", AdditionalPoints = 2, TheMark = 3, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });
//context.Marks.Add(new Mark() { MarkID = 263, LabNumber = 2, RecordBookNumberID = "136022", AdditionalPoints = 2, TheMark = 3, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });
//context.Marks.Add(new Mark() { MarkID = 264, LabNumber = 3, RecordBookNumberID = "136022", AdditionalPoints = 2, TheMark = 2, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });

//context.Marks.Add(new Mark() { MarkID = 265, LabNumber = 1, RecordBookNumberID = "136022", AdditionalPoints = 3, TheMark = 3, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });
//context.Marks.Add(new Mark() { MarkID = 266, LabNumber = 2, RecordBookNumberID = "136022", AdditionalPoints = 2, TheMark = 3, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });
//context.Marks.Add(new Mark() { MarkID = 267, LabNumber = 3, RecordBookNumberID = "136022", AdditionalPoints = 3, TheMark = 5, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });

//context.Marks.Add(new Mark() { MarkID = 268, LabNumber = 1, RecordBookNumberID = "136022", AdditionalPoints = 1, TheMark = 4, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });
//context.Marks.Add(new Mark() { MarkID = 269, LabNumber = 2, RecordBookNumberID = "136022", AdditionalPoints = 2, TheMark = 3, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });
//context.Marks.Add(new Mark() { MarkID = 270, LabNumber = 3, RecordBookNumberID = "136022", AdditionalPoints = 2, TheMark = 3, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });

//context.Marks.Add(new Mark() { MarkID = 271, LabNumber = 1, RecordBookNumberID = "136022", AdditionalPoints = 1, TheMark = 4, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });
//context.Marks.Add(new Mark() { MarkID = 272, LabNumber = 2, RecordBookNumberID = "136022", AdditionalPoints = 2, TheMark = 3, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });
//context.Marks.Add(new Mark() { MarkID = 273, LabNumber = 3, RecordBookNumberID = "136022", AdditionalPoints = 0, TheMark = 5, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });

//context.Marks.Add(new Mark() { MarkID = 274, LabNumber = 1, RecordBookNumberID = "136022", AdditionalPoints = 1, TheMark = 3, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });
//context.Marks.Add(new Mark() { MarkID = 275, LabNumber = 2, RecordBookNumberID = "136022", AdditionalPoints = 1, TheMark = 3, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });
//context.Marks.Add(new Mark() { MarkID = 276, LabNumber = 3, RecordBookNumberID = "136022", AdditionalPoints = 2, TheMark = 3, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });

//context.Marks.Add(new Mark() { MarkID = 277, LabNumber = 1, RecordBookNumberID = "136022", AdditionalPoints = 2, TheMark = 3, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });
//context.Marks.Add(new Mark() { MarkID = 278, LabNumber = 2, RecordBookNumberID = "136022", AdditionalPoints = 0, TheMark = 5, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });
//context.Marks.Add(new Mark() { MarkID = 279, LabNumber = 3, RecordBookNumberID = "136022", AdditionalPoints = 0, TheMark = 3, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });

//context.Marks.Add(new Mark() { MarkID = 280, LabNumber = 1, RecordBookNumberID = "136022", AdditionalPoints = 1, TheMark = 5, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });
//context.Marks.Add(new Mark() { MarkID = 281, LabNumber = 2, RecordBookNumberID = "136022", AdditionalPoints = 1, TheMark = 4, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });
//context.Marks.Add(new Mark() { MarkID = 282, LabNumber = 3, RecordBookNumberID = "136022", AdditionalPoints = 1, TheMark = 3, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });

//context.Marks.Add(new Mark() { MarkID = 283, LabNumber = 1, RecordBookNumberID = "136022", AdditionalPoints = 1, TheMark = 5, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });
//context.Marks.Add(new Mark() { MarkID = 284, LabNumber = 2, RecordBookNumberID = "136022", AdditionalPoints = 1, TheMark = 3, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });
//context.Marks.Add(new Mark() { MarkID = 285, LabNumber = 3, RecordBookNumberID = "136022", AdditionalPoints = 2, TheMark = 4, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });



//context.Marks.Add(new Mark() { MarkID = 286, LabNumber = 1, RecordBookNumberID = "136023", AdditionalPoints = 3, TheMark = 3, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });
//context.Marks.Add(new Mark() { MarkID = 287, LabNumber = 2, RecordBookNumberID = "136023", AdditionalPoints = 3, TheMark = 3, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });
//context.Marks.Add(new Mark() { MarkID = 288, LabNumber = 3, RecordBookNumberID = "136023", AdditionalPoints = 2, TheMark = 2, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });

//context.Marks.Add(new Mark() { MarkID = 289, LabNumber = 1, RecordBookNumberID = "136023", AdditionalPoints = 3, TheMark = 3, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });
//context.Marks.Add(new Mark() { MarkID = 290, LabNumber = 2, RecordBookNumberID = "136023", AdditionalPoints = 1, TheMark = 3, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });
//context.Marks.Add(new Mark() { MarkID = 291, LabNumber = 3, RecordBookNumberID = "136023", AdditionalPoints = 3, TheMark = 2, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });

//context.Marks.Add(new Mark() { MarkID = 292, LabNumber = 1, RecordBookNumberID = "136023", AdditionalPoints = 2, TheMark = 4, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });
//context.Marks.Add(new Mark() { MarkID = 293, LabNumber = 2, RecordBookNumberID = "136023", AdditionalPoints = 3, TheMark = 3, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });
//context.Marks.Add(new Mark() { MarkID = 294, LabNumber = 3, RecordBookNumberID = "136023", AdditionalPoints = 2, TheMark = 3, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });

//context.Marks.Add(new Mark() { MarkID = 295, LabNumber = 1, RecordBookNumberID = "136023", AdditionalPoints = 1, TheMark = 4, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });
//context.Marks.Add(new Mark() { MarkID = 296, LabNumber = 2, RecordBookNumberID = "136023", AdditionalPoints = 1, TheMark = 5, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });
//context.Marks.Add(new Mark() { MarkID = 297, LabNumber = 3, RecordBookNumberID = "136023", AdditionalPoints = 0, TheMark = 5, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });

//context.Marks.Add(new Mark() { MarkID = 298, LabNumber = 1, RecordBookNumberID = "136023", AdditionalPoints = 1, TheMark = 3, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });
//context.Marks.Add(new Mark() { MarkID = 299, LabNumber = 2, RecordBookNumberID = "136023", AdditionalPoints = 3, TheMark = 5, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });
//context.Marks.Add(new Mark() { MarkID = 300, LabNumber = 3, RecordBookNumberID = "136023", AdditionalPoints = 2, TheMark = 3, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });

//context.Marks.Add(new Mark() { MarkID = 301, LabNumber = 1, RecordBookNumberID = "136023", AdditionalPoints = 1, TheMark = 5, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });
//context.Marks.Add(new Mark() { MarkID = 302, LabNumber = 2, RecordBookNumberID = "136023", AdditionalPoints = 0, TheMark = 5, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });
//context.Marks.Add(new Mark() { MarkID = 303, LabNumber = 3, RecordBookNumberID = "136023", AdditionalPoints = 3, TheMark = 3, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });

//context.Marks.Add(new Mark() { MarkID = 304, LabNumber = 1, RecordBookNumberID = "136023", AdditionalPoints = 1, TheMark = 5, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });
//context.Marks.Add(new Mark() { MarkID = 305, LabNumber = 2, RecordBookNumberID = "136023", AdditionalPoints = 3, TheMark = 5, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });
//context.Marks.Add(new Mark() { MarkID = 306, LabNumber = 3, RecordBookNumberID = "136023", AdditionalPoints = 2, TheMark = 3, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });

//context.Marks.Add(new Mark() { MarkID = 307, LabNumber = 1, RecordBookNumberID = "136023", AdditionalPoints = 1, TheMark = 5, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });
//context.Marks.Add(new Mark() { MarkID = 308, LabNumber = 2, RecordBookNumberID = "136023", AdditionalPoints = 5, TheMark = 5, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });
//context.Marks.Add(new Mark() { MarkID = 309, LabNumber = 3, RecordBookNumberID = "136023", AdditionalPoints = 2, TheMark = 4, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });



//context.Marks.Add(new Mark() { MarkID = 310, LabNumber = 1, RecordBookNumberID = "136057", AdditionalPoints = 2, TheMark = 5, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });
//context.Marks.Add(new Mark() { MarkID = 311, LabNumber = 2, RecordBookNumberID = "136057", AdditionalPoints = 0, TheMark = 3, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });
//context.Marks.Add(new Mark() { MarkID = 312, LabNumber = 3, RecordBookNumberID = "136057", AdditionalPoints = 2, TheMark = 5, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });

//context.Marks.Add(new Mark() { MarkID = 313, LabNumber = 1, RecordBookNumberID = "136057", AdditionalPoints = 0, TheMark = 5, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });
//context.Marks.Add(new Mark() { MarkID = 314, LabNumber = 2, RecordBookNumberID = "136057", AdditionalPoints = 1, TheMark = 5, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });
//context.Marks.Add(new Mark() { MarkID = 315, LabNumber = 3, RecordBookNumberID = "136057", AdditionalPoints = 3, TheMark = 2, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });

//context.Marks.Add(new Mark() { MarkID = 316, LabNumber = 1, RecordBookNumberID = "136057", AdditionalPoints = 2, TheMark = 5, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });
//context.Marks.Add(new Mark() { MarkID = 317, LabNumber = 2, RecordBookNumberID = "136057", AdditionalPoints = 0, TheMark = 5, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });
//context.Marks.Add(new Mark() { MarkID = 318, LabNumber = 3, RecordBookNumberID = "136057", AdditionalPoints = 2, TheMark = 5, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });

//context.Marks.Add(new Mark() { MarkID = 319, LabNumber = 1, RecordBookNumberID = "136057", AdditionalPoints = 3, TheMark = 5, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });
//context.Marks.Add(new Mark() { MarkID = 320, LabNumber = 2, RecordBookNumberID = "136057", AdditionalPoints = 1, TheMark = 5, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });
//context.Marks.Add(new Mark() { MarkID = 321, LabNumber = 3, RecordBookNumberID = "136057", AdditionalPoints = 0, TheMark = 5, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });

//context.Marks.Add(new Mark() { MarkID = 322, LabNumber = 1, RecordBookNumberID = "136057", AdditionalPoints = 2, TheMark = 5, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });
//context.Marks.Add(new Mark() { MarkID = 323, LabNumber = 2, RecordBookNumberID = "136057", AdditionalPoints = 3, TheMark = 5, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });
//context.Marks.Add(new Mark() { MarkID = 324, LabNumber = 3, RecordBookNumberID = "136057", AdditionalPoints = 2, TheMark = 3, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });

//context.Marks.Add(new Mark() { MarkID = 325, LabNumber = 1, RecordBookNumberID = "136057", AdditionalPoints = 1, TheMark = 5, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });
//context.Marks.Add(new Mark() { MarkID = 326, LabNumber = 2, RecordBookNumberID = "136057", AdditionalPoints = 2, TheMark = 5, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });
//context.Marks.Add(new Mark() { MarkID = 327, LabNumber = 3, RecordBookNumberID = "136057", AdditionalPoints = 3, TheMark = 4, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });

//context.Marks.Add(new Mark() { MarkID = 328, LabNumber = 1, RecordBookNumberID = "136057", AdditionalPoints = 3, TheMark = 5, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });
//context.Marks.Add(new Mark() { MarkID = 329, LabNumber = 2, RecordBookNumberID = "136057", AdditionalPoints = 3, TheMark = 4, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });
//context.Marks.Add(new Mark() { MarkID = 330, LabNumber = 3, RecordBookNumberID = "136057", AdditionalPoints = 2, TheMark = 3, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });

//context.Marks.Add(new Mark() { MarkID = 331, LabNumber = 1, RecordBookNumberID = "136057", AdditionalPoints = 3, TheMark = 5, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });
//context.Marks.Add(new Mark() { MarkID = 332, LabNumber = 2, RecordBookNumberID = "136057", AdditionalPoints = 2, TheMark = 5, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });
//context.Marks.Add(new Mark() { MarkID = 333, LabNumber = 3, RecordBookNumberID = "136057", AdditionalPoints = 2, TheMark = 4, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });


//context.Marks.Add(new Mark() { MarkID = 334, LabNumber = 1, RecordBookNumberID = "136058", AdditionalPoints = 3, TheMark = 5, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });
//context.Marks.Add(new Mark() { MarkID = 335, LabNumber = 2, RecordBookNumberID = "136058", AdditionalPoints = 3, TheMark = 5, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });
//context.Marks.Add(new Mark() { MarkID = 336, LabNumber = 3, RecordBookNumberID = "136058", AdditionalPoints = 2, TheMark = 5, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });

//context.Marks.Add(new Mark() { MarkID = 337, LabNumber = 1, RecordBookNumberID = "136058", AdditionalPoints = 3, TheMark = 5, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });
//context.Marks.Add(new Mark() { MarkID = 338, LabNumber = 2, RecordBookNumberID = "136058", AdditionalPoints = 1, TheMark = 5, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });
//context.Marks.Add(new Mark() { MarkID = 339, LabNumber = 3, RecordBookNumberID = "136058", AdditionalPoints = 3, TheMark = 4, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });

//context.Marks.Add(new Mark() { MarkID = 340, LabNumber = 1, RecordBookNumberID = "136058", AdditionalPoints = 2, TheMark = 4, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });
//context.Marks.Add(new Mark() { MarkID = 341, LabNumber = 2, RecordBookNumberID = "136058", AdditionalPoints = 3, TheMark = 5, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });
//context.Marks.Add(new Mark() { MarkID = 342, LabNumber = 3, RecordBookNumberID = "136058", AdditionalPoints = 2, TheMark = 5, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });

//context.Marks.Add(new Mark() { MarkID = 343, LabNumber = 1, RecordBookNumberID = "136058", AdditionalPoints = 1, TheMark = 5, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });
//context.Marks.Add(new Mark() { MarkID = 344, LabNumber = 2, RecordBookNumberID = "136058", AdditionalPoints = 1, TheMark = 3, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });
//context.Marks.Add(new Mark() { MarkID = 345, LabNumber = 3, RecordBookNumberID = "136058", AdditionalPoints = 0, TheMark = 5, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });

//context.Marks.Add(new Mark() { MarkID = 346, LabNumber = 1, RecordBookNumberID = "136058", AdditionalPoints = 1, TheMark = 4, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });
//context.Marks.Add(new Mark() { MarkID = 347, LabNumber = 2, RecordBookNumberID = "136058", AdditionalPoints = 3, TheMark = 5, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });
//context.Marks.Add(new Mark() { MarkID = 348, LabNumber = 3, RecordBookNumberID = "136058", AdditionalPoints = 2, TheMark = 3, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });

//context.Marks.Add(new Mark() { MarkID = 349, LabNumber = 1, RecordBookNumberID = "136058", AdditionalPoints = 1, TheMark = 5, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });
//context.Marks.Add(new Mark() { MarkID = 350, LabNumber = 2, RecordBookNumberID = "136058", AdditionalPoints = 0, TheMark = 4, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });
//context.Marks.Add(new Mark() { MarkID = 351, LabNumber = 3, RecordBookNumberID = "136058", AdditionalPoints = 3, TheMark = 4, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });

//context.Marks.Add(new Mark() { MarkID = 352, LabNumber = 1, RecordBookNumberID = "136058", AdditionalPoints = 1, TheMark = 5, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });
//context.Marks.Add(new Mark() { MarkID = 353, LabNumber = 2, RecordBookNumberID = "136058", AdditionalPoints = 3, TheMark = 4, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });
//context.Marks.Add(new Mark() { MarkID = 354, LabNumber = 3, RecordBookNumberID = "136058", AdditionalPoints = 2, TheMark = 5, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });

//context.Marks.Add(new Mark() { MarkID = 355, LabNumber = 1, RecordBookNumberID = "136058", AdditionalPoints = 1, TheMark = 5, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });
//context.Marks.Add(new Mark() { MarkID = 356, LabNumber = 2, RecordBookNumberID = "136058", AdditionalPoints = 5, TheMark = 5, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });
//context.Marks.Add(new Mark() { MarkID = 357, LabNumber = 3, RecordBookNumberID = "136058", AdditionalPoints = 2, TheMark = 3, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });



//context.Marks.Add(new Mark() { MarkID = 358, LabNumber = 1, RecordBookNumberID = "136059", AdditionalPoints = 1, TheMark = 4, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });
//context.Marks.Add(new Mark() { MarkID = 359, LabNumber = 2, RecordBookNumberID = "136059", AdditionalPoints = 3, TheMark = 5, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });
//context.Marks.Add(new Mark() { MarkID = 360, LabNumber = 3, RecordBookNumberID = "136059", AdditionalPoints = 2, TheMark = 5, SubjectID = "Основы программирования", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 11, Term = 1 });

//context.Marks.Add(new Mark() { MarkID = 361, LabNumber = 1, RecordBookNumberID = "136059", AdditionalPoints = 3, TheMark = 5, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });
//context.Marks.Add(new Mark() { MarkID = 362, LabNumber = 2, RecordBookNumberID = "136059", AdditionalPoints = 3, TheMark = 5, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });
//context.Marks.Add(new Mark() { MarkID = 363, LabNumber = 3, RecordBookNumberID = "136059", AdditionalPoints = 3, TheMark = 5, SubjectID = "Групповая динамика и коммуникации", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 14, Term = 2 });

//context.Marks.Add(new Mark() { MarkID = 364, LabNumber = 1, RecordBookNumberID = "136059", AdditionalPoints = 2, TheMark = 5, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });
//context.Marks.Add(new Mark() { MarkID = 365, LabNumber = 2, RecordBookNumberID = "136059", AdditionalPoints = 2, TheMark = 5, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });
//context.Marks.Add(new Mark() { MarkID = 366, LabNumber = 3, RecordBookNumberID = "136059", AdditionalPoints = 2, TheMark = 5, SubjectID = "Объектно-ориентированное программирование", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 17, Term = 3 });

//context.Marks.Add(new Mark() { MarkID = 367, LabNumber = 1, RecordBookNumberID = "136059", AdditionalPoints = 1, TheMark = 5, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });
//context.Marks.Add(new Mark() { MarkID = 368, LabNumber = 2, RecordBookNumberID = "136059", AdditionalPoints = 1, TheMark = 4, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });
//context.Marks.Add(new Mark() { MarkID = 369, LabNumber = 3, RecordBookNumberID = "136059", AdditionalPoints = 0, TheMark = 5, SubjectID = "Алгоритмы и структуры данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 6, Term = 4 });

//context.Marks.Add(new Mark() { MarkID = 370, LabNumber = 1, RecordBookNumberID = "136059", AdditionalPoints = 3, TheMark = 5, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });
//context.Marks.Add(new Mark() { MarkID = 371, LabNumber = 2, RecordBookNumberID = "136059", AdditionalPoints = 3, TheMark = 5, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });
//context.Marks.Add(new Mark() { MarkID = 372, LabNumber = 3, RecordBookNumberID = "136059", AdditionalPoints = 2, TheMark = 4, SubjectID = "Операционные системы", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 18, Term = 5 });

//context.Marks.Add(new Mark() { MarkID = 373, LabNumber = 1, RecordBookNumberID = "136059", AdditionalPoints = 2, TheMark = 5, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });
//context.Marks.Add(new Mark() { MarkID = 374, LabNumber = 2, RecordBookNumberID = "136059", AdditionalPoints = 0, TheMark = 5, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });
//context.Marks.Add(new Mark() { MarkID = 375, LabNumber = 3, RecordBookNumberID = "136059", AdditionalPoints = 3, TheMark = 5, SubjectID = "Базы данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 4, Term = 6 });

//context.Marks.Add(new Mark() { MarkID = 376, LabNumber = 1, RecordBookNumberID = "136059", AdditionalPoints = 3, TheMark = 5, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });
//context.Marks.Add(new Mark() { MarkID = 377, LabNumber = 2, RecordBookNumberID = "136059", AdditionalPoints = 3, TheMark = 5, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });
//context.Marks.Add(new Mark() { MarkID = 378, LabNumber = 3, RecordBookNumberID = "136059", AdditionalPoints = 1, TheMark = 5, SubjectID = "Безопасность программ и данных", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 15, Term = 7 });

//context.Marks.Add(new Mark() { MarkID = 379, LabNumber = 1, RecordBookNumberID = "136059", AdditionalPoints = 3, TheMark = 4, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });
//context.Marks.Add(new Mark() { MarkID = 380, LabNumber = 2, RecordBookNumberID = "136059", AdditionalPoints = 2, TheMark = 5, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });
//context.Marks.Add(new Mark() { MarkID = 381, LabNumber = 3, RecordBookNumberID = "136059", AdditionalPoints = 1, TheMark = 4, SubjectID = "Проектирование производственных экспертных систем", DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now, TeacherID = 20, Term = 8 });
#endregion
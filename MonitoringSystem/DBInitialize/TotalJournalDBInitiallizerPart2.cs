using System;
using System.Data.Entity;

namespace MonitoringSystem.Models
{
    public partial class TotalJournalDBInitializer : DropCreateDatabaseAlways<TotalJournalContext>
    {     
        protected void GroupInit(ref TotalJournalContext context)
        {
            //номер группы           номер курса
            context.Groups.Add(new Group() { GroupID = "611п", CourseNumber = 1 });
            context.Groups.Add(new Group() { GroupID = "612п", CourseNumber = 1 });
            context.Groups.Add(new Group() { GroupID = "621п", CourseNumber = 2 });
            context.Groups.Add(new Group() { GroupID = "622п", CourseNumber = 2 });
            context.Groups.Add(new Group() { GroupID = "611пст", CourseNumber = 2 });
            context.Groups.Add(new Group() { GroupID = "631п", CourseNumber = 3 });
            context.Groups.Add(new Group() { GroupID = "632п", CourseNumber = 3 });
            context.Groups.Add(new Group() { GroupID = "621пст", CourseNumber = 3 });
            context.Groups.Add(new Group() { GroupID = "641п", CourseNumber = 4 });
            context.Groups.Add(new Group() { GroupID = "642п", CourseNumber = 4 });
            context.Groups.Add(new Group() { GroupID = "631пст", CourseNumber = 4 });
        }
        protected void StudentInit(ref TotalJournalContext context)
        {
            
    }
        //protected void StudentInit(ref TotalJournalContext context)
        //{
        //    //                                  номер зачетки                   имя                  фамилия             отчество
        //    context.Students.Add(new Student() { RecordBookNumberID = "436001", FirstName = "Катерина", LastName = "Андрющенко", MiddleName = "Сергеевна", GroupID = "641п"});
        //    context.Students.Add(new Student() { RecordBookNumberID = "436002", FirstName = "Денис", LastName = "Билецкий", MiddleName = "Романович", GroupID = "641п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436003", FirstName = "Илья", LastName = "Вирич", MiddleName = "Васильевич", GroupID = "641п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436004", FirstName = "Роман", LastName = "Гайдук", MiddleName = "Валерьевич", GroupID = "641п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436005", FirstName = "Борис", LastName = "Головкин", MiddleName = "Анатольевич", GroupID = "641п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436006", FirstName = "Артур", LastName = "Гулеватый", MiddleName = "Игоревич", GroupID = "641п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436007", FirstName = "Виталий", LastName = "Дворник", MiddleName = "Юрьевич", GroupID = "641п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436008", FirstName = "Михаил", LastName = "Дронов", MiddleName = "Эдуардович", GroupID = "641п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436009", FirstName = "Владислав", LastName = "Колесник", MiddleName = "Юрьевич", GroupID = "641п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436010", FirstName = "Артем", LastName = "Мирошниченко", MiddleName = "Валерьевич", GroupID = "641п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436011", FirstName = "Евгений", LastName = "Могилевский", MiddleName = "Романович", GroupID = "641п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436012", FirstName = "Катерина", LastName = "Плитник", MiddleName = "Витальевна", GroupID = "641п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436013", FirstName = "Вадим", LastName = "Рачков", MiddleName = "Сергеевич", GroupID = "641п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436014", FirstName = "Дмитрий", LastName = "Руденок", MiddleName = "Юрьевич", GroupID = "641п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436015", FirstName = "Оксана", LastName = "Ткаченко", MiddleName = "Витальевна", GroupID = "641п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436016", FirstName = "Артем", LastName = "Чуглазов", MiddleName = "Васильевич", GroupID = "641п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436017", FirstName = "Ростислав", LastName = "Шурухин", MiddleName = "Юрьевич", GroupID = "641п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436018", FirstName = "Александр", LastName = "Яценко", MiddleName = "Сергеевич", GroupID = "641п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436019", FirstName = "Евгений", LastName = "Виноградный", MiddleName = "Олегович", GroupID = "642п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436020", FirstName = "Валерий", LastName = "Глянцев", MiddleName = "Олегович", GroupID = "642п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436021", FirstName = "Диана", LastName = "Грушко", MiddleName = "Александровна", GroupID = "642п" });

        //    context.Students.Add(new Student() { RecordBookNumberID = "436022", FirstName = "Анна", LastName = "Дорошенко", MiddleName = "Сергеевна", GroupID = "642п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436023", FirstName = "Александр", LastName = "Жуган", MiddleName = "Александрович", GroupID = "642п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436024", FirstName = "Александр", LastName = "Ильченко", MiddleName = "Анатольевич", GroupID = "642п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436025", FirstName = "Сергей", LastName = "Клименко", MiddleName = "Юрьевич", GroupID = "642п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436026", FirstName = "Юрий", LastName = "Кудринский", MiddleName = "Михайлович", GroupID = "642п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436027", FirstName = "Александр", LastName = "Кушнарев", MiddleName = "Александрович", GroupID = "642п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436028", FirstName = "Владислав", LastName = "Мокеев", MiddleName = "Олегович", GroupID = "642п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436029", FirstName = "Полина", LastName = "Надеева", MiddleName = "Егоровна", GroupID = "642п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436030", FirstName = "Владислав", LastName = "Овчаренко", MiddleName = "Витальевич", GroupID = "642п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436031", FirstName = "Денис", LastName = "Пилипенко", MiddleName = "Петрович", GroupID = "642п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436032", FirstName = "Владислав", LastName = "Рогинский", MiddleName = "Михайлович", GroupID = "642п" });

        //    context.Students.Add(new Student() { RecordBookNumberID = "436033", FirstName = "Ярослав", LastName = "Рягузов", MiddleName = "Алексеевич", GroupID = "642п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436034", FirstName = "Александр", LastName = "Силин", MiddleName = "Олегович", GroupID = "642п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436035", FirstName = "Руслан", LastName = "Тибилашвли", MiddleName = "Викторович", GroupID = "642п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436036", FirstName = "Андрей", LastName = "Турянский", MiddleName = "Олегович", GroupID = "642п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436037", FirstName = "Богдан", LastName = "Хон", MiddleName = "Игоревич", GroupID = "642п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436038", FirstName = "Анастасия", LastName = "Чередник", MiddleName = "Юрьевна", GroupID = "642п" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436039", FirstName = "Олег", LastName = "Бордаков", MiddleName = "Васильевич", GroupID = "631пст" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436040", FirstName = "Александр", LastName = "Глущенко", MiddleName = "Эдуардович", GroupID = "631пст" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436041", FirstName = "Александр", LastName = "Драшпуль", MiddleName = "Юрьевич", GroupID = "631пст" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436042", FirstName = "Анастасия", LastName = "Дучкина", MiddleName = "Михайловна", GroupID = "631пст" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436043", FirstName = "Виталий", LastName = "Комаровский", MiddleName = "Константинович", GroupID = "631пст" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436044", FirstName = "Ирина", LastName = "Крайнюкова", MiddleName = "Сергеевна", GroupID = "631пст" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436045", FirstName = "Дмитрий", LastName = "Курдюков", MiddleName = "Семенович", GroupID = "631пст" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436046", FirstName = "Евгения", LastName = "Ламтюгова", MiddleName = " Ильинична", GroupID = "631пст" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436047", FirstName = "Илья", LastName = "Олешко", MiddleName = "Сергеевич", GroupID = "631пст" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436048", FirstName = "Евгений", LastName = "Погорельцев", MiddleName = "Семенович", GroupID = "631пст" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436049", FirstName = "Александр", LastName = "Савинков", MiddleName = "Максимович", GroupID = "631пст" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436050", FirstName = "Александр", LastName = "Сирота", MiddleName = "Юрьевич", GroupID = "631пст" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436051", FirstName = "Ксения", LastName = "Сич", MiddleName = "Сергеевна", GroupID = "631пст" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436052", FirstName = "Андрей", LastName = "Телешев", MiddleName = "Александрович", GroupID = "631пст" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436053", FirstName = "Олег", LastName = "Уманцев", MiddleName = "Сергеевич", GroupID = "631пст" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436054", FirstName = "Гриша", LastName = "Христенко", MiddleName = "Генадиевич", GroupID = "631пст" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436055", FirstName = "Сергей", LastName = "Четвернтный", MiddleName = "Олегович", GroupID = "631пст" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436056", FirstName = "Юрий", LastName = "Шевцов", MiddleName = "Александрович", GroupID = "631пст" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436057", FirstName = "Руслан", LastName = "Счастливый", MiddleName = "Витальевич", GroupID = "631пст" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436058", FirstName = "Роман", LastName = "Ющенко", MiddleName = "Семенович", GroupID = "631пст" });
        //    context.Students.Add(new Student() { RecordBookNumberID = "436059", FirstName = "Ярослав", LastName = "Яскевич", MiddleName = "Витальевич", GroupID = "631пст" });

        //}
        protected void SubjectInit(ref TotalJournalContext context)
        {
            //List<Student> students4 = new List<Student>
            //{
            //    new Student() { RecordBookNumberID = "436001", FirstName = "Катерина", LastName = "Андрющенко", MiddleName = "Сергеевна", GroupID = "641п", },
            //    new Student() { RecordBookNumberID = "436002", FirstName = "Денис", LastName = "Билецкий", MiddleName = "Романович", GroupID = "641п" },
            //    new Student() { RecordBookNumberID = "436003", FirstName = "Илья", LastName = "Вирич", MiddleName = "Васильевич", GroupID = "641п" },
            //    new Student() { RecordBookNumberID = "436004", FirstName = "Роман", LastName = "Гайдук", MiddleName = "Валерьевич", GroupID = "641п" },
            //    new Student() { RecordBookNumberID = "436005", FirstName = "Борис", LastName = "Головкин", MiddleName = "Анатольевич", GroupID = "641п" },
            //    new Student() { RecordBookNumberID = "436006", FirstName = "Артур", LastName = "Гулеватый", MiddleName = "Игоревич", GroupID = "641п" },
            //    new Student() { RecordBookNumberID = "436007", FirstName = "Виталий", LastName = "Дворник", MiddleName = "Юрьевич", GroupID = "641п" },
            //    new Student() { RecordBookNumberID = "436008", FirstName = "Михаил", LastName = "Дронов", MiddleName = "Эдуардович", GroupID = "641п" },
            //    new Student() { RecordBookNumberID = "436009", FirstName = "Владислав", LastName = "Колесник", MiddleName = "Юрьевич", GroupID = "641п" },
            //    new Student() { RecordBookNumberID = "436010", FirstName = "Артем", LastName = "Мирошниченко", MiddleName = "Валерьевич", GroupID = "641п" },
            //    new Student() { RecordBookNumberID = "436011", FirstName = "Евгений", LastName = "Могилевский", MiddleName = "Романович", GroupID = "641п" },
            //    new Student() { RecordBookNumberID = "436012", FirstName = "Катерина", LastName = "Плитник", MiddleName = "Витальевна", GroupID = "641п" },
            //    new Student() { RecordBookNumberID = "436013", FirstName = "Вадим", LastName = "Рачков", MiddleName = "Сергеевич", GroupID = "641п" },
            //    new Student() { RecordBookNumberID = "436014", FirstName = "Дмитрий", LastName = "Руденок", MiddleName = "Юрьевич", GroupID = "641п" },
            //    new Student() { RecordBookNumberID = "436015", FirstName = "Оксана", LastName = "Ткаченко", MiddleName = "Витальевна", GroupID = "641п" },
            //    new Student() { RecordBookNumberID = "436016", FirstName = "Артем", LastName = "Чуглазов", MiddleName = "Васильевич", GroupID = "641п" },
            //    new Student() { RecordBookNumberID = "436017", FirstName = "Ростислав", LastName = "Шурухин", MiddleName = "Юрьевич", GroupID = "641п" },
            //    new Student() { RecordBookNumberID = "436018", FirstName = "Александр", LastName = "Яценко", MiddleName = "Сергеевич", GroupID = "641п" },
            //    new Student() { RecordBookNumberID = "436019", FirstName = "Евгений", LastName = "Виноградный", MiddleName = "Олегович", GroupID = "642п" },
            //    new Student() { RecordBookNumberID = "436020", FirstName = "Валерий", LastName = "Глянцев", MiddleName = "Олегович", GroupID = "642п" },
            //    new Student() { RecordBookNumberID = "436021", FirstName = "Диана", LastName = "Грушко", MiddleName = "Александровна", GroupID = "642п" },

            //    new Student() { RecordBookNumberID = "436022", FirstName = "Анна", LastName = "Дорошенко", MiddleName = "Сергеевна", GroupID = "642п" },
            //    new Student() { RecordBookNumberID = "436023", FirstName = "Александр", LastName = "Жуган", MiddleName = "Александрович", GroupID = "642п" },
            //    new Student() { RecordBookNumberID = "436024", FirstName = "Александр", LastName = "Ильченко", MiddleName = "Анатольевич", GroupID = "642п" },
            //    new Student() { RecordBookNumberID = "436025", FirstName = "Сергей", LastName = "Клименко", MiddleName = "Юрьевич", GroupID = "642п" },
            //    new Student() { RecordBookNumberID = "436026", FirstName = "Юрий", LastName = "Кудринский", MiddleName = "Михайлович", GroupID = "642п" },
            //    new Student() { RecordBookNumberID = "436027", FirstName = "Александр", LastName = "Кушнарев", MiddleName = "Александрович", GroupID = "642п" },
            //    new Student() { RecordBookNumberID = "436028", FirstName = "Владислав", LastName = "Мокеев", MiddleName = "Олегович", GroupID = "642п" },
            //    new Student() { RecordBookNumberID = "436029", FirstName = "Полина", LastName = "Надеева", MiddleName = "Егоровна", GroupID = "642п" },
            //    new Student() { RecordBookNumberID = "436030", FirstName = "Владислав", LastName = "Овчаренко", MiddleName = "Витальевич", GroupID = "642п" },
            //    new Student() { RecordBookNumberID = "436031", FirstName = "Денис", LastName = "Пилипенко", MiddleName = "Петрович", GroupID = "642п" },
            //    new Student() { RecordBookNumberID = "436032", FirstName = "Владислав", LastName = "Рогинский", MiddleName = "Михайлович", GroupID = "642п" },

            //    new Student() { RecordBookNumberID = "436033", FirstName = "Ярослав", LastName = "Рягузов", MiddleName = "Алексеевич", GroupID = "642п" },
            //    new Student() { RecordBookNumberID = "436034", FirstName = "Александр", LastName = "Силин", MiddleName = "Олегович", GroupID = "642п" },
            //    new Student() { RecordBookNumberID = "436035", FirstName = "Руслан", LastName = "Тибилашвли", MiddleName = "Викторович", GroupID = "642п" },
            //    new Student() { RecordBookNumberID = "436036", FirstName = "Андрей", LastName = "Турянский", MiddleName = "Олегович", GroupID = "642п" },
            //    new Student() { RecordBookNumberID = "436037", FirstName = "Богдан", LastName = "Хон", MiddleName = "Игоревич", GroupID = "642п" },
            //    new Student() { RecordBookNumberID = "436038", FirstName = "Анастасия", LastName = "Чередник", MiddleName = "Юрьевна", GroupID = "642п" },
             
            //    new Student() { RecordBookNumberID = "436039", FirstName = "Олег", LastName = "Бордаков", MiddleName = "Васильевич", GroupID = "631пст" },
            //    new Student() { RecordBookNumberID = "436040", FirstName = "Александр", LastName = "Глущенко", MiddleName = "Эдуардович", GroupID = "631пст" },
            //    new Student() { RecordBookNumberID = "436041", FirstName = "Александр", LastName = "Драшпуль", MiddleName = "Юрьевич", GroupID = "631пст" },
            //    new Student() { RecordBookNumberID = "436042", FirstName = "Анастасия", LastName = "Дучкина", MiddleName = "Михайловна", GroupID = "631пст" },
            //    new Student() { RecordBookNumberID = "436043", FirstName = "Виталий", LastName = "Комаровский", MiddleName = "Константинович", GroupID = "631пст" },
            //    new Student() { RecordBookNumberID = "436044", FirstName = "Ирина", LastName = "Крайнюкова", MiddleName = "Сергеевна", GroupID = "631пст" },
            //    new Student() { RecordBookNumberID = "436045", FirstName = "Дмитрий", LastName = "Курдюков", MiddleName = "Семенович", GroupID = "631пст" },
            //    new Student() { RecordBookNumberID = "436046", FirstName = "Евгения", LastName = "Ламтюгова", MiddleName = " Ильинична", GroupID = "631пст", },
            //    new Student() { RecordBookNumberID = "436047", FirstName = "Илья", LastName = "Олешко", MiddleName = "Сергеевич", GroupID = "631пст" },
            //    new Student() { RecordBookNumberID = "436048", FirstName = "Евгений", LastName = "Погорельцев", MiddleName = "Семенович", GroupID = "631пст" },
            //    new Student() { RecordBookNumberID = "436049", FirstName = "Александр", LastName = "Савинков", MiddleName = "Максимович", GroupID = "631пст" },
            //    new Student() { RecordBookNumberID = "436050", FirstName = "Александр", LastName = "Сирота", MiddleName = "Юрьевич", GroupID = "631пст" },
            //    new Student() { RecordBookNumberID = "436051", FirstName = "Ксения", LastName = "Сич", MiddleName = "Сергеевна", GroupID = "631пст" },
            //    new Student() { RecordBookNumberID = "436052", FirstName = "Андрей", LastName = "Телешев", MiddleName = "Александрович", GroupID = "631пст" },
            //    new Student() { RecordBookNumberID = "436053", FirstName = "Олег", LastName = "Уманцев", MiddleName = "Сергеевич", GroupID = "631пст" },
            //    new Student() { RecordBookNumberID = "436054", FirstName = "Гриша", LastName = "Христенко", MiddleName = "Генадиевич", GroupID = "631пст" },
            //    new Student() { RecordBookNumberID = "436055", FirstName = "Сергей", LastName = "Четвернтный", MiddleName = "Олегович", GroupID = "631пст" },
            //    new Student() { RecordBookNumberID = "436056", FirstName = "Юрий", LastName = "Шевцов", MiddleName = "Александрович", GroupID = "631пст" },
            //    new Student() { RecordBookNumberID = "436057", FirstName = "Руслан", LastName = "Счастливый", MiddleName = "Витальевич", GroupID = "631пст" },
            //    new Student() { RecordBookNumberID = "436058", FirstName = "Роман", LastName = "Ющенко", MiddleName = "Семенович", GroupID = "631пст" },
            //    new Student() { RecordBookNumberID = "436059", FirstName = "Ярослав", LastName = "Яскевич", MiddleName = "Витальевич", GroupID = "631пст" }
            //};
            //students4.ForEach(s => context.Students.Add(s));
            
            //List<Subject> subjects = new List<Subject>
            //{
            //    new Subject() { SubjectID = 1, SubjectName = "Основы программирования", SubjectType = SubjectType.Exam, Term = 1, TeacherID=8, Students = students4 }, 
            //    new Subject() { SubjectID = 2, SubjectName = "Основы программной инженерии", SubjectType = SubjectType.Exam, Term = 1, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 3, SubjectName = "Компьтерная дискретная математика", SubjectType = SubjectType.Exam, Term = 2, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 4, SubjectName = "Основы программирования", SubjectType = SubjectType.Exam, Term = 2, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 5, SubjectName = "Групповая динамика и коммуникации", SubjectType = SubjectType.Credit, Term = 2, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 6, SubjectName = "Дискретные структуры", SubjectType = SubjectType.Exam, Term = 3, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 7, SubjectName = "Человеко-машинное взаимодействие", SubjectType = SubjectType.Exam, Term = 3, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 8, SubjectName = "Объектно-ориентированное программирование", SubjectType = SubjectType.Exam, Term = 3, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 9, SubjectName = "Теория вероятности и математическая статистика", SubjectType = SubjectType.Exam, Term = 3, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 10, SubjectName = "Профессиональная практика программной инженерии", SubjectType = SubjectType.Credit, Term = 3, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 11, SubjectName = "Алгоритмы и структуры данных", SubjectType = SubjectType.Exam, Term = 4, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 12, SubjectName = "Архитектура ЭОМ", SubjectType = SubjectType.Exam, Term = 4, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 13, SubjectName = "Эмперические методы программной инженерии", SubjectType = SubjectType.Exam, Term = 4, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 14, SubjectName = "Конструирование программного обеспечения", SubjectType = SubjectType.Exam, Term = 4, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 15, SubjectName = "Организация компьтерных сетей", SubjectType = SubjectType.Exam, Term = 4, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 16, SubjectName = "Объектно-ориентированное программирование", SubjectType = SubjectType.Credit, Term = 4, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 17, SubjectName = "Инженерная и компьютерная графика", SubjectType = SubjectType.Exam, Term = 5, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 18, SubjectName = "Анализ требований к программному обеспечению", SubjectType = SubjectType.Exam, Term = 5, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 19, SubjectName = "Операционные системы", SubjectType = SubjectType.Exam, Term = 5, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 20, SubjectName = "Качество ПО и тестирование", SubjectType = SubjectType.Exam, Term = 5, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 21, SubjectName = "Английский язык", SubjectType = SubjectType.Credit, Term = 5, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 22, SubjectName = "Архитектура и проектирование ПО", SubjectType = SubjectType.Exam, Term = 6, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 23, SubjectName = "Базы данных", SubjectType = SubjectType.Exam, Term = 6, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 24, SubjectName = "Методы оптимизации и исследования операций", SubjectType = SubjectType.Exam, Term = 6, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 25, SubjectName = "Программирование интернет", SubjectType = SubjectType.Exam, Term = 6, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 26, SubjectName = "Системы искусственного интелекта", SubjectType = SubjectType.Exam, Term = 6, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 27, SubjectName = "Android", SubjectType = SubjectType.Credit, Term = 6, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 28, SubjectName = "Информационные технологии разработки ПО", SubjectType = SubjectType.Exam, Term = 7, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 29, SubjectName = "Безопасность программ и данных", SubjectType = SubjectType.Exam, Term = 7, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 30, SubjectName = "Проектирование распределенных систем ЭОМ", SubjectType = SubjectType.Exam, Term = 7, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 31, SubjectName = "Проектный практикум", SubjectType = SubjectType.Credit, Term = 7, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 32, SubjectName = "Менеджмент проектов ПО", SubjectType = SubjectType.Exam, Term = 8, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 33, SubjectName = "Проектирование производственных экспертных систем", SubjectType = SubjectType.Exam, Term = 8, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 34, SubjectName = "Международные стандарты программной инженерии", SubjectType = SubjectType.Exam, Term = 8, TeacherID = 8, Students = students4 },
            //    new Subject() { SubjectID = 35, SubjectName = "Проектный практикум", SubjectType = SubjectType.Credit, Term = 8, TeacherID = 8, Students = students4 }
            //};

           
            //context.Students.AddRange(students4);
            //context.Subjects.AddRange(subjects);
        }
        protected void TeacherInit(ref TotalJournalContext context)
        {
            ////                                  TeachersID++    
            context.Teachers.Add(new Teacher() { TeacherID = 1, FirstName = "Павел", MiddleName = "Александрович", LastName = "Лучшев", AcadDegree = " к.т.н.,доцент" });
            context.Teachers.Add(new Teacher() { TeacherID = 2, FirstName = "Мария", MiddleName = "Александровна", LastName = "Данова", AcadDegree = "к.т.н.,доцент" });
            context.Teachers.Add(new Teacher() { TeacherID = 3, FirstName = "Оксана", MiddleName = "Вадимовна", LastName = "Лучшева", AcadDegree = "ст. преп." });
            context.Teachers.Add(new Teacher() { TeacherID = 4, FirstName = "Юрий", MiddleName = "Семенович", LastName = "Манжос", AcadDegree = "к.т.н.,доцент" });
            context.Teachers.Add(new Teacher() { TeacherID = 5, FirstName = "Людмила", MiddleName = "Васильевна", LastName = "Мандрикова", AcadDegree = "к.т.н.,доцент" });
            context.Teachers.Add(new Teacher() { TeacherID = 6, FirstName = "Николай", MiddleName = "Григорьевич", LastName = "Мокляк", AcadDegree = "к.т.н.,доцент" });
            context.Teachers.Add(new Teacher() { TeacherID = 7, FirstName = "Вероника", MiddleName = "Альбертовна", LastName = "Постернакова", AcadDegree = "ст. преп." });
            context.Teachers.Add(new Teacher() { TeacherID = 8, FirstName = "Лариса", MiddleName = "Федоровна", LastName = "Пудовкина", AcadDegree = "к.т.н.,доцент" });
            context.Teachers.Add(new Teacher() { TeacherID = 9, FirstName = "Александр", MiddleName = "Александрович", LastName = "Резуненко", AcadDegree = " ст. преп." });
            context.Teachers.Add(new Teacher() { TeacherID = 10, FirstName = "Сергей", MiddleName = "Владимирович", LastName = "Россоха", AcadDegree = "к.т.н.,ст. преп." });
            context.Teachers.Add(new Teacher() { TeacherID = 11, FirstName = "Евгения", MiddleName = "Витальевна", LastName = "Соколова", AcadDegree = "к.т.н.,доцент" });
            context.Teachers.Add(new Teacher() { TeacherID = 12, FirstName = "Илона", MiddleName = "Владимировна", LastName = "Шевченко", AcadDegree = "к.т.н.,доцент" });
            context.Teachers.Add(new Teacher() { TeacherID = 13, FirstName = "Юлия", MiddleName = "Анатольевна", LastName = "Кузнецова", AcadDegree = "к.т.н.,доцент" });
            context.Teachers.Add(new Teacher() { TeacherID = 14, FirstName = "Елена", MiddleName = "Георгиевна", LastName = "Кириленко", AcadDegree = "к.пед.н.,доцент" });
            context.Teachers.Add(new Teacher() { TeacherID = 15, FirstName = "Владислав", MiddleName = "Анатольевич", LastName = "Демьяненко", AcadDegree = "ст. преп." });
            context.Teachers.Add(new Teacher() { TeacherID = 16, FirstName = "Татьяна", MiddleName = "Григорьевна", LastName = "Дегтярева", AcadDegree = "ст. преп." });
            context.Teachers.Add(new Teacher() { TeacherID = 17, FirstName = "Надежда", MiddleName = "Григорьевна", LastName = "Голубь", AcadDegree = "к.т.н.,доцент" });
            context.Teachers.Add(new Teacher() { TeacherID = 18, FirstName = "Олег", MiddleName = "Николаевич", LastName = "Волошин", AcadDegree = "ст. преп." });
            context.Teachers.Add(new Teacher() { TeacherID = 19, FirstName = "Лина", MiddleName = "Алексеевна", LastName = "Волобуева", AcadDegree = "к.т.н.,доцент" });
            context.Teachers.Add(new Teacher() { TeacherID = 20, FirstName = "Игорь", MiddleName = "Владимирович", LastName = "Шостак", AcadDegree = "д.т.н.,профессор" });
            context.Teachers.Add(new Teacher() { TeacherID = 21, FirstName = "Игорь", MiddleName = "Борисович", LastName = "Туркин", AcadDegree = "д.т.н.,профессор" });
            context.Teachers.Add(new Teacher() { TeacherID = 22, FirstName = "Борис", MiddleName = "Михайлович", LastName = "Конорев", AcadDegree = "д.т.н.,профессор" });

        }
        protected void MarkInit(ref TotalJournalContext context)
        {
            //// оценки
            context.Marks.Add(new Mark() { MarkID = 1, LabNumber = 1, RecordBookNumberID = "436001",  TheMark = 5, SubjectID = 35, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date,  });
            context.Marks.Add(new Mark() { MarkID = 2, LabNumber = 2, RecordBookNumberID = "436001",  TheMark = 4, SubjectID = 35, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 3, LabNumber = 3, RecordBookNumberID = "436001",  TheMark = 3, SubjectID = 35, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
                                                                                                      
            context.Marks.Add(new Mark() { MarkID = 4, LabNumber = 1, RecordBookNumberID = "436001",  TheMark = 1, SubjectID = 32, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 5, LabNumber = 2, RecordBookNumberID = "436001",  TheMark = 1, SubjectID = 32, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 6, LabNumber = 3, RecordBookNumberID = "436001",  TheMark = 1, SubjectID = 32, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
                                                                                                      
            context.Marks.Add(new Mark() { MarkID = 7, LabNumber = 1, RecordBookNumberID = "436001",  TheMark = 5, SubjectID = 34, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date,  });
            context.Marks.Add(new Mark() { MarkID = 8, LabNumber = 2, RecordBookNumberID = "436001",  TheMark = 5, SubjectID = 34, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date,  });
            context.Marks.Add(new Mark() { MarkID = 9, LabNumber = 3, RecordBookNumberID = "436001",  TheMark = 5, SubjectID = 34, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date,  });
                                                                                                      
            context.Marks.Add(new Mark() { MarkID = 10, LabNumber = 1, RecordBookNumberID = "436001", TheMark = 4, SubjectID = 33, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 11, LabNumber = 2, RecordBookNumberID = "436001", TheMark = 4, SubjectID = 33, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 12, LabNumber = 3, RecordBookNumberID = "436001", TheMark = 4, SubjectID = 33, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
                                                                                                      
                                                                                                      
                                                                                                      
                                                                                                      
            context.Marks.Add(new Mark() { MarkID = 13, LabNumber = 1, RecordBookNumberID = "436002", TheMark = 5, SubjectID = 35, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 14, LabNumber = 2, RecordBookNumberID = "436002", TheMark = 5, SubjectID = 35, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 15, LabNumber = 3, RecordBookNumberID = "436002", TheMark = 5, SubjectID = 35, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
                                                                                                      
            context.Marks.Add(new Mark() { MarkID = 16, LabNumber = 1, RecordBookNumberID = "436002", TheMark = 4, SubjectID = 32, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 17, LabNumber = 2, RecordBookNumberID = "436002", TheMark = 4, SubjectID = 32, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 18, LabNumber = 3, RecordBookNumberID = "436002", TheMark = 4, SubjectID = 32, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
                                                                                                      
            context.Marks.Add(new Mark() { MarkID = 19, LabNumber = 1, RecordBookNumberID = "436002", TheMark = 3, SubjectID = 34, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date,  });
            context.Marks.Add(new Mark() { MarkID = 20, LabNumber = 2, RecordBookNumberID = "436002", TheMark = 5, SubjectID = 34, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date,  });
            context.Marks.Add(new Mark() { MarkID = 21, LabNumber = 3, RecordBookNumberID = "436002", TheMark = 4, SubjectID = 34, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date,  });
                                                                                                      
            context.Marks.Add(new Mark() { MarkID = 22, LabNumber = 1, RecordBookNumberID = "436002", TheMark = 4, SubjectID = 33, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 23, LabNumber = 2, RecordBookNumberID = "436002", TheMark = 5, SubjectID = 33, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 24, LabNumber = 3, RecordBookNumberID = "436002", TheMark = 4, SubjectID = 33, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
                                                                                                      
                                                                                                      
                                                                                                      
                                                                                                      
            context.Marks.Add(new Mark() { MarkID = 25, LabNumber = 1, RecordBookNumberID = "436003", TheMark = 4, SubjectID = 35, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 26, LabNumber = 2, RecordBookNumberID = "436003", TheMark = 4, SubjectID = 35, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 27, LabNumber = 3, RecordBookNumberID = "436003", TheMark = 4, SubjectID = 35, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
                                                                                                      
            context.Marks.Add(new Mark() { MarkID = 28, LabNumber = 1, RecordBookNumberID = "436003", TheMark = 5, SubjectID = 32, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 29, LabNumber = 2, RecordBookNumberID = "436003", TheMark = 3, SubjectID = 32, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 30, LabNumber = 3, RecordBookNumberID = "436003", TheMark = 5, SubjectID = 32, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
                                                                                                      
            context.Marks.Add(new Mark() { MarkID = 31, LabNumber = 1, RecordBookNumberID = "436003", TheMark = 4, SubjectID = 34, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date,  });
            context.Marks.Add(new Mark() { MarkID = 32, LabNumber = 2, RecordBookNumberID = "436003", TheMark = 5, SubjectID = 34, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date,  });
            context.Marks.Add(new Mark() { MarkID = 33, LabNumber = 3, RecordBookNumberID = "436003", TheMark = 5, SubjectID = 34, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date,  });
                                                                                                      
            context.Marks.Add(new Mark() { MarkID = 34, LabNumber = 1, RecordBookNumberID = "436003", TheMark = 5, SubjectID = 33, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 35, LabNumber = 2, RecordBookNumberID = "436003", TheMark = 4, SubjectID = 33, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
            context.Marks.Add(new Mark() { MarkID = 36, LabNumber = 3, RecordBookNumberID = "436003", TheMark = 3, SubjectID = 33, DateOfProgram = DateTime.Now.Date, DateOfReport = DateTime.Now.Date, });
        }
        protected void AttendanceInit(ref TotalJournalContext context)
        {
            //context.Attendances.Add(new Attendance() {AttendanceID=1, RecordBookNumberID ="436001", SubjectID = 35, ClassDate= DateTime.Now.Date, IsVisited = true });
            //context.Attendances.Add(new Attendance() { AttendanceID = 2, RecordBookNumberID = "436001", SubjectID = 35, ClassDate = DateTime.Now.Date, IsVisited = false });
            //context.Attendances.Add(new Attendance() { AttendanceID = 3, RecordBookNumberID = "436001", SubjectID = 35, ClassDate = DateTime.Now.Date, IsVisited = true });

            //context.Attendances.Add(new Attendance() { AttendanceID = 4, RecordBookNumberID = "436001", SubjectID = 32, ClassDate = DateTime.Now.Date, IsVisited = false });
            //context.Attendances.Add(new Attendance() { AttendanceID = 5, RecordBookNumberID = "436001", SubjectID = 32, ClassDate = DateTime.Now.Date, IsVisited = true });
            //context.Attendances.Add(new Attendance() { AttendanceID = 6, RecordBookNumberID = "436001", SubjectID = 32, ClassDate = DateTime.Now.Date, IsVisited = true });

            //context.Attendances.Add(new Attendance() { AttendanceID = 7, RecordBookNumberID = "436001", SubjectID = 34, ClassDate = DateTime.Now.Date, IsVisited = true });
            //context.Attendances.Add(new Attendance() { AttendanceID = 8, RecordBookNumberID = "436001", SubjectID = 34, ClassDate = DateTime.Now.Date, IsVisited = true });
            //context.Attendances.Add(new Attendance() { AttendanceID = 9, RecordBookNumberID = "436001", SubjectID = 34, ClassDate = DateTime.Now.Date, IsVisited = false });

            //context.Attendances.Add(new Attendance() { AttendanceID = 10, RecordBookNumberID = "436001", SubjectID = 33, ClassDate = DateTime.Now.Date, IsVisited = false });
            //context.Attendances.Add(new Attendance() { AttendanceID = 11, RecordBookNumberID = "436001", SubjectID = 33, ClassDate = DateTime.Now.Date, IsVisited = false });
            //context.Attendances.Add(new Attendance() { AttendanceID = 12, RecordBookNumberID = "436001", SubjectID = 33, ClassDate = DateTime.Now.Date, IsVisited = true });



            //context.Attendances.Add(new Attendance() { AttendanceID = 13, RecordBookNumberID = "436002", SubjectID = 35, ClassDate = DateTime.Now.Date, IsVisited = true });
            //context.Attendances.Add(new Attendance() { AttendanceID = 14, RecordBookNumberID = "436002", SubjectID = 35, ClassDate = DateTime.Now.Date, IsVisited = false });
            //context.Attendances.Add(new Attendance() { AttendanceID = 15, RecordBookNumberID = "436002", SubjectID = 35, ClassDate = DateTime.Now.Date, IsVisited = false });

            //context.Attendances.Add(new Attendance() { AttendanceID = 16, RecordBookNumberID = "436002", SubjectID = 32, ClassDate = DateTime.Now.Date, IsVisited = true });
            //context.Attendances.Add(new Attendance() { AttendanceID = 17, RecordBookNumberID = "436002", SubjectID = 32, ClassDate = DateTime.Now.Date, IsVisited = true });
            //context.Attendances.Add(new Attendance() { AttendanceID = 18, RecordBookNumberID = "436002", SubjectID = 32, ClassDate = DateTime.Now.Date, IsVisited = true });

            //context.Attendances.Add(new Attendance() { AttendanceID = 19, RecordBookNumberID = "436002", SubjectID = 34, ClassDate = DateTime.Now.Date, IsVisited = false });
            //context.Attendances.Add(new Attendance() { AttendanceID = 20, RecordBookNumberID = "436002", SubjectID = 34, ClassDate = DateTime.Now.Date, IsVisited = true });
            //context.Attendances.Add(new Attendance() { AttendanceID = 21, RecordBookNumberID = "436002", SubjectID = 34, ClassDate = DateTime.Now.Date, IsVisited = false });

            //context.Attendances.Add(new Attendance() { AttendanceID = 22, RecordBookNumberID = "436002", SubjectID = 33, ClassDate = DateTime.Now.Date, IsVisited = false });
            //context.Attendances.Add(new Attendance() { AttendanceID = 23, RecordBookNumberID = "436002", SubjectID = 33, ClassDate = DateTime.Now.Date, IsVisited = false });
            //context.Attendances.Add(new Attendance() { AttendanceID = 24, RecordBookNumberID = "436002", SubjectID = 33, ClassDate = DateTime.Now.Date, IsVisited = true });



            //context.Attendances.Add(new Attendance() { AttendanceID = 25, RecordBookNumberID = "436003", SubjectID = 35, ClassDate = DateTime.Now.Date, IsVisited = false });
            //context.Attendances.Add(new Attendance() { AttendanceID = 26, RecordBookNumberID = "436003", SubjectID = 35, ClassDate = DateTime.Now.Date, IsVisited = false });
            //context.Attendances.Add(new Attendance() { AttendanceID = 27, RecordBookNumberID = "436003", SubjectID = 35, ClassDate = DateTime.Now.Date, IsVisited = true });

            //context.Attendances.Add(new Attendance() { AttendanceID = 28, RecordBookNumberID = "436003", SubjectID = 32, ClassDate = DateTime.Now.Date, IsVisited = true });
            //context.Attendances.Add(new Attendance() { AttendanceID = 29, RecordBookNumberID = "436003", SubjectID = 32, ClassDate = DateTime.Now.Date, IsVisited = true });
            //context.Attendances.Add(new Attendance() { AttendanceID = 30, RecordBookNumberID = "436003", SubjectID = 32, ClassDate = DateTime.Now.Date, IsVisited = false });

            //context.Attendances.Add(new Attendance() { AttendanceID = 31, RecordBookNumberID = "436003", SubjectID = 34, ClassDate = DateTime.Now.Date, IsVisited = true });
            //context.Attendances.Add(new Attendance() { AttendanceID = 32, RecordBookNumberID = "436003", SubjectID = 34, ClassDate = DateTime.Now.Date, IsVisited = false });
            //context.Attendances.Add(new Attendance() { AttendanceID = 33, RecordBookNumberID = "436003", SubjectID = 34, ClassDate = DateTime.Now.Date, IsVisited = false });

            //context.Attendances.Add(new Attendance() { AttendanceID = 34, RecordBookNumberID = "436003", SubjectID = 33, ClassDate = DateTime.Now.Date, IsVisited = true });
            //context.Attendances.Add(new Attendance() { AttendanceID = 35, RecordBookNumberID = "436003", SubjectID = 33, ClassDate = DateTime.Now.Date, IsVisited = false });
            //context.Attendances.Add(new Attendance() { AttendanceID = 36, RecordBookNumberID = "436003", SubjectID = 33, ClassDate = DateTime.Now.Date, IsVisited = true });
        
        }
        protected void ModuleInit(ref TotalJournalContext context)
        {
            context.Modules.Add(new Module() { ModuleID=1, SubjectID=35,      RecordBookNumberID= "436001", ModulePoint = 10, ModuleNumber=1,         });
            context.Modules.Add(new Module() { ModuleID = 2, SubjectID = 32,  RecordBookNumberID = "436001", ModulePoint = 8, ModuleNumber = 1});
            context.Modules.Add(new Module() { ModuleID = 3, SubjectID = 34,  RecordBookNumberID = "436001", ModulePoint = 9, ModuleNumber = 1 });
            context.Modules.Add(new Module() { ModuleID = 4, SubjectID = 33,  RecordBookNumberID = "436001", ModulePoint = 9, ModuleNumber = 1});

            context.Modules.Add(new Module() { ModuleID = 5, SubjectID = 35,  RecordBookNumberID = "436002", ModulePoint = 7, ModuleNumber = 1});
            context.Modules.Add(new Module() { ModuleID = 6, SubjectID = 32,  RecordBookNumberID = "436002", ModulePoint = 8, ModuleNumber = 1});
            context.Modules.Add(new Module() { ModuleID = 7, SubjectID = 34,  RecordBookNumberID = "436002", ModulePoint = 9, ModuleNumber = 1 });
            context.Modules.Add(new Module() { ModuleID = 8, SubjectID = 34,  RecordBookNumberID = "436002", ModulePoint = 10, ModuleNumber = 1 });

            context.Modules.Add(new Module() { ModuleID = 9, SubjectID = 35,  RecordBookNumberID = "436003", ModulePoint = 10, ModuleNumber = 1 });
            context.Modules.Add(new Module() { ModuleID = 10, SubjectID = 32, RecordBookNumberID = "436003", ModulePoint = 8, ModuleNumber = 1 });
            context.Modules.Add(new Module() { ModuleID = 11, SubjectID = 34, RecordBookNumberID = "436003", ModulePoint = 10, ModuleNumber = 1 });
            context.Modules.Add(new Module() { ModuleID = 12, SubjectID = 34, RecordBookNumberID = "436003", ModulePoint = 9, ModuleNumber = 1});
        }
        protected void SubjectCPInit(ref TotalJournalContext context)
        {
            context.SubjectCPs.Add(new SubjectCP() { SubjectCP_ID = 1, SubjectCPName = "Основы программирования(КП)", Term = 3, TeacherID = 1, });
            context.SubjectCPs.Add(new SubjectCP() { SubjectCP_ID = 2, SubjectCPName = "Объектно-ориентированное программирование(КП)", Term = 4, TeacherID = 1 });
            context.SubjectCPs.Add(new SubjectCP() { SubjectCP_ID = 3, SubjectCPName = "Алгоритмы и структуры данных(КП)", Term = 5, TeacherID = 1 });
            context.SubjectCPs.Add(new SubjectCP() { SubjectCP_ID = 4, SubjectCPName = "Операционные системы(КП)", Term = 6, TeacherID = 1 });
            context.SubjectCPs.Add(new SubjectCP() { SubjectCP_ID = 5, SubjectCPName = "Базы данных(КП)", Term = 7, TeacherID = 1 });
            context.SubjectCPs.Add(new SubjectCP() { SubjectCP_ID = 6, SubjectCPName = "Проектирование распределенных систем ЭВМ(КП)", Term = 8, TeacherID = 1 });
        }
        protected void CourseProjectLineInit(ref TotalJournalContext context)
        {
            context.CourseProjectLines.Add(new CourseProjectLine() { CourseProjectLineID=1,  RecordBookNumberID = "436001", SubjectCP_ID = 6, LineName = "Постановка задачи", TheMark = 5,  DateOfPassing=DateTime.Now, LineIndex=1 });
            context.CourseProjectLines.Add(new CourseProjectLine() { CourseProjectLineID = 2, RecordBookNumberID = "436002", SubjectCP_ID = 6, LineName = "Постановка задачи", TheMark = 4,  DateOfPassing = DateTime.Now, LineIndex = 1 });

            context.CourseProjectLines.Add(new CourseProjectLine() { CourseProjectLineID = 3, RecordBookNumberID = "436003", SubjectCP_ID = 6, LineName = "Постановка задачи", TheMark = 4,  DateOfPassing = DateTime.Now, LineIndex = 1 });
            context.CourseProjectLines.Add(new CourseProjectLine() { CourseProjectLineID = 4, RecordBookNumberID = "436004", SubjectCP_ID = 6, LineName = "Постановка задачи", TheMark = 5,  DateOfPassing = DateTime.Now, LineIndex = 1 });

            context.CourseProjectLines.Add(new CourseProjectLine() { CourseProjectLineID = 5, RecordBookNumberID = "436005", SubjectCP_ID = 6, LineName = "Постановка задачи", TheMark = 5,  DateOfPassing = DateTime.Now, LineIndex = 1 });
            context.CourseProjectLines.Add(new CourseProjectLine() { CourseProjectLineID = 6, RecordBookNumberID = "436006", SubjectCP_ID = 6, LineName = "Постановка задачи", TheMark = 5,  DateOfPassing = DateTime.Now, LineIndex = 1 });
        }
        protected void HomeWorkInit(ref TotalJournalContext context)
        {
            context.HomeWorks.Add(new HomeWork() {HomeWorkID=1 , RecordBookNumberID= "436001", HWNumber= 1, HWPoint = 11, SubjectID= 35,       DateOfProgram=DateTime.Now, DateOfReport=DateTime.Now});
            context.HomeWorks.Add(new HomeWork() { HomeWorkID = 2, RecordBookNumberID = "436001", HWNumber = 1, HWPoint = 12, SubjectID = 32,  DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now });
            context.HomeWorks.Add(new HomeWork() { HomeWorkID = 3, RecordBookNumberID = "436001", HWNumber = 1, HWPoint = 10, SubjectID = 34,  DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now });
            context.HomeWorks.Add(new HomeWork() { HomeWorkID = 4, RecordBookNumberID = "436001", HWNumber = 1, HWPoint = 8, SubjectID = 33,   DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now });

            context.HomeWorks.Add(new HomeWork() { HomeWorkID = 5, RecordBookNumberID = "436002", HWNumber = 1, HWPoint = 10, SubjectID = 35,  DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now });
            context.HomeWorks.Add(new HomeWork() { HomeWorkID = 6, RecordBookNumberID = "436002", HWNumber = 1, HWPoint = 10, SubjectID = 32,  DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now });
            context.HomeWorks.Add(new HomeWork() { HomeWorkID = 7, RecordBookNumberID = "436002", HWNumber = 1, HWPoint = 9, SubjectID = 34,   DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now });
            context.HomeWorks.Add(new HomeWork() { HomeWorkID = 8, RecordBookNumberID = "436002", HWNumber = 1, HWPoint = 8, SubjectID = 33,   DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now });

            context.HomeWorks.Add(new HomeWork() { HomeWorkID = 9, RecordBookNumberID = "436003", HWNumber = 1, HWPoint = 7, SubjectID = 35,   DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now });
            context.HomeWorks.Add(new HomeWork() { HomeWorkID = 10, RecordBookNumberID = "436003", HWNumber = 1, HWPoint = 11, SubjectID = 32, DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now });
            context.HomeWorks.Add(new HomeWork() { HomeWorkID = 11, RecordBookNumberID = "436003", HWNumber = 1, HWPoint = 10, SubjectID = 34, DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now });
            context.HomeWorks.Add(new HomeWork() { HomeWorkID = 12, RecordBookNumberID = "436003", HWNumber = 1, HWPoint = 9, SubjectID = 33,  DateOfProgram = DateTime.Now, DateOfReport = DateTime.Now });
        }
    }
}
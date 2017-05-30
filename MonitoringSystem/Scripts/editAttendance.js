(function () {
    //функция-констурктор с информацией о посещении студентаа
    Attendance = function (AttendanceID, RecordBookNumberID, SubjectID, ClassDate, IsVisited, Index) {
        this.AttendanceID = AttendanceID;
        this.RecordBookNumberID = RecordBookNumberID;
        this.SubjectID = SubjectID;
        this.ClassDate = ClassDate;
        this.IsVisited = IsVisited;
        this.Index = Index;
    },
    //фукнция-конструктор с информацией о дате посещения для предмета
    AttendanceDate = function (AttendanceDateId, Date, Index, SubjectId) {
        this.AttendanceDateId = AttendanceDateId;
        this.Date = Date;
        this.Index = Index;
        this.SubjectId = SubjectId;
    }
    // расчет информации об успкваемости при инициализации таблицы
    calcualteTotalAttendancePoint = function (oneItemPoint) {
        var currentStudent = $(this).closest("tr");
        var outputParagraph = $("tbody.tablecontent>tr#" + currentStudent[0].id + " p.total-point");
        var rowLength = currentStudent.children().length;
        var oneItemPointValue = parseFloat(oneItemPoint[0].innerHTML.substr(oneItemPoint[0].innerText.lastIndexOf(" ") + 1));
        var sum = 0;
        for (var i = 1; i < rowLength - 1; i++) {
            var studentsCheckbox = $("tbody.tablecontent>tr#" + currentStudent[0].id + ">td>input#" + currentStudent[0].id + "-" + i);
            if (studentsCheckbox.is(":checked")) {
                sum += oneItemPointValue;
            }
        }
        sum = sum.toFixed(2);
        outputParagraph.empty().append(sum);
    }
    // перерасчет информацие при внесении данных в таблицу
    //in: массив номеров зачеток
    //   балл за одно посещение
    recalculateTotalAttendancePoint = function (recordBookNumbersList, oneItemPoint) {
        for (var i = 0; i < recordBookNumbersList.length; i++) {
            var outputParagraph = $("tbody.tablecontent>tr#" + recordBookNumbersList[i] + " p.total-point");
            var rowLength = $("tbody.tablecontent>tr#" + recordBookNumbersList[i]).children().length;
            var oneItemPointValue = parseFloat(oneItemPoint[0].innerHTML.substr(oneItemPoint[0].innerText.lastIndexOf(" ") + 1));
            var sum = 0;
            for (var j = 1; j < rowLength - 1; j++) {
                var studentsCheckbox = $("tbody.tablecontent>tr#" + recordBookNumbersList[i] + ">td>input#" + recordBookNumbersList[i] + "-" + j);
                if (studentsCheckbox.is(":checked")) {
                    sum += oneItemPointValue;
                }
            }
            sum = sum.toFixed(2);
            outputParagraph.empty().append(sum);
        }
    }
})();
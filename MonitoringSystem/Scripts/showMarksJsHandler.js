//(function () {
//    var tablecontent = $("tbody.tablecontent").children();
//    var arrayOfInputData = []; //массив объектов, который хранит информацию о каждом инпуте, который должен подвергаться редактированию
//    var recordBookNumbersList = getRecordBookNumbers(); // массив из id студентов группы
//    var maxMarksSum = getMaxMarkSum();
//    handleDataFromCells();
//    for (var i = 0; i < arrayOfInputData.length; i++) {
//        var currentInput;
//        if (arrayOfInputData[i].rbn === "") {
//            currentInput = $("thead>tr.maxpoints>th." + arrayOfInputData[i].markType + ">input#" + arrayOfInputData[i].inputId);
//            currentInput.bind("change", recalculateMaxMarkSumWithStudentsAutomats);
//        }
//        else {
//            currentInput = $("tbody.tablecontent>tr#" + arrayOfInputData[i].rbn + ">td>div>input#" + arrayOfInputData[i].inputId);
//            currentInput.bind("change", recalculateMaxMarkSumWithStudentsAutomats);
//        }
//    }
    
//    $("#btn-savechanges").bind("click", function () {
//        getDatesToSend();
//        var dataToSend = arrayOfInputData;
//        var url = decodeURI(window.location.href);
//        dataToSend.push({ inputId: url });
//        dataToSend = JSON.stringify(dataToSend);

//        $.ajax({
//            url: "@Url.Action("SaveChanges")",
//            type: "POST",
//        data: dataToSend,
//        dataType: "json",
//        contentType: "application/json",
//        success: function (data) {
//            alert("data has been sent to server");
//        }
//        });
//    });
//$("#checkbox-date-to-mark").bind("change", function () {
//    var pointInputs;
//    var dateIpnuts;
//    if (!$(this).is(":checked"))  //если от "оценок" к "датам"
//    {
//        pointInputs = $("tbody.tablecontent .point-normal")
//            .removeClass("point-normal")
//            .addClass("point-hidden");
//        dateIpnuts = $("tbody.tablecontent .date-process-hidden")
//            .removeClass("date-process-hidden")
//            .addClass("date-process-normal");
//    }
//    else // если от "дат" к "оценкам"
//    {
//        dateIpnuts = $("tbody.tablecontent .date-process-normal")
//            .removeClass("date-process-normal")
//            .addClass("date-process-hidden");
//        pointInputs = $("tbody.tablecontent .point-hidden").
//            removeClass("point-hidden")
//            .addClass("point-normal");
//    }
//});
//function getDatesToSend() {
//    var moduleInputs = $("tbody.tablecontent>tr#" + recordBookNumbersList[0] + ">td.module");
//    var freeFieldInputs = $("tbody.tablecontent>tr#" + recordBookNumbersList[0] + ">td.freemarkfield");
//    for (var i = 0; i < recordBookNumbersList.length; i++) {
//        var currentStudent = $("tbody.tablecontent>tr#" + recordBookNumbersList[i]); // currentStudent - строка таблицы для i-го студента
//        var rowLengthAll = currentStudent.children().length;
//        for (var j = 1; j < rowLengthAll - moduleInputs.length - freeFieldInputs.length - 3; j++) {
//            var currentCell = currentStudent[0].children[j];
//            if (currentCell.children.length > 0) {
//                for (var k = 0; k < arrayOfInputData.length; k++) {
//                    if (arrayOfInputData[k].inputId === currentCell.children[0].children[0].id) {
//                        arrayOfInputData[k].dateOfReport = currentCell.children[1].children[1].value;
//                        arrayOfInputData[k].dateOfProgram = currentCell.children[1].children[3].value;
//                    }
//                }
//            }
//        }
//    }
//    debugger;
//}
//function recalculateMaxMarkSumWithStudentsAutomats() {
//    var table = $(this).closest("table");
//    var body = table[0].children[1];
//    var maxMarksSum = 0;
//    var maxPointsRow = $("thead>tr.maxpoints>th");
//    var cells = maxPointsRow.children();
//    // обработка thead
//    for (var i = 1; i < cells.length - 2; i++) {
//        if (cells[i].localName === "input") {
//            for (var k = 0; k < arrayOfInputData.length; k++) {
//                if (arrayOfInputData[k].inputId === cells[i].id) {
//                    arrayOfInputData[k].inputvalue = cells[i].value;
//                    maxMarksSum += +cells[i].value;
//                }
//            }
//        }
//        else if (cells[i].localName === "p") {
//            maxMarksSum += +cells[i].innerText;
//        }
//    }
//    var cellToInputSum = $("thead>tr.maxpoints>th>p#automat-title").empty().append(maxMarksSum + "/100");

//    //обработка tbody
//    for (var i = 0; i < body.children.length; i++) {
//        var currentStudent = $("tbody.tablecontent>tr#" + recordBookNumbersList[i]); // currentStudent - строка таблицы для i-го студента
//        var studentsTotalPointer = 0; // сумма всех отметок студента

//        // собираем все данные с ячеек строки студента
//        var rowLength = currentStudent.children().length;
//        for (var j = 1; j < rowLength - 2; j++) {
//            var currentCell = currentStudent[0].children[j]; // currentCell - текущий "ребенок" строки - ячейка <td>
//            if (currentCell.children.length > 0) {
//                if (currentCell.className != "lectures") {
//                    if (currentCell.children[0].children[0].localName === "input") {
//                        for (var k = 0; k < arrayOfInputData.length; k++) {
//                            if (arrayOfInputData[k].inputId === currentCell.children[0].children[0].id) {
//                                arrayOfInputData[k].inputvalue = currentCell.children[0].children[0].value;
//                                studentsTotalPointer += +currentCell.children[0].children[0].value;
//                            }
//                        }
//                    }
//                }
//                else {
//                    studentsTotalPointer += +currentCell.children[0].innerText;
//                }
//            } else continue;
//        }
//        var studentsAutomat = calcAutomat(maxMarksSum, studentsTotalPointer);
//        var studentsECTS = getECTS(studentsAutomat);
//        inputData(recordBookNumbersList[i], studentsAutomat, studentsECTS);
//    }
//}
//function handleDataFromCells() {
//    for (var i = 0; i < recordBookNumbersList.length; i++) {
//        var currentStudent = $("tbody.tablecontent>tr#" + recordBookNumbersList[i]); // currentStudent - строка таблицы для i-го студента
//        var studentsTotalPointer = 0; // сумма всех отметок студента

//        var rowLength = currentStudent.children().length;
//        for (var j = 1; j < rowLength - 2; j++) {
//            // currentCell - текущий "ребенок" строки - ячейка <td>
//            var currentCell = currentStudent[0].children[j];
//            if (currentCell.children.length > 0) {
//                if (currentCell.className != "lectures") {
//                    if (currentCell.children[0].children[0].localName === "input") {
//                        var inputObj = new inputObject();
//                        inputObj.rbn = currentStudent[0].id;    // номер зачетки студента
//                        inputObj.markType = currentCell.closest("td").className; // тип оценки
//                        inputObj.inputvalue = currentCell.children[0].children[0].value; // оценка
//                        inputObj.inputId = currentCell.children[0].children[0].id; // id оценки в БД
//                        arrayOfInputData.push(inputObj);
//                        studentsTotalPointer += +currentCell.children[0].children[0].value;
//                    }
//                }
//                else {
//                    studentsTotalPointer += +currentCell.children[0].innerText;
//                }
//            } else continue;
//        }
//        var studentsAutomat = calcAutomat(maxMarksSum, studentsTotalPointer);
//        var studentsECTS = getECTS(studentsAutomat);
//        inputData(recordBookNumbersList[i], studentsAutomat, studentsECTS);
//    }
//}
//function inputObject() {
//    this.rbn = "";
//    this.markType = "";
//    this.inputvalue = "";
//    this.inputId = "";
//    this.dateOfReport = "";
//    this.dateOfProgram = "";
//}
//function getRecordBookNumbers() {
//    var rbnList = [];
//    for (var i = 0; i < tablecontent.length; i++) {
//        rbnList.push(tablecontent[i].id);
//    }
//    return rbnList;
//}
//function calcAutomat(maxMarksSum, studentTotalPointer) {
//    if (maxMarksSum == 100) {
//        return Math.round(studentTotalPointer);
//    }
//    else {
//        var total = (studentTotalPointer * 100) / maxMarksSum;
//        return Math.round(total);
//    }
//}
//function getMaxMarkSum() {
//    var maxMarksSum = 0;
//    var maxPointsRow = $("thead>tr.maxpoints>th");
//    var cells = maxPointsRow.children();
//    for (var i = 1; i < cells.length - 2; i++) {
//        if (cells[i].localName === "input") {
//            var inputObj = new inputObject();
//            inputObj.rbn = "";
//            inputObj.markType = cells[i].closest("th").className;
//            inputObj.inputvalue = cells[i].value;
//            inputObj.inputId = cells[i].id;
//            arrayOfInputData.push(inputObj);

//            maxMarksSum += +cells[i].value;
//        }
//        else if (cells[i].localName === "p") {
//            maxMarksSum += +cells[i].innerText;
//        }
//    }
//    var cellToInputSum = $("thead>tr.maxpoints>th>p#automat-title").empty().append(maxMarksSum + "/100");
//    return maxMarksSum;
//}
//function getECTS(finishMark) {
//    if (finishMark >= 0 && finishMark <= 34) {
//        return "F";
//    }
//    else if (finishMark >= 35 && finishMark <= 59) {
//        return "FX";
//    }
//    else if (finishMark >= 60 && finishMark <= 67) {
//        return "E";
//    }
//    else if (finishMark >= 68 && finishMark <= 74) {
//        return "D";
//    }
//    else if (finishMark >= 75 && finishMark <= 82) {
//        return "C";
//    }
//    else if (finishMark >= 83 && finishMark <= 89) {
//        return "B";
//    }
//    else if (finishMark >= 90) {
//        return "A";
//    }
//    return "FX";
//}
//function inputData(id, automat, ECTS) {
//    var inputToPasteAutomat = $("tbody.tablecontent>tr#" + id + ">td.automat>p#" + id + "_automat").empty().append(automat);
//    var inputToPasteECTS = $("tbody.tablecontent>tr#" + id + ">td.ECTS>p#" + id + "_ECTS").empty().append(ECTS);
//}
//})();
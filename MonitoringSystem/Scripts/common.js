(function () {
    inputObject = function() {
        this.rbn = "";
        this.markType = "";
        this.inputvalue = "";
        this.inputId = "";
        this.dateOfReport = "";
        this.dateOfProgram = "";
    },
    getRecordBookNumbers = function(tablecontent) {
        var rbnList = [];
        for (var i = 0; i < tablecontent.length; i++) {
            rbnList.push(tablecontent[i].id);
        }
        return rbnList;
    },
    calcAutomat =  function(maxMarksSum, studentTotalPointer) {
        if (maxMarksSum == 100) {
            return Math.round(studentTotalPointer);
        }
        else {
            var total = (studentTotalPointer * 100) / maxMarksSum;
            return Math.round(total);
        }
    },
    getMaxMarkSum = function (arrayOfInputData) {
        var maxMarksSum = 0;
        var maxPointsRow = $("thead>tr.maxpoints>th");
        var cells = maxPointsRow.children();
        for (var i = 1; i < cells.length - 2; i++) {
            if (cells[i].localName === "input") {
                var inputObj = new inputObject();
                inputObj.rbn = "";
                inputObj.markType = cells[i].closest("th").className;
                inputObj.inputvalue = cells[i].value;
                inputObj.inputId = cells[i].id;
                arrayOfInputData.push(inputObj);

                maxMarksSum += +cells[i].value;
            }
            else if (cells[i].localName === "p") {
                maxMarksSum += +cells[i].innerText;
            }
        }
        var cellToInputSum = $("thead>tr.maxpoints>th>p#automat-title").empty().append(maxMarksSum + "/100");
        return maxMarksSum;
    },
    getECTS = function(finishMark) {
        if (finishMark >= 0 && finishMark <= 34) {
            return "F";
        }
        else if (finishMark >= 35 && finishMark <= 59) {
            return "FX";
        }
        else if (finishMark >= 60 && finishMark <= 67) {
            return "E";
        }
        else if (finishMark >= 68 && finishMark <= 74) {
            return "D";
        }
        else if (finishMark >= 75 && finishMark <= 82) {
            return "C";
        }
        else if (finishMark >= 83 && finishMark <= 89) {
            return "B";
        }
        else if (finishMark >= 90) {
            return "A";
        }
        return "FX";
    },
    inputData = function(id, automat, ECTS) {
        var inputToPasteAutomat = $("tbody.tablecontent>tr#" + id + ">td.automat>p#" + id + "_automat").empty().append(automat);
        var inputToPasteECTS = $("tbody.tablecontent>tr#" + id + ">td.ECTS>p#" + id + "_ECTS").empty().append(ECTS);
    },
    handleDataFromCells = function (recordBookNumbersList, arrayOfInputData, maxMarksSum) {
        for (var i = 0; i < recordBookNumbersList.length; i++) {
            var currentStudent = $("tbody.tablecontent>tr#" + recordBookNumbersList[i]); // currentStudent - строка таблицы для i-го студента
            var studentsTotalPointer = 0; // сумма всех отметок студента

            var rowLength = currentStudent.children().length;
            for (var j = 1; j < rowLength - 2; j++) {
                // currentCell - текущий "ребенок" строки - ячейка <td>
                var currentCell = currentStudent[0].children[j];
                if (currentCell.children.length > 0) {
                    if (currentCell.className != "lectures") {
                        if (currentCell.children[0].children[0].localName === "input") {
                            var inputObj = new inputObject();
                            inputObj.rbn = currentStudent[0].id;    // номер зачетки студента
                            inputObj.markType = currentCell.closest("td").className; // тип оценки
                            inputObj.inputvalue = +currentCell.children[0].children[0].value > 0 
                                ? +currentCell.children[0].children[0].value
                                : +currentCell.children[0].children[0].value * (-1); // оценка
                            inputObj.inputId = currentCell.children[0].children[0].id; // id оценки в БД
                            arrayOfInputData.push(inputObj);
                            studentsTotalPointer += +currentCell.children[0].children[0].value;
                        }
                    }
                    else {
                        studentsTotalPointer += +currentCell.children[0].innerText;
                    }
                } else continue;
            }
            var studentsAutomat = calcAutomat(maxMarksSum, studentsTotalPointer);
            var studentsECTS = getECTS(studentsAutomat);
            inputData(recordBookNumbersList[i], studentsAutomat, studentsECTS);
        }
    },
    $("#checkbox-date-to-mark").bind("change", function () {
        var pointInputs;
        var dateIpnuts;
        if (!$(this).is(":checked"))  //если от "оценок" к "датам"
        {
            pointInputs = $("tbody.tablecontent .point-normal")
                .removeClass("point-normal")
                .addClass("point-hidden");
            dateIpnuts = $("tbody.tablecontent .date-process-hidden")
                .removeClass("date-process-hidden")
                .addClass("date-process-normal");
        }
        else // если от "дат" к "оценкам"
        {
            dateIpnuts = $("tbody.tablecontent .date-process-normal")
                .removeClass("date-process-normal")
                .addClass("date-process-hidden");
            pointInputs = $("tbody.tablecontent .point-hidden").
                removeClass("point-hidden")
                .addClass("point-normal");
        }
    }),
    recalculateMaxMarkSumWithStudentsAutomats = function (arrayOfInputData, recordBookNumbersList) {
        var table = $(this).closest("table");
        var body = table[0].children[1];
        var maxMarksSum = 0;
        var maxPointsRow = $("thead>tr.maxpoints>th");
        var cells = maxPointsRow.children();
        // обработка thead
        for (var i = 1; i < cells.length - 2; i++) {
            if (cells[i].localName === "input") {
                for (var k = 0; k < arrayOfInputData.length; k++) {
                    if (arrayOfInputData[k].inputId === cells[i].id) {
                        arrayOfInputData[k].inputvalue = cells[i].value;
                        maxMarksSum += +cells[i].value;
                    }
                }
            }
            else if (cells[i].localName === "p") {
                maxMarksSum += +cells[i].innerText;
            }
        }
        var cellToInputSum = $("thead>tr.maxpoints>th>p#automat-title").empty().append(maxMarksSum + "/100");

        //обработка tbody
        for (var i = 0; i < body.children.length; i++) {
            var currentStudent = $("tbody.tablecontent>tr#" + recordBookNumbersList[i]); // currentStudent - строка таблицы для i-го студента
            var studentsTotalPointer = 0; // сумма всех отметок студента

            // собираем все данные с ячеек строки студента
            var rowLength = currentStudent.children().length;
            for (var j = 1; j < rowLength - 2; j++) {
                var currentCell = currentStudent[0].children[j]; // currentCell - текущий "ребенок" строки - ячейка <td>
                if (currentCell.children.length > 0) {
                    if (currentCell.className != "lectures") {
                        if (currentCell.children[0].children[0].localName === "input") {
                            for (var k = 0; k < arrayOfInputData.length; k++) {
                                if (arrayOfInputData[k].inputId === currentCell.children[0].children[0].id) {
                                    arrayOfInputData[k].inputvalue = currentCell.children[0].children[0].value;
                                    studentsTotalPointer += +currentCell.children[0].children[0].value;
                                }
                            }
                        }
                    }
                    else {
                        studentsTotalPointer += +currentCell.children[0].innerText;
                    }
                } else continue;
            }
            studentsTotalPointer = studentsTotalPointer < 0 ? studentsTotalPointer * (-1) : studentsTotalPointer;
            var studentsAutomat = calcAutomat(maxMarksSum, studentsTotalPointer);
            var studentsECTS = getECTS(studentsAutomat);
            inputData(recordBookNumbersList[i], studentsAutomat, studentsECTS);
        }
    }
})();
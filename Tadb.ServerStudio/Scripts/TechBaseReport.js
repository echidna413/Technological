$(document).ready(function () {
    FillFilters();
    GetRecordData();
});

function FillFilters() {
    $.ajax({
        url: '/EmployeeController/Get',
        type: 'GET',
        contentType: "application/json;charset=utf-8",
        success: function (data) {
            var employeeFieldStr = "<option value='null'></option>";
            $.each(data, function (index, value) {
                employeeFieldStr += "<option value='" + value.id_employee + "'>" +
                    value.first_name + " " + value.patronymic + " " + value.second_name + "</option>";
            })
            $("#employeeFilter").html(employeeFieldStr);
            var techReportEmployeeFilter = Cookies.get('techReportEmployeeFilter');
            if (techReportEmployeeFilter) {
                $("#employeeFilter").val(techReportEmployeeFilter);
            }
        },
        error: function (x, y, z) {
            alert(x + '\n' + y + '\n' + z);
        }
    });
    $.ajax({
        url: '/StatusController/Get',
        type: 'GET',
        contentType: "application/json;charset=utf-8",
        success: function (data) {
            var statusFieldStr = "<option value='null'></option>";
            $.each(data, function (index, value) {
                statusFieldStr += "<option value='" + value.id_status + "'>" +
                    value.name + "</option>";
            })
            $("#statusFilter").html(statusFieldStr);
            var techReportStatusFilter = Cookies.get('techReportStatusFilter');
            if (techReportStatusFilter) {
                $("#statusFilter").val(techReportStatusFilter);
            }
        },
        error: function (x, y, z) {
            alert(x + '\n' + y + '\n' + z);
        }
    });
}

function GetRecordData() {
    var recordFilter = {
        EmployeeId: Cookies.get('techReportEmployeeFilter'),
        StatusId: Cookies.get('techReportStatusFilter')
    }
    $.ajax({
        url: '/RecordController/Record',
        type: 'POST',
        data: JSON.stringify(recordFilter),
        contentType: "application/json;charset=utf-8",
        success: function (data) {
            FillTable(data, 'techBaseReportTable');
        },
        error: function (x, y, z) {
            alert(x + '\n' + y + '\n' + z);
        }
    });
}

function FillTable(data, tableId) {
    $("#techBaseReportTable").find("tr:gt(0)").remove();;
    var tableStr = "<tr><td>Сотрудник</td><td>Статус</td><td>Код оборудования</td><td>Код приспособления</td><td>Код технологического перехода</td><td>Код обрабатываемой поверхности</td></tr>";
    $.each(data, function (index, value) {
        //TODO добавить корректные валью по столбцам
        tableStr += "<tr>";
        tableStr += "<td>" + value.Employee + "</td>";
        tableStr += "<td>" + value.Status + "</td>";
        tableStr += "<td>" + value.Status + "</td>";
        tableStr += "<td>" + value.Status + "</td>";
        tableStr += "<td>" + value.Status + "</td>";
        tableStr += "<td>" + value.Status + "</td>";
        tableStr += "</tr>";
    });
    $("#" + tableId).html(tableStr);
}

function SaveFilters() {
    SaveFilterCookie();
    GetRecordData();
}

function SaveFilterCookie() {
    const logStorageTime = 7;
    Cookies.set('techReportEmployeeFilter', $("#employeeFilter").val(), { expires: logStorageTime });
    Cookies.set('techReportStatusFilter', $("#statusFilter").val(), { expires: logStorageTime });
}


function ReportDownload() {
    var iframe = document.createElement("iframe");
    iframe.src = "/RecordController/Record/Download?employeeId=" + Cookies.get('techReportEmployeeFilter')
        + "&statusId=" + Cookies.get('techReportStatusFilter');
    iframe.style.display = "none";
    document.body.appendChild(iframe);
}
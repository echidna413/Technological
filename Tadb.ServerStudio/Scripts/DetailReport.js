$(document).ready(function () {
    FillFilters();
    GetDetailData();
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
            var detailEmployeeFilter = Cookies.get('detailEmployeeFilter');
            if (detailEmployeeFilter) {
                $("#employeeFilter").val(detailEmployeeFilter);
            }
        },
        error: function (x, y, z) {
            alert(x + '\n' + y + '\n' + z);
        }
    });
    $.ajax({
        url: '/DescriptionController/Description/Material',
        type: 'GET',
        contentType: "application/json;charset=utf-8",
        success: function (data) {
            var materialFieldStr = "<option value='null'></option>";
            $.each(data, function (index, value) {
                materialFieldStr += "<option value='" + value + "'>" +
                    value + "</option>";
            })
            $("#materialFilter").html(materialFieldStr);
            var detailMaterialFilter = Cookies.get('detailMaterialFilter');
            if (detailMaterialFilter) {
                $("#materialFilter").val(detailMaterialFilter);
            }
        },
        error: function (x, y, z) {
            alert(x + '\n' + y + '\n' + z);
        }
    });
}

function GetDetailData() {
    var detailFilter = {
        EmployeeId: Cookies.get('detailEmployeeFilter'),
        Material: Cookies.get('detailMaterialFilter')
    }
    $.ajax({
        url: '/DescriptionController/Description',
        type: 'POST',
        data: JSON.stringify(detailFilter),
        contentType: "application/json;charset=utf-8",
        success: function (data) {
            FillTable(data);
        },
        error: function (x, y, z) {
            alert(x + '\n' + y + '\n' + z);
        }
    });
}

function FillTable(data) {
    $("#detailReportTable").find("tr:gt(0)").remove();;
    var tableStr = "<tr>" +
            "<td>Сотрудник</td>" +
            "<td>Код детали</td>" +
            "<td>Наименование детали</td>" +
            "<td>Марка материала</td>" +
            "<td>Объем производственной партии</td>" +
            "<td>Объем передаточной партии</td>" +
            "<td>Масса детали</td>" +
            "<td>Возможность изготовления центровых отверстий</td>" +
        "</tr>";
    $.each(data, function (index, value) {
        tableStr += "<tr>";
        tableStr += "<td>" + value.Employee + "</td>";
        tableStr += "<td>" + value.code_detail + "</td>";
        tableStr += "<td>" + value.name_detail + "</td>";
        tableStr += "<td>" + value.mark_material + "</td>";
        tableStr += "<td>" + value.size_production + "</td>";
        tableStr += "<td>" + value.size_transmission + "</td>";
        tableStr += "<td>" + value.mass_detail + "</td>";
        tableStr += "<td>" + value.central_hole + "</td>";
        tableStr += "</tr>";
    });
    $("#detailReportTable").html(tableStr);
}

function SaveFilters() {
    SaveFilterCookie();
    GetDetailData();
}

function SaveFilterCookie() {
    const logStorageTime = 7;
    Cookies.set('detailEmployeeFilter', $("#employeeFilter").val(), { expires: logStorageTime });
    Cookies.set('detailMaterialFilter', $("#materialFilter").val(), { expires: logStorageTime });
}


function ReportDownload() {
    var iframe = document.createElement("iframe");
    iframe.src = "/DescriptionController/Description/Download?employeeId=" + Cookies.get('detailEmployeeFilter')
        + "&material=" + Cookies.get('detailMaterialFilter');
    iframe.style.display = "none";
    document.body.appendChild(iframe);
}
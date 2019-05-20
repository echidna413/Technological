$(document).ready(function () {
    var $companySelect = $('select[name="company"]');

    $companySelect.change(function (index, element) {
        var company_id = $companySelect.val();
        var $recordTable = $('section.record-table');

        if (company_id !== '') {
            $.get(window.urls.getData, { id_company: company_id }, function (data) {
                $recordTable.html(data);
            });
        }
    })
});
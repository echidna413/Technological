$(document).ready(function () {
	var $catalogTable = $('table.catalog');
	var $dialog = $("#dialog");

	$('.btn-append').click(function (index, element) {
		$dialog.show();

		$.get(window.urls.appendCatalogItem, function (data) {
			$dialog.html(data);
		});

		$dialog.dialog({
			buttons: [
				{
					text: "OK",
					click: function () {
						$.post(window.urls.appendCatalogItem, $(".catalog-form").serialize(), function (data) {
							// todo add
						});
					}
				}
			],
			width: 700,
			height: 410
		});

		$('#dialog').dialog('option', 'title', 'Create User');
		return false;
	});
});

$(".createtrainer").click(function () {
	$("#dialog").show();

	$.get(window.urls.createTrainers, function (data) {
		$("#dialog").html(data);
	});

	$("#dialog").dialog({
		buttons: [
			{
				text: "OK",
				click: function () {
					$.post(window.urls.createTrainers, $(".personalForm").serialize(), function (data) {
						modals.handleModalWindowSave(data, '.select-trainers');
					});
				}
			}
		],
		width: 700,
		height: 410
	});

	$('#dialog').dialog('option', 'title', 'Create User');
	return false;
});

		//$('<tr>', {

		//}).appendTo($catalogTable);

		//$('<p>', {
		//	class: 'error-description',
		//	text: error,
		//}).appendTo($validationErrorBlock);

		//$('<a>', {
		//	href: '#',
		//	class: 'backLink',
		//	append: $('<i>', {
		//		class: 'material-icons mdl-list__item-icon',
		//		text: 'arrow_back'
		//	})
		//		.add($('<span>', {
		//			text: 'Back to All Publications List'
		//		})),
		//	on: {
		//		click: onBackToIndexButtonClick,
		//	}
		//}).appendTo($cardHeaderAdditionalBlock);

		//var company_id = $companySelect.val();
  //      var $recordTable = $('section.record-table');

  //      if (company_id !== '') {
  //          $.get(window.urls.getData, { id_company: company_id }, function (data) {
  //              $recordTable.html(data);
  //          });
  //      }
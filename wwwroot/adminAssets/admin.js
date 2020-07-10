$('#datetimepicker').datetimepicker({
    timepicker: true,
    datepicker: true,
});

$('#myModal').on('shown.bs.modal', function() {
    $('#myInput').trigger('focus')
});

//get id to delete
var selectedID = 0;
$('.delete').on("click", function() {
    selectedID = $(this).siblings(".id").text();
    selectedRow = $(this).parent('tr').addClass('js-selected');
});


$('.btn-delete-trainer').on("click", function() {
    $.ajax({
        url: "DeleteTrainer?trainerID=" + selectedID,
        type: "get",
        dataType: "html",
        beforeSend: function () {

        },
        success: function (response) {
            $('.alert-container').append(response);
            setTimeout(() => {
                $(".alert").fadeOut('slow')
            }, 2000);
            setTimeout(() => {
                $(".alert").alert('close')
            }, 4000);
            selectedRow.remove();
        },
        error: function (error) {
            console.log(error);
        },
        complete: function () { }
    });
});
$('.btn-delete-class').on("click", function() {
    console.log("class =" + selectedID);
});

$('.btn-delete-gym').on("click", function() {
    $.ajax({
        url: "DeleteGym?gymID=" + selectedID,
        type: "get",
        dataType: "html",
        beforeSend: function () {

        },
        success: function (response) {
            $('.alert-container').append(response);
            setTimeout(() => {
                $(".alert").fadeOut('slow')
            }, 2000);
            setTimeout(() => {
                $(".alert").alert('close')
            }, 4000);
            selectedRow.remove();
        },
        error: function (error) {
            console.log(error);
        },
        complete: function () { }
    });
});
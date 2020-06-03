// $('#datetimepicker').datetimepicker({
//     timepicker: true,
//     datepicker: true,
// });

$('#myModal').on('shown.bs.modal', function() {
    $('#myInput').trigger('focus')
});

//get id to delete
var ClassID = 0;
var selectedRow;
$('.delete').on("click", function() {
    ClassID = $(this).siblings(".id").text();
    selectedRow = $(this).parent('tr').addClass('js-selected');
});


$('.btn-delete-trainer').on("click", function() {
    console.log("trainer =" + ClassID);
    setTimeout(() => {
        $(".alert").fadeOut('slow')
    }, 2000);
    setTimeout(() => {
        $(".alert").alert('close')
    }, 4000);
    selectedRow.remove();
});

$('.btn-delete-class').on("click", function() {
    console.log("class =" + ClassID);
});

$('.btn-delete-gym').on("click", function() {
    console.log("gym =" + ClassID);
});
$('#datetimepicker').datetimepicker({
    timepicker: true,
    datepicker: true,
});

$('#myModal').on('shown.bs.modal', function() {
    $('#myInput').trigger('focus')
});

//get id to delete
var ClassID = 0;
$('.delete').on("click", function() {
    ClassID = $(this).siblings(".id").text();
});


$('.btn-delete-trainer').on("click", function() {
    console.log("trainer =" + ClassID);
});
$('.btn-delete-class').on("click", function() {
    console.log("class =" + ClassID);
});

$('.btn-delete-gym').on("click", function() {
    console.log("gym =" + ClassID);
});
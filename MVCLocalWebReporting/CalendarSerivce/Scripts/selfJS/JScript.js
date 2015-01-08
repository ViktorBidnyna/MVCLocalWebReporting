$(document).ready(function () {
    $('#btn').click(function () {
        $.ajax({
            url: "http://localhost:56591/api/values/1",
            type: "DELETE",
            success: function (data) {
                alert(data);
            },
            error: function () {
                console.log("Error");
            }
        });
    });
});
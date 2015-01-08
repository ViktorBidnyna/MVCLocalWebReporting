$(document).ready(function () {
    $('#btn').click(function () {
        $.ajax({
            url: "http://localhost:56591/api/values",
            //type: "DELETE",
            dataType: "JSON",
            success: function (data) {
                console.log(data);
            },
            error: function () {
                console.log("Error");
            }
        });
    });
});
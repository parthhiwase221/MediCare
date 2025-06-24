
var Savereg = function () {
    debugger
    var AppointmentDate = $("#AppointmentDate").val();
    var StartTime = $("#StartTime").val();
    var EndTime = $("#EndTime").val();
    var Status = $("#Status").val();
    var Reason = $("#Reason").val();
    var Notes = $("#Notes").val();
    var model = 
    {
        AppointmentDate: AppointmentDate,
            StartTime: StartTime,
            EndTime: EndTime,
            Status: Status,
            Reason: Reason,
            Notes: Notes,
    };

    $.ajax({
        url: "/HomeController/SaveAppointment",
        method: "post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (response) {
            ClearRegForm();
            alert(response.Message);
        }

    });
};

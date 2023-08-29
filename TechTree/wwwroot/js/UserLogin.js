


$(function () {
    var userLoginBtn = $("#UserLoginModal button[name='login']").click(onUserLoginClick);

    function onUserLoginClick() {
        console.log("clicked")
        const url = "UserAuth/Login";
        const antiForgeryToken = $("#UserLoginModal input[name='__RequestVerificationToken']").val();
        const Email = $("#UserLoginModal input[name='Email']").val();
        const Password = $("#UserLoginModal input[name='Password']").val();
        const RememberMe = $("#UserLoginModal input[name='RememberMe']").prop('checked');

        const data = {
            Email,
            Password,
            RememberMe,
            __RequestVerificationToken: antiForgeryToken
        }
        console.log(data);

        $.ajax({
            type: "POST",
            url,
            data,
            success: function (data) {
                console.log(data)
                const parsed = $.parseHTML(data);
                const hasErrors = $(parsed).find("input[name='LoginInValid']").val() == "true";
                if (hasErrors) {
                    $("#UserLoginModal").html(data);
                    userLoginBtn = $("#UserLoginModal button[name='login']").click(onUserLoginClick);
                    let form = $("#UserLoginForm");
                    $(form).removeData("validator");
                    $(form).removeData('unobtrusiveValidation');
                    $.validator.unobtrusive.parse(form);
                } else {
                    location.href = '/Home/Index';
                }
            },
            error: function (xhr, ajaxOptions, thrownError) {
                console.error(`${thrownError}\r\n${xhr.statusText}\r\n${xhr.statusCode}`);
                const errorText = `Status: ${xhr.statusCode}\r\n${xhr.statusText}`;
                PresentBootstrapAlert("#alert_placholder_register", "danger", "Error!", errorText);
            }
        })
    }
})
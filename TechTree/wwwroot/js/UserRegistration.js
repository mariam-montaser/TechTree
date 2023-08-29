$(function () {
    var userRegisterBtn = $("#UserRegistrationModal button[name='register']");

    userRegisterBtn.prop("disabled", true);

    const emailInput = $("#UserRegistrationModal input[name='Email']");

    $("#UserRegistrationModal input[name='AcceptUserAgreement']").click(onAcceptUserAgreementClick);

    function onAcceptUserAgreementClick() {
        if ($(this).is(":checked")) {
            userRegisterBtn.prop("disabled", false)
        } else {
            userRegisterBtn.prop("disabled", true)

        }
    }

    emailInput.blur(function () {
        console.log("blur")
        const email = emailInput.val();
        const url = `UserAuth/UserNameExist?username=${email}`;
        $.ajax({
            url,
            success: function (data) {
                const placeholderElementId = "#alert_placholder_register";
                if (data) {
                    const alertType = "warning";
                    const alertHeading = "Email Invalid";
                    const alertMessage = "This Email Address has already exist.";
                    
                    PresentBootstrapAlert(placeholderElementId, alertType, alertHeading, alertMessage);
                    //const alertHtml = '<div class="alert alert-' + alertType + ' alert-dismissible fade show" role="alert">' +
                    //    '<strong>' + alertHeading + '</strong><br>' + alertMessage +
                    //    '<button type="button" class="close" data-dismiss="alert" aria-label="Close">' +
                    //    '<span aria-hidden="true">&times;</span>' +
                    //    '</button>' +
                    //    '</div>';

                    //$(placeholderElementId).html(alertHtml);
                }
                else {
                    CloseAlert(placeholderElementId);
                }
            },
            error: function (xhr, ajaxOptions, thrownError) {
                console.error(`${thrownError}\r\n${xhr.statusText}\r\n${xhr.statusCode}`);
                const errorText = `Status: ${xhr.statusCode}\r\n${xhr.statusText}`;
                PresentBootstrapAlert("#alert_placholder_register", "danger", "Error!", errorText);
            }
        });
    });


    userRegisterBtn.click(onUserRegisterClick);

    function onUserRegisterClick() {    
        console.log("clicked")
        const url = "UserAuth/Register";
        const antiForgeryToken = $("#UserRegistrationModal input[name='__RequestVerificationToken']").val();
        const Email = $("#UserRegistrationModal input[name='Email']").val();
        const Password = $("#UserRegistrationModal input[name='Password']").val();
        const ConfirmPassword = $("#UserRegistrationModal input[name='ConfirmPassword']").val();
        const FirstName = $("#UserRegistrationModal input[name='FirstName']").val();
        const LastName = $("#UserRegistrationModal input[name='LastName']").val();
        const PhoneNumber = $("#UserRegistrationModal input[name='PhoneNumber']").val();
        const PostCode = $("#UserRegistrationModal input[name='PostCode']").val();
        const Address1 = $("#UserRegistrationModal input[name='Address1']").val();
        const Address2 = $("#UserRegistrationModal input[name='Address2']").val();
        //const RememberMe = $("#UserRegistrationModal input[name='RememberMe']").prop('checked');

        const data = {
            Email,
            Password,
            ConfirmPassword,
            Address1,
            Address2,
            FirstName,
            LastName,
            PhoneNumber,
            PostCode,
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
                const hasErrors = $(parsed).find("input[name='RegistrationInValid']").val() == "true";
                if (hasErrors) {
                    $("#UserRegistrationModal").html(data);
                    userRegisterBtn = $("#UserRegistrationModal button[name='register']").click(onUserRegisterClick);
                    let form = $("#UserRegistrationForm");
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
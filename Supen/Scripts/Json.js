

function logIn() {
    $('#LoginForm').submit(function() {

        $('#LoginForm').validate();
        if ($('#LoginForm').valid()) {
            $.ajax({
                url: "/Account/Login",
                type: "POST",
                data: $(this).serialize(),
                success: function(result) {
                    if (result == true) {
                        window.location = "/Portal/";
                    } else {
                        
                    }
                }
            });
        } else {

        }
        return false;
    });
}

function Register() {
    $('#RegistrationForm').submit(function () {

        $('#RegistrationForm').validate();
        if($('#RegistrationForm').valid()){
            $.ajax({

                url: "/Account/CreateUser",
                type: "POST",
                data: $(this).serialize(),
                success: function(result) {
                    if (result == true) {
                        window.location = "/Portal/";
                    }
                    else {
                        
                    }
                }
            });
        }
        return false;
    });

}


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
                        window.location = "//";
                    } else {//om inloggning misslyckas
                        
                    }
                }
            });
        } else {//om validering av fält misslyckas

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
                        window.location = "";
                    }
                    else {
                        
                    }
                }
            });
        }
        return false;
    });

}
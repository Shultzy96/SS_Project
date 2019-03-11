$(document).ready(function () {

    $('button').click(function () {

        $('.updateAlert').append("<div class='alert alert-success alert-dismissable'><button type='button' class='close' data-dismiss='alert' aria-hidden='true'>&times;</button>Update Successful!</div>")

        $('.deleteAlert').append("<div class='alert alert-danger alert-dismissable'><button type='button' class='close' data-dismiss='alert' aria-hidden='true'>&times;</button>Data Deleted!</div>")

        $('.loginAlert').append("<div class='alert alert-info alert-dismissable'><button type='button' class='close' data-dismiss='alert' aria-hidden='true'>&times;</button>Login Successful!</div>")

    })

});
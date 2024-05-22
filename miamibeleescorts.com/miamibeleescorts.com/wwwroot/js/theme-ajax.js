jQuery(document).ready(function($) {
    // for user login form
    $("form#rsUserLogin").submit(function(){
        var isvalidate=jQuery("#rsUserLogin").valid();
        if(isvalidate)
        {
            var submit = $(".userLogin #submit"),
            preloader = $(".userLogin #preloader"),
            message    = $(".userLogin #message"),
            contents = {
                action:         'user_login',
                nonce:             this.rs_user_login_nonce.value,
                log:            this.log.value,
                pwd:            this.pwd.value,
                remember:        this.remember.value,
                redirection_url:    this.redirection_url.value
            };
        
        // disable button onsubmit to avoid double submision
        //submit.attr("disabled", "disabled").addClass('disabled');
        
        // Display our pre-loading
        preloader.show();
        
        // on my previous tutorial it just simply returned HTML but this time I decided to use JSON type so we can check for data success and redirection url.
        $.post( theme_ajax.url, contents, function( data ){
            submit.removeAttr("disabled").removeClass('disabled');
            
            // hide pre-loader
            preloader.css({'visibility':'hidden'});
            var response = data.split("|");         
            if (response[0]==="1"){
                window.location = response[2];;
            }else{
                message.html( '<p class="error">' + response[1] + '</p>' );
            }            
            
        }, 'json');
        
        return false;
        }   
        
    });

    // for Update Password Fomr
    $("form#passwordChangeForm").submit(function(){
        var isvalidate=jQuery("#passwordChangeForm").valid();
        if(isvalidate)
        {
            var submit = $(".passwordChange #csubmit"),
            preloader = $(".passwordChange #preloader"),
            message    = $(".passwordChange #message"),
            contents = {
                action:         'userupdatepass_login',            
                password:            this.cpassword.value,                
                redirection_url:    this.redirection_url.value
            };
        
        // disable button onsubmit to avoid double submision
        //submit.attr("disabled", "disabled").addClass('disabled');
        
        // Display our pre-loading
        preloader.show();
        
        // on my previous tutorial it just simply returned HTML but this time I decided to use JSON type so we can check for data success and redirection url.
        $.post( theme_ajax.url, contents, function( data ){
            submit.removeAttr("disabled").removeClass('disabled');
            
            // hide pre-loader
            preloader.css({'visibility':'hidden'});
            var response = data.split("|");         
            if (response[0]==="1"){
                window.location = response[2];
            }else{
                message.html( '<p class="error">' + response[1] + '</p>' );
            }            
            
        }, 'json');
        
        return false;
        }   
        
    });

});
$(document).ready(function(){
    $("#crud").click(function(){
        $("#dpcnt").toggle();
        $("#hdpcnt").hide();
        $("#audpcnt").hide();
        $("#hdpcnt").hide();
        $("#text").hide();  
        $('#textfield').hide();  
        $("#Auth_fields").hide();  
        $('#txtfld').hide();  
        $("#patchfield").hide();
        $("#delfield").hide();
        $('#putfield').hide();
        $("#reqhtxt").hide();
        $("#reshtxt").hide();
    });
    $("#header").click(function(){
        $("#hdpcnt").toggle();
        $("#dpcnt").hide();
        $("#audpcnt").hide();
        $("#text").hide();  
        $('#textfield').hide();  
        $("#Auth_fields").hide();  
        $('#txtfld').hide();  
        $("#patchfield").hide();
        $("#delfield").hide();
        $('#putfield').hide();
        $("#reqhtxt").hide();
        $("#reshtxt").hide();
    });
    $("#authenticate").click(function(){
        $("#audpcnt").toggle();
        $("#hdpcnt").hide();
        $("#dpcnt").hide();
        $("#text").hide();  
        $('#textfield').hide();  
        $("#Auth_fields").hide();  
        $('#txtfld').hide();  
        $("#patchfield").hide();
        $("#delfield").hide();
        $('#putfield').hide();
        $("#reqhtxt").hide();
        $("#reshtxt").hide();
    })
});

// Text fields display functions
$(document).ready(function(){
    $("#getbtn").click(function(){
        $("#text").toggle();  
        $('#textfield').hide();  
        $("#Auth_fields").hide();  
        $('#txtfld').hide();  
        $("#patchfield").hide();
        $("#delfield").hide();
        $('#putfield').hide();
        $("#reqhtxt").hide();
        $("#reshtxt").hide();
    });
    $("#pfdbtn").click(function(){
        $('#txtfld').toggle();
        $("#text").hide();
        $("#patchfield").hide();
        $('#textfield').hide();
        $("#Auth_fields").hide();
        $("#delfield").hide();
        $('#putfield').hide();
        $("#reqhtxt").hide();
        $("#reshtxt").hide();
    });
    $("#postbtn").click(function(){
        $("#textfield").toggle();
        $('#putfield').hide();
        $("#text").hide();
        $("#Auth_fields").hide();
        $('#txtfld').hide(); 
        $("#patchfield").hide();
        $("#delfield").hide(); 
        $("#reqhtxt").hide();
        $("#reshtxt").hide();
    });
    $("#putbtn").click(function(){
        $('#putfield').toggle();
        $("#textfield").hide();
        $("#text").hide();
        $("#Auth_fields").hide();
        $('#txtfld').hide();  
        $("#patchfield").hide();
        $("#delfield").hide();
        $("#reqhtxt").hide();
        $("#reshtxt").hide();
    });
    $("#patchbtn").click(function(){
        $("#patchfield").toggle();
        $("#textfield").hide();
        $('#putfield').hide();
        $("#text").hide();
        $("#Auth_fields").hide();
        $('#txtfld').hide();  
        $("#delfield").hide();
        $("#reqhtxt").hide();
        $("#reshtxt").hide();
       
    });
    $("#delbtn").click(function(){
        $("#delfield").toggle();
        $('#putfield').hide();
        $("#patchfield").hide();
        $("#text").hide();
        $("#Auth_fields").hide();
        $('#txtfld').hide();  
        $("#textfield").hide();
        $("#reqhtxt").hide();
        $("#reshtxt").hide();
    });
    $("#auth").click(function(){
        $("#Auth_fields").toggle();
        $('#putfield').hide();
        $("#textfield").hide();
        $("#text").hide();
        $('#txtfld').hide();  
        $("#patchfield").hide();
        $("#delfield").hide();
        $("#reqhtxt").hide();
        $("#reshtxt").hide();
    });  
    $("#reqhbtn").click(function(){
        $("#reqhtxt").toggle();
        $("#reshtxt").hide();
        $("#Auth_fields").hide();
        $('#putfield').hide();
        $("#textfield").hide();
        $("#text").hide();
        $('#txtfld').hide();  
        $("#patchfield").hide();
        $("#delfield").hide();
    });
    $("#reshbtn").click(function(){
        $("#reshtxt").toggle();
        $("#Auth_fields").hide();
        $("#reqhtxt").hide();
        $('#putfield').hide();
        $("#textfield").hide();
        $("#text").hide();
        $('#txtfld').hide();  
        $("#patchfield").hide();
        $("#delfield").hide();
    });
});
//Text Field increment function to get method
$(document).ready(function(){
        var max_fields = 10; //max_fields of input boxes
        var add_Field = $("#add"); 
        
        var x = 1; //intial text box count
        $(add_Field).click(function(e){ // on button click event
            
            if(x <= max_fields){ //max input boxes allowed
                x++; // text box increment
                $('#txt').clone().attr('id', 'txt'+ $(this).index()).insertAfter('#txt'); //add input box
            }
        });
    $('#remove').click(function(){
        if(x == 1){
            alert("No TextFields to remove");
            return false;
        }
        x--;
        $('#txt').remove();
    });            
});

// Text fields increment to Post form data
//Basic athenticate method
function athenticate(){
    var userName = document.getElementById("name").value;
    var psaaword = document.getElementById("password").value;

    var xhttp = new XMLHttpRequest();
    xhttp.readystatechange = function(){
        if(this.readyState === 4 && this.status === 200 ){
            document.getElementById("athensub").innerHTML = this.responseText;
        }
    };
    xhttp.open("GET", "/basic-auth", true);
    xhttp.send();
}

//get Method
 function callget(){
     var xhttp = new XMLHttpRequest();
     xhttp.onreadystatechange = function(){
         if(this.readyState === 4 && this.status === 200){
            var data = document.getElementById("getsubbtn").innerHTML = this.responseText;
            document.writeln(data);
         }
     };
     xhttp.open("get", '/get?foo1=bar1&foo2=bar2', true);
     xhttp.send();
 }

 // PostForm Data method
 function postformData(){
    var key = document.getElementById("fieldkey").value;
    var value = document.getElementById("fieldvalue").value;

    var xhttp = new XMLHttpRequest();
    xhttp.readystatechange= function(){
        if(this.readyState === 4 && this.status === 200)
        {
            document.getElementById("formsub").innerHTML = this.responseText;
        }
    };
    xhttp.open("POST","/post",true);
    xhttp.send("foo1="+ key + "&" + "foo2="+ value);

}

//Post data method
function postData(){
    var data = document.getElementById("postdata").value;

    var xhttp = new XMLHttpRequest();
    xhttp.readystatechange = function(){
        if(this.readyState === 4 && this.status === 200 ){
            document.getElementById("postsub").innerHTML = this.responseText;
        }
    };
    xhttp.open("POST", "/post", true);
    xhttp.send("foo1=" + data);
}

//put data method
function putData(){
    var data = document.getElementById("putdata").value;

    var xhttp = new XMLHttpRequest();
    xhttp.readystatechange = function(){
        if(this.readyState === 4 && this.status === 200 ){
            document.getElementById("putsub").innerHTML = this.responseText;
        }
    };
    xhttp.open("PUT", "/put", true);
    xhttp.send(data);
}

//patch data method
function patchData(){
    var data = document.getElementById("patchdata").value;

    var xhttp = new XMLHttpRequest();
    xhttp.readystatechange = function(){
        if(this.readyState === 4 && this.status === 200 ){
            document.getElementById("patchsub").innerHTML = this.responseText;
        }
    };
    xhttp.open("PATCH", "/patch", true);
    xhttp.send(data);
}

//Delete data method
function delData(){
    var data = document.getElementById("deldata").value;

    var xhttp = new XMLHttpRequest();
    xhttp.readystatechange = function(){
        if(this.readyState === 4 && this.status === 200 ){
            document.getElementById("delsub").innerHTML = this.responseText;
        }
    };
    xhttp.open("DELETE", "/delete", true);
    xhttp.send(data);
}

//Request Header method
function requestHeader(){
    var data = document.getElementById("reqhbtn").value;

    var xhttp = new XMLHttpRequest();
    xhttp.readystatechange = function(){
        if(this.readyState === 4 && this.status === 200 ){
           var text= document.getElementById("reqhbtn").innerHTML = this.responseText;
            document.write(text);
        }
    };
    xhttp.open("GET", "/headers", true);
    xhttp.send(data);
}
//Response Header method
function responseHeader(){
    var data = document.getElementById("reqhbtn").value;

    var xhttp = new XMLHttpRequest();
    xhttp.readystatechange = function(){
        if(this.readyState === 4 && this.status === 200 ){
           var text = document.getElementById("reshbtn").innerHTML = this.responseText;
           document.write(text);
        }
    };
    xhttp.open("GET", "/headers", true);
    xhttp.send(data);
}
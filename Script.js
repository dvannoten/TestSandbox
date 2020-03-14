// JavaScript source code
function loadDoc()
    {
        var xhttp = new XMLHttpRequest();

        xhttp.open("GET", "ajax_info.txt", true);
        xhttp.send();

    document.getElementById("demo").innerHTML = XMLHttpRequest.responseText;

        
};



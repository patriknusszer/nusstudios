window.onload = function () {
    var value = getCookie("Voted");

    if (value != "True") {
        var btn_plus_zsb = document.getElementsByClassName("btn_plus_zsb")[0];
        btn_plus_zsb.setAttribute("style", "display: block;");
    }
    else {
        var info = document.getElementsByClassName("info")[0];
        info.innerHTML = "Thanks for voting!<br>";

        var cntRequest = new XMLHttpRequest();

        cntRequest.onreadystatechange = function () {
            if (cntRequest.readyState == 4) {
                var cnt = cntRequest.responseText;
                info.innerHTML += "We have " + cnt + " votes";
            }
        }

        cntRequest.open('GET', 'http://nusstudios.azurewebsites.net/pt4zsb/get_zsb');
        cntRequest.send();
    }
}

function getCookie(cname) {
    var name = cname + "=";
    var ca = document.cookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
}
function toNUnit(unit, inBits) {
    var nUnit = 0;

    if (unit == 'Bit' || unit == 'bit') {
        nUnit = -1;
    }
    else if (unit == 'B' || unit == 'b' || unit == 'Byte' || unit == 'byte') {
        nUnit = 0;
    }
    else if (unit = 'kB' || unit == 'kb' || unit == 'KByte' || unit == 'kbyte' || unit == 'KBit' || unit == 'kbit') {
        nUnit = 1;
    }
    else if (unit == 'MB' || unit == 'mb' || unit == 'MByte' || unit == 'mbyte' || unit == 'MBit' || unit == 'mbit') {
        nUnit = 2;
    }
    else if (unit == 'GB' || unit == 'gb' || unit == 'GByte' || unit == 'gbyte' || unit == 'GBit' || unit == 'gbit') {
        nUnit = 3;
    }
    else if (unit == 'TB' || unit == 'tb' || unit == 'TByte' || unit == 'tbyte' || unit == 'TBit' || unit == 'tbit') {
        nUnit = 4;
    }

    if (inBits) {
        nUnit++;
    }

    return nUnit;
}

function toUnit(nUnit, inBits) {
    var unit = 'Bit';

    if (nUnit == -1) {
        unit = 'Bit';
    }
    if (nUnit == 0) {
        unit = 'Byte';
    }
    else if (nUnit == 1) {
        unit = 'KByte';
    }
    else if (nUnit == 2) {
        unit = 'MByte';
    }
    else if (nUnit == 3) {
        unit = 'GByte';
    }
    else if (nUnit == 4) {
        unit = 'TByte';
    }

    if (inBits) {
        return unit.replace('Byte', 'Bit');
    }
    else {
        return unit.replace('Byte', 'B');
    }
}

function getSize(clen, unit, inBits, doRound) {
    var nUnit = toNUnit(unit, inBits);
    var length = parseInt(clen);

    if (!inBits && nUnit == -1 && length / 8 >= 1) {
        if (doRound) {
            length = Math.round(length / 8);
        }
        else {
            length = length / 8;
        }

        nUnit++;
    }

    while (length / 1024 >= 1) {
        if (doRound) {
            length = Math.round(length / 1024);
        }
        else {
            length = length / 1024;
        }

        nUnit++;
    }

    return length + ' ' + toUnit(nUnit, inBits);
}

function getStreamMapUrl(url) {
    cleanPreviousSession();
    var cptrGroups = null;

    if ((cptrGroups = new RegExp(/https:\/\/vimeo.com\/([0-9]+)/).exec(url)) != null && cptrGroups[0] == url) {
        var videoId = cptrGroups[1];
        getvimeovideoinfo(videoId);
    }
}

// --------------- Youtube stream processors ---------------

/* function processYoutubeStreams(map) {
    var adaptive_fmts = map['adaptive_fmts'];
    var url_encoded_fmt_stream_map = map['url_encoded_fmt_stream_map'];
    var stream_box = document.createElement('div');
    stream_box.className = 'combobox';
    var cbmain = document.createElement('div');
    cbmain.className = 'cbmain m_toggledoff';
    stream_box.appendChild(cbmain);
    var cbtogglegroup = document.createElement('div');
    cbtogglegroup.className = 'cbtogglegroup tg_toggledoff';
    stream_box.appendChild(cbtogglegroup);

    for (var i = 0; i < url_encoded_fmt_stream_map.length; i++) {
        var option = document.createElement('div');
        option.innerHTML = 'Video with sound, ';
        var url_encoded_fmt_stream = url_encoded_fmt_stream_map[i];
        var ext = url_encoded_fmt_stream['container'];
        var quality = url_encoded_fmt_stream['quality'];

        if (quality == 'hd720') {
            option.innerHTML += 'HD 720p';
        }
        else if (quality == 'medium') {
            option.innerHTML += 'medium quality';
        }
        else if (quality == 'small') {
            option.innerHTML += 'small quality';
        }

        option.innerHTML += ', ' + ext.toUpperCase();
        option.setAttribute('dl_link', url_encoded_fmt_stream['url']);
        cbtogglegroup.appendChild(option);
    }

    for (var i = 0; i < adaptive_fmts.length; i++) {
        var option = document.createElement('div');
        var adaptive_fmt = adaptive_fmts[i];
        var mediaType = adaptive_fmt['media_type'];
        var ext = adaptive_fmt['container'];

        if (mediaType == 'video') {
            option.innerHTML = 'Video only, ';
            var quality = adaptive_fmt['size'];
            option.innerHTML += quality + ', ';
            var clen = adaptive_fmt['clen_converted'];
            option.innerHTML += clen;
        }
        else {
            option.innerHTML = 'Audio, ';
            var bitrate = adaptive_fmt['bitrate_converted'];
            option.innerHTML += bitrate + ' bits/s';
            bitrate = getSize(bitrate, 'Bit', true, true);
            option.innerHTML += ' : ' + bitrate + '/s';
        }

        option.innerHTML += ', ' + ext.toUpperCase();
        option.setAttribute('dl_link', adaptive_fmt['url']);
        cbtogglegroup.appendChild(option);
    }

    var p = document.getElementsByTagName('p')[0];
    var dl_title = document.createElement('p');
    dl_title.className = 'dl_title';
    console.log(map);
    dl_title.innerHTML = map['title'] + '<br>Select a stream';
    p.parentNode.insertBefore(dl_title, p);
    p.parentNode.insertBefore(stream_box, p);
    var a = document.createElement('a');
    a.className = 'dl_a';
    a.setAttribute('href', '');
    a.setAttribute('download', '');
    var dl_btn = document.createElement('div');
    dl_btn.className = 'dl_btn';
    dl_btn.innerHTML = 'Download';
    a.appendChild(dl_btn);
    p.parentElement.insertBefore(a, p);
} */

// --------------- Youtube stream processors ---------------

// --------------- Vimeo stream processors ---------------

function getvimeovideoinfo(videoId) {
    var mapRequest = new XMLHttpRequest();

    mapRequest.onreadystatechange = function () {
        if (mapRequest.readyState == 4) {
            var map = JSON.parse(mapRequest.responseText);
            processVimeoStreams(map);
        }
    }

    mapRequest.open('GET', 'https://nusstudios.com/nussapi/vimeoquery/' + videoId, true);
    mapRequest.send();
}

function processVimeoStreams(map) {
    var streams = map['streams'];
    var stream_box = document.createElement('div');
    stream_box.className = 'combobox';
    var cbmain = document.createElement('div');
    cbmain.className = 'cbmain m_toggledoff';
    stream_box.appendChild(cbmain);
    var cbtogglegroup = document.createElement('div');
    cbtogglegroup.className = 'cbtogglegroup tg_toggledoff';
    stream_box.appendChild(cbtogglegroup);

    for (var i = 0; i < streams.length; i++) {
        var stream = streams[i];
        var option = document.createElement('div');
        var type = stream['mime'].split('/')[0];
        var ext = stream['mime'].split('/')[1];
        var fps = stream['fps'];
        var height = stream['height'];
        var quality = stream['quality'];
        
        if (type == 'video') {
            option.innerHTML = 'Video with audio, ';
            option.innerHTML += quality + ', ';
            option.innerHTML += ext.toUpperCase();
        }
        else if (type == 'audio') {
            option.innerHTML = 'Audio'
        }

        option.setAttribute('dl_link', stream['url']);
        cbtogglegroup.appendChild(option);
    }

    var p = document.getElementsByTagName('p')[0];
    var dl_title = document.createElement('p');
    dl_title.className = 'dl_title';
    dl_title.innerHTML = map['title'] + '<br>Select a stream';
    p.parentNode.insertBefore(dl_title, p);
    p.parentNode.insertBefore(stream_box, p);
    var a = document.createElement('a');
    a.className = 'dl_a';
    a.setAttribute('href', '');
    a.setAttribute('download', '');
    var dl_btn = document.createElement('div');
    dl_btn.className = 'dl_btn';
    dl_btn.innerHTML = 'Download';
    a.appendChild(dl_btn);
    p.parentElement.insertBefore(a, p);
}

// --------------- Vimeo stream processors ---------------

// --------------- Facebook stream processors ---------------

function getfacebookstreammap(videoId) {
    var mapRequest = new XMLHttpRequest();

    mapRequest.onreadystatechange = function () {
        if (mapRequest.readyState == 4) {
            var map = JSON.parse(mapRequest.responseText);
            processFacebookStreams(map);
        }
    }

    mapRequest.open('GET', 'http://nusstudios.azurewebsites.net/nussapi/getfacebookstreammap/videoid=' + videoId, true);
    mapRequest.send();
}

function processFacebookStreams(map) {
    var stream_box = document.createElement('div');
    stream_box.className = 'combobox';
    var cbmain = document.createElement('div');
    cbmain.className = 'cbmain m_toggledoff';
    stream_box.appendChild(cbmain);
    var cbtogglegroup = document.createElement('div');
    cbtogglegroup.className = 'cbtogglegroup tg_toggledoff';
    stream_box.appendChild(cbtogglegroup);

    if (map['hd']) {
        var option = document.createElement('div');
        option.innerHTML = "HD video with audio";
        option.setAttribute('dl_link', map['hd']);
        cbtogglegroup.appendChild(option);
    }

    if (map['sd']) {
        var option = document.createElement('div');
        option.innerHTML = "SD video with audio";
        option.setAttribute('dl_link', map['sd']);
        cbtogglegroup.appendChild(option);
    }

    if (map['subtitles']) {
        var option = document.createElement('div');
        option.innerHTML = "Vdeo subtitle";
        option.setAttribute('dl_link', map['subtitles']);
        cbtogglegroup.appendChild(option);
    }

    var p = document.getElementsByTagName('p')[0];
    var dl_title = document.createElement('p');
    dl_title.className = 'dl_title';
    dl_title.innerHTML = map['title'] + '<br>Select a stream';
    p.parentNode.insertBefore(dl_title, p);
    p.parentNode.insertBefore(stream_box, p);
    var a = document.createElement('a');
    a.className = 'dl_a';
    a.setAttribute('href', '');
    a.setAttribute('download', '');
    var dl_btn = document.createElement('div');
    dl_btn.className = 'dl_btn';
    dl_btn.innerHTML = 'Download';
    a.appendChild(dl_btn);
    p.parentElement.insertBefore(a, p);
}

// --------------- Facebook stream processors ---------------

// ---------------- Combobox togglers ----------------

document.addEventListener('DOMContentLoaded', function (event) {
    document.addEventListener('click', interceptAll);
});

function interceptAll(event) {
    var combobox = document.getElementsByClassName('combobox')[0];

    if (combobox) {
        var target = event['target'];
        var other = false;

        if (target.getAttribute('class')) {
            if (target.getAttribute('class').indexOf('cbmain') != -1) {
                toggle();
            }
            else {
                other = true;
            }
        }
        else if (target.parentNode.getAttribute('class')) {
            if (target.parentNode.getAttribute('class').indexOf('cbtogglegroup') != -1) {
                var chosenValue = target.innerHTML;
                document.getElementsByClassName('cbmain')[0].innerHTML = chosenValue;
                var dl_link = target.getAttribute('dl_link');
                var dl_a = document.getElementsByClassName('dl_a')[0];
                dl_a.setAttribute('href', dl_link);
                toggle();
            }
            else {
                other = true;
            }
        }
        else {
            other = true;
        }

        if (other) {
            var cbtogglegroup = document.getElementsByClassName('cbtogglegroup')[0];
            cbtogglegroup.setAttribute('class', 'cbtogglegroup tg_toggledoff');
            document.getElementsByClassName('cbmain')[0].setAttribute('class', 'cbmain m_toggledoff');
        }
    }
}

function toggle() {
    var cbtogglegroup = document.getElementsByClassName('cbtogglegroup')[0];
    var toggleState = cbtogglegroup.getAttribute('class').split(' ')[1];

    if (toggleState == 'tg_toggledon') {
        cbtogglegroup.setAttribute('class', 'cbtogglegroup tg_toggledoff');
        document.getElementsByClassName('cbmain')[0].setAttribute('class', 'cbmain m_toggledoff');
    }
    else {
        cbtogglegroup.setAttribute('class', 'cbtogglegroup tg_toggledon');
        document.getElementsByClassName('cbmain')[0].setAttribute('class', 'cbmain m_toggledon');
    }
}

// ---------------- Combobox togglers ----------------

// ---------------- Helpers ----------------

function cleanPreviousSession() {
    var prevCombobox = document.getElementsByClassName('combobox')[0];
    var prevTitle = document.getElementsByClassName('dl_title')[0];
    var prevBtn = document.getElementsByClassName('dl_btn')[0];
    var prevA = document.getElementsByClassName('dl_a')[0];

    if (prevCombobox) {
        prevCombobox.parentNode.removeChild(prevCombobox);
        prevTitle.parentNode.removeChild(prevTitle);
        prevBtn.parentNode.removeChild(prevBtn);
        prevA.parentNode.removeChild(prevA);
    }
}

// ---------------- Helpers ----------------
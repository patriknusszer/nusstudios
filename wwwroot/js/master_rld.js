/* function modSelection() {
	var selected = document.getElementsByClassName('selected')[0]

	if (selected) {
		var oldsz = selected.offsetWidth
		var pseudoe = document.createElement('div')
		pseudoe.innerHTML = selected.innerHTML
		pseudoe.style.visibility = 'hidden'
		pseudoe.style.fontFamily = 'LatoWebMedium'
		pseudoe.style.position = 'absolute'
		document.getElementsByTagName("body")[0].appendChild(pseudoe)
		// reflow(pseudoe)

		var newsz = pseudoe.offsetWidth
		console.log(newsz)
		var szdiff = newsz - oldsz
		console.log(szdiff)
		var cstyle = window.getComputedStyle(selected)
		var ml = parseInt(cstyle.marginLeft.substring(0, cstyle.marginLeft.indexOf('px')))
		selected.style = 'margin-left: ' + (ml - szdiff) + 'px; font-family: LatoWebMedium;'
	}
} */

var bkg;

window.addEventListener('DOMContentLoaded', (event) => {
	// modSelection();
	bkg = document.getElementById('background');

	/* if (bkg && (/Android|iPhone|iPad|iPod|BlackBerry/).test(navigator.userAgent || navigator.vendor || window.opera)) {
		bkg.style.top = 'auto'
		bkg.style.bottom = '0px'
		window.onresize = resizeBkg()
	} */
});

function resizeBkg() {
	// bkg.style.height = screen.height
}

function getCookies() {
	if (!document.cookie)
		return null

	var dat = document.cookie.split(/\s*;\s*/)
	var cookies = new Object()

	for (var i = 0; i < dat.length(); i++) {
		var line = dat[i]
		var kvp = line.split('=')
		cookies[kvp[0]] = kvp[1];
	}

	return cookies
}

window.addEventListener('load', (event) => {
	//modSelection();

	var cookies = getCookies()

	if ('language' in cookies) {

	}
	else {
		
	}
});

var canRemove = false;

if (matchMedia) {
	var mq = window.matchMedia("(max-width: 770px)");
	mq.addListener(widthMobile);
	widthMobile(mq);
}

function getNavbar() {
	var navbar

	if (navbar = document.getElementById("navbar"))
		return navbar
	else
		return document.getElementById("navbarmenu")
}

function getPanel() {
	return document.getElementById("panel")
}

function widthMobile(mq) {
	if (mq.matches) {
		var navbar = getNavbar()
		canRemove = true

		if (!navbar) {
			document.addEventListener("DOMContentLoaded", function(event) { 
				navbar = getNavbar()
				addMenuMobile(navbar)
			});
		}
		else {
		    addMenuMobile(navbar)
		}
	}
	else if (canRemove) {
		removeMenuMobile()
	}
	else {
		// The site was just loaded in a wide Mac or PC device
	}

}

var menuOpenClick = true

function addMenuMobile(navbar) {
	var mobile_menu_btn = document.createElement('div')
	mobile_menu_btn.innerHTML = '='
	mobile_menu_btn.id = "mobile_menu_btn"

	mobile_menu_btn.onclick = function() {
		if (menuOpenClick) {
			menuOpenClick = false
			navbar.id = "navbarmenu"
			var mobile_menu = document.createElement('div')
			mobile_menu.id = "mobile_menu"
			var menu_text_block = document.createElement('div')
			menu_text_block.id = 'menu_text_block'
			var a = document.createElement('a')
			a.href = '/Home/Softwares'
			var p = document.createElement('p')
			p.innerHTML = 'Softwares'
			p.className = 'p_white'
			a.appendChild(p)
			menu_text_block.appendChild(a)
			a = document.createElement('a')
			a.href = '/Home/Blog'
			p = document.createElement('p')
			p.innerHTML = 'Blog'
			p.className = 'p_white'
			a.appendChild(p)
            menu_text_block.appendChild(a)
            a = document.createElement('a')
            a.href = '/Home/About'
            p = document.createElement('p')
            p.innerHTML = 'NussAPI'
            p.className = 'p_white'
            a.appendChild(p)
            menu_text_block.appendChild(a)
			a = document.createElement('a')
			a.href = '/Home/Edu'
			p = document.createElement('p')
			p.innerHTML = 'Magántanítás'
			p.className = 'p_white'
			a.appendChild(p)
			menu_text_block.appendChild(a)
			a = document.createElement('a')
			a.href = '/Home/Reference'
			p = document.createElement('p')
			p.innerHTML = 'Referenciáim'
			p.className = 'p_white'
			a.appendChild(p)
			menu_text_block.appendChild(a)
			a = document.createElement('a')
			a.href = '/Home/Contact'
			p = document.createElement('p')
			p.innerHTML = 'Contact'
			p.className = 'p_white'
			a.appendChild(p)
			menu_text_block.appendChild(a)
			menu_text_block.id = 'menu_text_block'
			var menu_block = document.createElement('div')
			menu_block.appendChild(menu_text_block)
			menu_block.id = 'menu_block'
            mobile_menu.appendChild(menu_block)
            var body = document.getElementsByTagName('body')[0]
            body.insertBefore(mobile_menu, getPanel())
            document.getElementsByTagName("html")[0].id = "htmlmenu"
			mobile_menu_btn.innerHTML = '×'
		}
		else {
			menuOpenClick = true
			navbar.id = "navbar"
			var mobile_menu = document.getElementById('mobile_menu')
			mobile_menu.parentNode.removeChild(mobile_menu)
			mobile_menu_btn.innerHTML = '='
			document.getElementsByTagName("html")[0].id = ""
		}
	}

	navbar.insertBefore(mobile_menu_btn, navbar.childNodes[0])
}

function removeMenuMobile() {
	var mobile_menu = document.getElementById('mobile_menu')

	if (mobile_menu) {
		menuOpenClick = true
		mobile_menu.parentNode.removeChild(mobile_menu)
	}

	var mobile_menu_btn = document.getElementById('mobile_menu_btn')
	mobile_menu_btn.parentNode.removeChild(mobile_menu_btn)
}

function hideInfo(elmnt) {
	var nfo = document.getElementById("nfo")
	nfo.parentNode.removeChild(nfo)
	var ptr = document.getElementById("ptr")
	ptr.parentNode.removeChild(ptr)
}

function showInfo(msg, elmnt) {
	var rect = getAbsRect(elmnt)
	var placeY = rect.top - 100
    var placeX = rect.left
    var width = elmnt.offsetWidth
		
	var nfo = document.createElement("div")
	var style = "position: absolute; "
	style += "width: " + 200 + "px; "
	style += "height: " + 80 + "px; "
	style += "top: " + placeY + "px; "
	style += "left: " + ((placeX - 100) + (width / 2)) + "px; "
	style += "background-color: #4080FF; "
	style += "border-radius: 7px; "
	style += "color: white; "
	style += "text-align: center; "
	style += "font-family: 'LatoWebLight'; "
	style += "font-size: 14px;"
	style += "line-height: " + 18 + "px; "
	nfo.setAttribute("style", style)
	nfo.className = "nfo"
	
	var valignable = document.createElement("span")
	valignable.style = "display: inline-block; vertical-align: middle; line-height: normal;"
	nfo.appendChild(valignable)
	valignable.innerHTML = msg
	var body = document.getElementsByTagName("body")[0]
	body.appendChild(nfo)
	
	var ptr = document.createElement("div")
	style = "position: absolute; "
	style += "border-style: solid; "
	style += "border-width: 15px 10px 0; "
	style += "border-color: #4080FF transparent;"
	style += "display: block; "
	style += "width: 0px; "
	style += "z-index: 1; "
	style += "top: " + (placeY + 80) + "px; "
	style += "left:" + (placeX + (width / 2) - 15) + "px;"
	ptr.setAttribute("style", style)
	ptr.className = "ptr"
	body.appendChild(ptr)
}

function getAbsRect(elmnt) {
	while (elmnt.offsetParent != null) {
		var top = 0, left = 0

	    do {
	        top += elmnt.offsetTop  || 0
	        left += elmnt.offsetLeft || 0
	        elmnt = elmnt.offsetParent
	    } while(elmnt)

	    return {
	        top: top,
	        left: left
	    };
	}
}
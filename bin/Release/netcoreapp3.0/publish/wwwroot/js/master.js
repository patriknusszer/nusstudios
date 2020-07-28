/* function modSelection() {
	var selected = document.getElementsByClassName('selected')[0];

	if (selected) {
		var oldsz = selected.offsetWidth;
		var pseudoe = document.createElement('div');
		pseudoe.innerHTML = selected.innerHTML;
		pseudoe.style.visibility = 'hidden';
		pseudoe.style.fontFamily = 'LatoWebMedium';
		pseudoe.style.position = 'absolute';
		document.getElementsByTagName("body")[0].appendChild(pseudoe);
		// reflow(pseudoe);

		var newsz = pseudoe.offsetWidth;
		console.log(newsz);
		var szdiff = newsz - oldsz;
		console.log(szdiff);
		var cstyle = window.getComputedStyle(selected);
		var ml = parseInt(cstyle.marginLeft.substring(0, cstyle.marginLeft.indexOf('px')));
		selected.style = 'margin-left: ' + (ml - szdiff) + 'px; font-family: LatoWebMedium;';
	}
} */

window.addEventListener('DOMContentLoaded', (event) => {
	// modSelection();
});

var canRemove = false;

if (matchMedia) {
	var mq = window.matchMedia("(max-width: 770px)");
	mq.addListener(widthMobile);
	widthMobile(mq);
}

function widthMobile(mq) {
	if (mq.matches) {
		var navbar = document.getElementsByClassName("navbar")[0];
		canRemove = true;

		if (!navbar) {
			document.addEventListener("DOMContentLoaded", function(event) { 
				navbar = document.getElementsByClassName("navbar")[0];
				addMenuMobile(navbar);
			});
		}
		else {
		    addMenuMobile(navbar);
		}
	}
	else if (canRemove) {
		removeMenuMobile();
	}
	else {
		// The site was just loaded in a wide Mac or PC device
	}

}

var menuOpenClick = true;

function getPanel() {
	return (panel = document.getElementsByClassName("panel")[0]) ;
}

function reflow(elt) {
    elt.offsetHeight;
}

function addMenuMobile(navbar) {
	var mobile_menu_btn = document.createElement('div');
	mobile_menu_btn.innerHTML = '=';
	mobile_menu_btn.className = "mobile_menu_btn";

	mobile_menu_btn.onclick = function() {
		if (menuOpenClick) {
			menuOpenClick = false;
			var mobile_menu = document.createElement('div');
			var menu_text_block = document.createElement('div');
			menu_text_block.className = 'menu_text_block';
			var a = document.createElement('a');
			a.href = '/Home/Softwares';
			var p = document.createElement('p');
			p.innerHTML = 'Softwares';
			p.className = 'p_white';
			a.appendChild(p);
			menu_text_block.appendChild(a);
			a = document.createElement('a');
			a.href = '/Home/Mods';
			p = document.createElement('p');
			p.innerHTML = 'Mods';
			p.className = 'p_white';
			a.appendChild(p);
			menu_text_block.appendChild(a);
			a = document.createElement('a');
			a.href = '/Home/Blog';
			p = document.createElement('p');
			p.innerHTML = 'Blog';
			p.className = 'p_white';
			a.appendChild(p);
            menu_text_block.appendChild(a);
            a = document.createElement('a');
            a.href = '/Home/NussAPI';
            p = document.createElement('p');
            p.innerHTML = 'NussAPI';
            p.className = 'p_white';
            a.appendChild(p);
            menu_text_block.appendChild(a);
			a = document.createElement('a');
			a.href = '/Home/Edu';
			p = document.createElement('p');
			p.innerHTML = 'Magántanítás';
			p.className = 'p_white';
			a.appendChild(p);
			menu_text_block.appendChild(a);
			a = document.createElement('a');
			a.href = '/Home/Contact';
			p = document.createElement('p');
			p.innerHTML = 'Contact';
			p.className = 'p_white';
			a.appendChild(p);
			menu_text_block.appendChild(a);
			menu_text_block.className = 'menu_text_block';
			var menu_block = document.createElement('div');
			menu_block.appendChild(menu_text_block);
			menu_block.className = 'menu_block';
            mobile_menu.appendChild(menu_block);
            var body = document.getElementsByTagName('body')[0];
            body.insertBefore(mobile_menu, getPanel());
			mobile_menu_btn.innerHTML = '×';
			// for reflow: window.getComputedStyle(mobile_menu).getPropertyValue("background-color");
			mobile_menu.className = "mobile_menu";
		}
		else {
			menuOpenClick = true;
			var mobile_menu = document.getElementsByClassName('mobile_menu')[0];
			mobile_menu.parentNode.removeChild(mobile_menu);
			mobile_menu_btn.innerHTML = '=';
			getPanel().className = "panel";
		}
	};

	navbar.insertBefore(mobile_menu_btn, navbar.childNodes[0]);
}

function removeMenuMobile() {
	var mobile_menu = document.getElementsByClassName('mobile_menu')[0];

	if (mobile_menu) {
		menuOpenClick = true;
		mobile_menu.parentNode.removeChild(mobile_menu);
	}

	var mobile_menu_btn = document.getElementsByClassName('mobile_menu_btn')[0];
	mobile_menu_btn.parentNode.removeChild(mobile_menu_btn);
}
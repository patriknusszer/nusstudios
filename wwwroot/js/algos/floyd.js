window.onresize = function() {
    init();
}

// animation below

var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var node = /** @class */ (function () {
    function node(rotation, chr, ctx, x, y, r, px, lineWidth) {
        this.x = x;
        this.y = y;
        this.ctx = ctx;
        this.r = r;
        this.px = px;
        this.lineWidth = lineWidth;
        this.rotation = rotation;
        this.drawNode(this.x, this.y, this.r, this.px, chr);
        this.chr = String.fromCharCode(chr.charCodeAt(0));
    }
    node.prototype.getprevlst = function () { return this.prevlst; };
    node.prototype.getprev = function () { return this.prev; };
    node.prototype.getnext = function () { return this.next; };
    node.prototype.getx = function () { return this.x; };
    node.prototype.gety = function () { return this.y; };
    node.prototype.getr = function () { return this.r; };
    node.prototype.getpx = function () { return this.px; };
    node.prototype.drawNode = function (x, y, r, px, str) {
        this.drawCircle(x, y, r);
        this.drawText(x - (7 * (this.r / 22)), y + (7 * (this.r / 22)), px, str);
    };
    node.prototype.drawLoop = function (epix, epiy, epir, px) {
        this.ctx.beginPath();
        this.ctx.arc(epix, epiy, epir, 0 * Math.PI, 2 * Math.PI);
        this.ctx.lineWidth = px;
        this.ctx.strokeStyle = "#9586bf";
        this.ctx.stroke();
    };
    node.prototype.drawC = function (r, fx, fy, tx, ty, px) {
        this.ctx.beginPath();
        this.ctx.strokeStyle = "#9586bf";
        this.ctx.lineWidth = px;
        if (!this.rotation) {
            this.ctx.moveTo(fx + r + this.lineWidth - 2, fy);
            this.ctx.lineTo(tx - r - (this.lineWidth - 2), ty);
        }
        else {
            this.ctx.moveTo(fx, fy + r + this.lineWidth - 2);
            this.ctx.lineTo(tx, ty - r - (this.lineWidth - 2));
        }
        this.ctx.stroke();
    };
    node.prototype.drawCircle = function (x, y, r) {
        this.ctx.beginPath();
        this.ctx.arc(x, y, r, 0 * Math.PI, 2 * Math.PI);
        this.ctx.closePath();
        this.ctx.fillStyle = "#28283c";
        this.ctx.fill();
        this.ctx.lineWidth = this.lineWidth;
        this.ctx.strokeStyle = "#9586bf";
        this.ctx.stroke();
    };
    node.prototype.drawText = function (x, y, px, str) {
        this.ctx.font = px + "px Consolas, Monaco, 'Andale Mono', 'Ubuntu Mono', monospace";
        this.ctx.fillStyle = "#ffc299";
        this.ctx.fillText(str, x, y);
    };
    node.prototype.drawNext = function (dx, dy) {
        var tox = this.x + dx;
        var toy = this.y + dy;
        this.drawC(this.r, this.x, this.y, tox, toy, 3);
        this.next = new node(this.rotation, String.fromCharCode(this.chr.charCodeAt(0) + 1), this.ctx, tox, toy, this.r, this.px, this.lineWidth);
        this.next.prev = this.next.prevlst = this;
        return this.next;
    };
    node.prototype.drawCycle = function (dx, dy, nodeNum, cycler) {
        var radius = cycler;
        var tox = this.x + dx;
        var toy = this.y + dy;
        this.drawC(this.r, this.x, this.y, tox, toy, 3);
        if (!this.rotation)
            this.drawLoop(tox + radius, toy, radius, 3);
        else
            this.drawLoop(tox, toy + radius, radius, 3);
        var nodes = new Array();
        var n = new cnode(this.rotation, String.fromCharCode(this.chr.charCodeAt(0) + 1), this.ctx, tox, toy, this.r, this.px, this.lineWidth);
        nodes.push(n);
        var entry = n;
        this.next = entry;
        entry.prev = entry.prevlst = this;
        var delta = Math.PI * 2 / nodeNum;
        var rad = Math.PI - delta;
        if (this.rotation)
            rad -= (Math.PI / 2);
        for (var i = 0; i < nodeNum - 1; i++) {
            var dx_1 = Math.cos(rad) * radius;
            var dy_1 = Math.sin(rad) * radius;
            if (!this.rotation)
                nodes.push(n.next = new cnode(this.rotation, String.fromCharCode(n.chr.charCodeAt(0) + 1), this.ctx, tox + radius + dx_1, toy - dy_1, this.r, this.px, this.lineWidth));
            else
                nodes.push(n.next = new cnode(this.rotation, String.fromCharCode(n.chr.charCodeAt(0) + 1), this.ctx, tox + dx_1, toy + radius - dy_1, this.r, this.px, this.lineWidth));
            n.next.prev = n;
            n.next.prevlst = n;
            n = n.next;
            rad -= delta;
        }
        n.next = entry;
        entry.prev = n;
        return nodes;
    };
    return node;
}());
var cnode = /** @class */ (function (_super) {
    __extends(cnode, _super);
    function cnode() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    cnode.prototype.set = function (radius, radians) {
        this.cr = radius;
        this.rad = radians;
    };
    cnode.prototype.getRadians = function () { return this.rad; };
    cnode.prototype.getRadius = function () { return this.cr; };
    return cnode;
}(node));
var creatures = /** @class */ (function () {
    function creatures(tx, ty, hx, hy, width, height, ctx, radius) {
        this.radius = radius;
        this.tx = tx;
        this.ty = ty;
        this.hx = hx;
        this.hy = hy;
        this.ctx = ctx;
        this.width = width;
        this.height = height;
        this.mem = this.ctx.getImageData(0, 0, this.width, this.height);
        this.tplace(this.tx, this.ty);
        this.hplace(this.hx, this.hy);
    }
    creatures.prototype.hplace = function (x, y) {
        this.ctx.beginPath();
        this.ctx.arc(x, y, this.radius, 0 * Math.PI, 2 * Math.PI);
        this.ctx.closePath();
        this.ctx.fillStyle = "#ff96b6";
        this.ctx.fill();
    };
    creatures.prototype.tplace = function (x, y) {
        this.ctx.beginPath();
        this.ctx.arc(x, y, this.radius, 0 * Math.PI, 2 * Math.PI);
        this.ctx.closePath();
        this.ctx.fillStyle = "#29c933";
        this.ctx.fill();
    };
    creatures.prototype.remove = function (x, y) {
        this.ctx.beginPath();
        this.ctx.arc(x, y, this.radius + 1, 0 * Math.PI, 2 * Math.PI);
        this.ctx.closePath();
        this.ctx.fillStyle = "#242434";
        this.ctx.fill();
        this.ctx.putImageData(this.mem, 0, 0);
    };
    creatures.prototype.rmove = function (turtle, hare, time, refreshrate, elapsed, callback) {
        var _this = this;
        setTimeout(function () {
            _this.remove(_this.tx, _this.ty);
            _this.remove(_this.hx, _this.hy);
            elapsed += refreshrate;
            var steps = time / refreshrate;
            var curStep = elapsed / refreshrate;
            var tto = turtle.getnextpos(curStep, steps);
            var hto = hare.getnextpos(curStep, steps);
            _this.tx = tto.getx();
            _this.ty = tto.gety();
            _this.hx = hto.getx();
            _this.hy = hto.gety();
            _this.tplace(_this.tx, _this.ty);
            _this.hplace(_this.hx, _this.hy);
            if (elapsed <= time)
                _this.rmove(turtle, hare, time, refreshrate, elapsed, callback);
            else {
                _this.remove(_this.tx, _this.ty);
                _this.remove(_this.hx, _this.hy);
                _this.tplace(_this.tx = turtle.gettox(), _this.ty = turtle.gettoy());
                _this.hplace(_this.hx = hare.gettox(), _this.hy = hare.gettoy());
                callback();
            }
        }, refreshrate);
    };
    creatures.prototype.move = function (turtle, hare, time, refreshrate, callback) {
        this.rmove(turtle, hare, time, refreshrate, 0, callback);
    };
    return creatures;
}());
var pos = /** @class */ (function () {
    function pos(x, y) {
        this.x = x;
        this.y = y;
    }
    pos.prototype.getx = function () { return this.x; };
    pos.prototype.gety = function () { return this.y; };
    return pos;
}());
var movedat = /** @class */ (function () {
    function movedat(x, y, tox, toy) {
        this.origpos = new pos(x, y);
        this.topos = new pos(tox, toy);
    }
    movedat.prototype.getorigx = function () { return this.origpos.getx(); };
    movedat.prototype.getorigy = function () { return this.origpos.gety(); };
    movedat.prototype.gettox = function () { return this.topos.getx(); };
    movedat.prototype.gettoy = function () { return this.topos.gety(); };
    return movedat;
}());
var linearmovedat = /** @class */ (function (_super) {
    __extends(linearmovedat, _super);
    function linearmovedat(x, y, tox, toy) {
        return _super.call(this, x, y, tox, toy) || this;
    }
    linearmovedat.prototype.getnextpos = function (step, outOfSteps) {
        var xdisplace = this.topos.getx() - this.origpos.getx();
        var ydisplace = this.topos.gety() - this.origpos.gety();
        var xdelta = xdisplace / outOfSteps;
        var ydelta = ydisplace / outOfSteps;
        return new pos(this.origpos.getx() + xdelta * step, this.origpos.gety() + ydelta * step);
    };
    return linearmovedat;
}(movedat));
var arcmovedat = /** @class */ (function (_super) {
    __extends(arcmovedat, _super);
    function arcmovedat(x, y, tox, toy, epix, epiy, radius) {
        var _this = _super.call(this, x, y, tox, toy) || this;
        _this.epipos = new pos(epix, epiy);
        _this.radius = radius;
        return _this;
    }
    arcmovedat.prototype.getnextpos = function (step, outOfSteps) {
        var origAngle;
        var toAngle;
        if ((this.origpos.gety() == this.epipos.gety() && this.origpos.getx() > this.epipos.getx()) || this.origpos.gety() > this.epipos.gety())
            origAngle = Math.acos((this.origpos.getx() - this.epipos.getx()) / this.radius) + Math.PI;
        else
            origAngle = Math.acos((this.epipos.getx() - this.origpos.getx()) / this.radius);
        if ((this.topos.gety() == this.epipos.gety() && this.topos.getx() > this.epipos.getx()) || this.topos.gety() > this.epipos.gety())
            toAngle = Math.acos((this.topos.getx() - this.epipos.getx()) / this.radius) + Math.PI;
        else
            toAngle = Math.acos((this.epipos.getx() - this.topos.getx()) / this.radius);
        if (toAngle < origAngle)
            toAngle += Math.PI * 2;
        var angleDisplace = toAngle - origAngle;
        var angleDelta = angleDisplace / outOfSteps;
        var curAngle = origAngle + (angleDelta * step);
        var rely = Math.sin(curAngle) * this.radius;
        var relx = Math.cos(curAngle) * this.radius;
        return new pos(this.epipos.getx() - relx, this.epipos.gety() - rely);
    };
    return arcmovedat;
}(movedat));
var Animator = /** @class */ (function () {
    function Animator(rotation, time, refresh, initx, inity, ctx, width, height, tail, cycle, noder, nodedist, nodepx, nodeborder, cycler, creaturesr) {
        var _this = this;
        this.terminateFlag = false;
        this.width = width;
        this.height = height;
        this.tail = tail;
        this.cycle = cycle;
        this.noder = noder;
        this.cycler = cycler;
        this.nodepx = nodepx;
        this.nodedist = nodedist;
        this.ctx = ctx;
        this.initx = initx;
        this.inity = inity;
        this.time = time;
        this.refresh = refresh;
        this.creaturesr = creaturesr;
        this.nodeborder = nodeborder;
        this.rotation = rotation;
        var list = this.drawList();
        if (!this.terminateFlag) {
            this.snapshot = this.ctx.getImageData(0, 0, this.width, this.height);
            setTimeout(function () {
                _this.makeMeet1(list);
            }, 800);
        }
        else
            this.terminateCallback();
    }
    Animator.prototype.terminate = function (callback) {
        this.terminateCallback = callback;
        this.terminateFlag = true;
    };
    Animator.prototype.drawList = function () {
        var nodes = Array();
        var n = new node(this.rotation, 'A', this.ctx, this.initx, this.inity, this.noder, this.nodepx, this.nodeborder);
        nodes.push(n);
        for (var i = 0; i < this.tail - 2; i++) {
            if (!this.rotation)
                nodes.push(n = n.drawNext(this.nodedist, 0));
            else
                nodes.push(n = n.drawNext(0, this.nodedist));
        }
        if (!this.rotation)
            this.cyclepos = new pos(nodes[nodes.length - 1].getx() + this.nodedist + this.cycler, nodes[nodes.length - 1].gety());
        else
            this.cyclepos = new pos(nodes[nodes.length - 1].getx(), nodes[nodes.length - 1].gety() + this.nodedist + this.cycler);
        if (!this.rotation)
            nodes = nodes.concat(nodes[nodes.length - 1].drawCycle(this.nodedist, 0, this.cycle, this.cycler));
        else
            nodes = nodes.concat(nodes[nodes.length - 1].drawCycle(0, this.nodedist, this.cycle, this.cycler));
        return nodes;
    };
    Animator.prototype.makeMeet1 = function (list) {
        var _this = this;
        var tindex = 1, hindex = 2;
        var prevt = list[0];
        var prevh = list[0];
        var t = list[tindex];
        var h = list[hindex];
        var crs = new creatures(prevt.getx(), prevt.gety(), prevt.getx(), prevt.gety(), this.width, this.height, this.ctx, this.creaturesr);
        var callback = function () {
            if (!_this.terminateFlag) {
                if (t != h) {
                    prevt = t;
                    prevh = h;
                    t = t.getnext();
                    h = h.getnext().getnext();
                    setTimeout(function () {
                        var tmover;
                        var hmover;
                        if (!(prevh instanceof cnode) && h instanceof cnode && prevh.getnext() instanceof cnode) {
                            tmover = new linearmovedat(prevt.getx(), prevt.gety(), prevt.getx() + ((t.getx() - prevt.getx()) / 2), prevt.gety() + ((t.gety() - prevt.gety()) / 2));
                            hmover = new linearmovedat(prevh.getx(), prevh.gety(), prevh.getnext().getx(), prevh.getnext().gety());
                            crs.move(tmover, hmover, _this.time / 2, _this.refresh, function () {
                                tmover = new linearmovedat(prevt.getx() + ((t.getx() - prevt.getx()) / 2), prevt.gety() + ((t.gety() - prevt.gety()) / 2), t.getx(), t.gety());
                                hmover = new arcmovedat(prevh.getnext().getx(), prevh.getnext().gety(), h.getx(), h.gety(), _this.cyclepos.getx(), _this.cyclepos.gety(), _this.cycler);
                                crs.move(tmover, hmover, _this.time / 2, _this.refresh, callback);
                            });
                        }
                        else {
                            if (prevt instanceof cnode && t instanceof cnode)
                                tmover = new arcmovedat(prevt.getx(), prevt.gety(), t.getx(), t.gety(), _this.cyclepos.getx(), _this.cyclepos.gety(), _this.cycler);
                            else
                                tmover = new linearmovedat(prevt.getx(), prevt.gety(), t.getx(), t.gety());
                            if (prevh instanceof cnode && h instanceof cnode)
                                hmover = new arcmovedat(prevh.getx(), prevh.gety(), h.getx(), h.gety(), _this.cyclepos.getx(), _this.cyclepos.gety(), _this.cycler);
                            else
                                hmover = new linearmovedat(prevh.getx(), prevh.gety(), h.getx(), h.gety());
                            crs.move(tmover, hmover, _this.time, _this.refresh, callback);
                        }
                    }, 120);
                }
                else
                    setTimeout(function () { return _this.makeMeet2(list, t); }, 500);
            }
            else
                _this.terminateCallback();
        };
        var tmover;
        var hmover;
        if (prevt instanceof cnode && t instanceof cnode)
            tmover = new arcmovedat(prevt.getx(), prevt.gety(), t.getx(), t.gety(), this.cyclepos.getx(), this.cyclepos.gety(), this.cycler);
        else
            tmover = new linearmovedat(prevt.getx(), t.getprev().gety(), t.getx(), t.gety());
        if (prevh instanceof cnode && h instanceof cnode)
            hmover = new arcmovedat(prevh.getx(), prevh.gety(), h.getx(), h.gety(), this.cyclepos.getx(), this.cyclepos.gety(), this.cycler);
        else
            hmover = new linearmovedat(prevh.getx(), prevh.gety(), h.getx(), h.gety());
        crs.move(tmover, hmover, this.time, this.refresh, callback);
    };
    Animator.prototype.makeMeet2 = function (list, t) {
        var _this = this;
        this.ctx.putImageData(this.snapshot, 0, 0);
        var prevt = t;
        var prevh = list[0];
        var h = list[1];
        var t = t.getnext();
        var crs = new creatures(t.getprev().getx(), t.getprev().gety(), h.getprev().getx(), h.getprev().gety(), this.width, this.height, this.ctx, this.creaturesr);
        var callback = function () {
            if (!_this.terminateFlag) {
                if (t != h) {
                    prevt = t;
                    prevh = h;
                    t = t.getnext();
                    h = h.getnext();
                    setTimeout(function () {
                        var tmover;
                        var hmover;
                        if (prevt instanceof cnode && t instanceof cnode)
                            tmover = new arcmovedat(prevt.getx(), prevt.gety(), t.getx(), t.gety(), _this.cyclepos.getx(), _this.cyclepos.gety(), _this.cycler);
                        else
                            tmover = new linearmovedat(prevt.getx(), prevt.gety(), t.getx(), t.gety());
                        if (prevh instanceof cnode && h instanceof cnode)
                            hmover = new arcmovedat(prevh.getx(), prevh.gety(), h.getx(), h.gety(), _this.cyclepos.getx(), _this.cyclepos.gety(), _this.cycler);
                        else
                            hmover = new linearmovedat(prevh.getx(), prevh.gety(), h.getx(), h.gety());
                        crs.move(tmover, hmover, _this.time, _this.refresh, callback);
                    }, 120);
                }
                else {
                    setTimeout(function () {
                        _this.ctx.putImageData(_this.snapshot, 0, 0);
                        _this.makeMeet1(list);
                    }, 100);
                }
            }
            else
                _this.terminateCallback();
        };
        var tmover;
        var hmover;
        if (prevt instanceof cnode && t instanceof cnode)
            tmover = new arcmovedat(prevt.getx(), prevt.gety(), t.getx(), t.gety(), this.cyclepos.getx(), this.cyclepos.gety(), this.cycler);
        else
            tmover = new linearmovedat(prevt.getx(), t.getprev().gety(), t.getx(), t.gety());
        if (prevh instanceof cnode && h instanceof cnode)
            hmover = new arcmovedat(prevh.getx(), prevh.gety(), h.getx(), h.gety(), this.cyclepos.getx(), this.cyclepos.gety(), this.cycler);
        else
            hmover = new linearmovedat(prevh.getx(), prevh.gety(), h.getx(), h.gety());
        crs.move(tmover, hmover, this.time, this.refresh, callback);
    };
    return Animator;
}());
function isNormalInteger(str) {
    var n = Math.floor(Number(str));
    return n !== Infinity && String(n) === str && n >= 0;
}
function isBoolean(str) {
    return str == 'true' || str == 'false' || str == 'True' || str == 'False';
}
var PIXEL_RATIO = (function () {
    var ctx = document.createElement("canvas").getContext("2d"),
        dpr = window.devicePixelRatio || 1,
        bsr = ctx.webkitBackingStorePixelRatio ||
              ctx.mozBackingStorePixelRatio ||
              ctx.msBackingStorePixelRatio ||
              ctx.oBackingStorePixelRatio ||
              ctx.backingStorePixelRatio || 1;

    return dpr / bsr;
})();
var width;
var height = 750;
var animator;
var initx;
function algo(ctx) {
    // var dpi = window.devicePixelRatio;
    var canvas = document.getElementById('floyd');
    canvas.setAttribute('width', (width = +window.getComputedStyle(document.getElementsByTagName('article')[0]).getPropertyValue('width').slice(0, -2)) * PIXEL_RATIO);
    canvas.setAttribute('height', (height = 750) * PIXEL_RATIO);
    canvas.style.width = width + 'px';
    canvas.style.height = height + 'px';
    (ctx = canvas.getContext('2d')).setTransform(PIXEL_RATIO, 0, 0, PIXEL_RATIO, 0, 0);
    // width = document.getElementById('floyd').width = Number(window.getComputedStyle(document.getElementsByTagName('article')[0], null).getPropertyValue('width').split('px')[0]);
    var cycler = 100;
    initx = 150;
    var inity = 260;
    var time = 50;
    var refresh = 1;
    var nodedist = 25;
    var noder = 10;
    var nodepx = 12;
    var cycle = 6;
    var tail = 15;
    var creaturesr = 6;
    var nodeborder = 2;
    var vertical = (width / 750) < 1;
    if (!vertical && width >= 1400) {
        nodeborder = 4;
        noder = 22;
        nodedist = 70;
        nodepx = 18;
        initx = 150;
        creaturesr = 10;
        tail = 10;
    }
    if (vertical) {
        initx = width / 2; // 190
        inity = 50;
    }
    var input;
    if ((input = document.getElementById("tail")).value && input.value.length > 0 && isNormalInteger(input.value))
        tail = Number(input.value);
    if ((input = document.getElementById("cycle")).value && input.value.length > 0 && isNormalInteger(input.value))
        cycle = Number(input.value);
    if ((input = document.getElementById("move")).value && input.value.length > 0 && isNormalInteger(input.value))
        time = Number(input.value);
    /* if ((input = <HTMLInputElement>document.getElementById("horisontal")).value && isBoolean(input.value))
        vertical = !(input.value == 'true' || input.value == 'True')
    if ((input = <HTMLInputElement>document.getElementById("refreshrate")).value && input.value.length > 0 && isNormalInteger(input.value))
        refresh = Number(input.value)
    if ((input = <HTMLInputElement>document.getElementById("noder")).value && input.value.length > 0 && isNormalInteger(input.value))
        noder = Number(input.value)
    if ((input = <HTMLInputElement>document.getElementById("cycler")).value && input.value.length > 0 && isNormalInteger(input.value))
        cycler = Number(input.value)
    if ((input = <HTMLInputElement>document.getElementById("nodedist")).value && input.value.length > 0 && isNormalInteger(input.value))
        nodedist = Number(input.value)
    if ((input = <HTMLInputElement>document.getElementById("nodeborder")).value && input.value.length > 0 && isNormalInteger(input.value))
        nodeborder = Number(input.value)
    if ((input = <HTMLInputElement>document.getElementById("nodepx")).value && input.value.length > 0 && isNormalInteger(input.value))
        nodepx = Number(input.value)
    if ((input = <HTMLInputElement>document.getElementById("initx")).value && input.value.length > 0 && isNormalInteger(input.value))
        initx = Number(input.value)
    if ((input = <HTMLInputElement>document.getElementById("inity")).value && input.value.length > 0 && isNormalInteger(input.value))
        inity = Number(input.value) */
    if (cycle > 10)
        cycler *= (cycle / 20);
    animator = new Animator(vertical, time / PIXEL_RATIO, refresh, initx, inity, ctx, width * PIXEL_RATIO, height * PIXEL_RATIO, tail, cycle, noder, nodedist, nodepx, nodeborder, cycler, creaturesr);
}
function init() {
    var cb = function () {
        var floyd = document.getElementById('floyd');
        var ctx = floyd.getContext("2d");
        ctx.clearRect(0, 0, width, height);
        algo(ctx);
    };
    if (animator)
        animator.terminate(cb);
    else
        cb();
}
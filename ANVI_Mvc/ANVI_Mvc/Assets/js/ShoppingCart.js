
var nb = parseInt($("#UnitPrice").attr('value'));
var tnb = nb;
var add = document.getElementById("add");
var cut = document.getElementById("cut");
var price = document.getElementById("pc");
var count = parseInt(document.getElementById("count").getAttribute("value"));
var pickNumber = 1;
//var cutValue = document.getElementById("cutValue").getAttribute("value");
var cutValue = $("#cutValue");
add.onclick = doAdd;
cut.onclick = doCut;
function doAdd() {
    // var cv = cutvalue++;  
    if (count-pickNumber > 0) {
        pickNumber++;
        cutValue.val(parseInt(cutValue.val()) + 1);
        tnb = nb * parseInt(cutValue.val());
        // cutValue.innerText = cv;        
        document.getElementById("up").innerText = "$" + formatMoney(tnb) + "TWD";
        cutValue.text(cutValue.val());
    }
}
function doCut() {
    // var cv = cutvalue++;  
    if (count - pickNumber < count-1) {
        pickNumber--;
        cutValue.val(parseInt(cutValue.val()) - 1);
        tnb = nb * parseInt(cutValue.val());
        // cutValue.innerText = cv;        
        document.getElementById("up").innerText = "$" + formatMoney(tnb) + "TWD";
        cutValue.text(cutValue.val());
    }
}

function formatMoney(n, c, d, t) {
    var c = isNaN(c = Math.abs(c)) ? 2 : c,
        d = d == undefined ? "." : d,
        t = t == undefined ? "," : t,
        s = n < 0 ? "-" : "",
        i = String(parseInt(n = Math.abs(Number(n) || 0).toFixed(c))),
        j = (j = i.length) > 3 ? j % 3 : 0;

    return s + (j ? i.substr(0, j) + t : "") + i.toString("##,###") + (c ? d + Math.abs(n - i).toFixed(c).slice(2) : "");
};


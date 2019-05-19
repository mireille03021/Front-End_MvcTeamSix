//console.log("A");

/*運送、退貨*/
var Collapsible_Btn_OC = document.getElementsByClassName("Collapsible-Btn");
for (var i = 0; i < Collapsible_Btn_OC.length; i++) {
    Collapsible_Btn_OC[i].onclick = Collapsible_Btn_TF;
}
function Collapsible_Btn_TF() {

    //console.log(this);
    var x = this.getAttribute("aria-expanded");
    if (x == "true") {
        //console.log("T")
        x = "false";
        this.nextElementSibling.style.overflow = "hidden";
        this.nextElementSibling.style.height = "0px";
    } else {
        //console.log("F")
        x = "true";
        //console.log(this.nextElementSibling);
        this.nextElementSibling.style.overflow = "visible";
        //console.log(this);
        this.nextElementSibling.style.height = "auto";
    }
    this.setAttribute("aria-expanded", x);
}

/*跳轉位置*/
/* function is_flipped() {
    console.log("B");
    var x = document.getElementById("jump").getAttribute("class");
    if (x == "P-QuickNav hid-pock") {
        x = "P-QuickNav hid-pock is-flipped";
        console.log("c");
    } else {
        x = "P-QuickNav hid-pock";
        console.log("d");
    }
    document.getElementById("jump").setAttribute("class", x);
} */

/*價錢、規格  尺寸選擇*/
var option_1 = document.getElementsByName("option-1");

for (var i = 0; i < option_1.length; i++) {
    option_1[i].onclick = PF_Invt_text;
    if (option_1[i].checked == true) {
        //console.log("SSS");
        PF_Invt_text();
    }
}

function PF_Invt_text() {
    //console.log(this);

    var pdsetnum;
    var stocknum;

    var addcartext = "<span>Add to cart</span>" + "<span class='Btn-SepDot'>.</span>" + "<span>$900 TWD</span>";

    if (this == window) {
        pdsetnum = option_1[0].value;
        //console.log("d");
    }
    else {
        pdsetnum = this.value;
    }

    if (pdsetnum == "5") {
        stocknum = 2;
    }
    else if (pdsetnum == "6") {
        stocknum = 4;
    }
    else if (pdsetnum == "7") {
        stocknum = 0;
    }

    if (stocknum == 0) {
        document.getElementsByClassName("PF-O")[2].style.display = "none";  /*消失*/
        //console.log(document.getElementsByClassName("PF-O")[2]);
        document.getElementsByClassName("S-pay-Btn")[0].style.display = "none";
        document.getElementsByClassName("PF-AddToCart")[0].setAttribute("disabled", "disabled");
        document.getElementsByClassName("PF-AddToCart")[0].innerHTML = "Sold Out";
    }
    else {
        document.getElementsByClassName("PF-AddToCart")[0].innerHTML = addcartext;
        document.getElementsByClassName("S-pay-Btn")[0].style = "";
        document.getElementsByClassName("PF-O")[2].style = "";
    }
    //console.log(document.getElementsByClassName("S-pay-Btn")[0]);
    document.getElementsByClassName("PF-Invt")[0].innerHTML = "Only " + stocknum + " pieces in stock!";
}
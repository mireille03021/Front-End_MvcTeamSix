var cell;
var cells = [];
var getLength = document.getElementsByClassName('Grid__Cell');
for(var i = 1; i <= getLength.length; i++) {
    cell = document.getElementById("i" + i);
    cells.push(cell);
}
$(document).ready(function () {
    /* Every time the window is scrolled ... */
    $(window).scroll(function () {       //.scroll()对元素滚动的次数进行计数
        /* Check the location of each desired element */
        $('.animated-block').each(function (i) {    //.animated-block是自創class，所以只要把想要用這動畫效果的元素加上這class就會有下拉才出現的動畫
            var bottom_of_object = $(this).offset().top + $(this).outerHeight();  //.offset()获得元素当前的偏移; .outerHeight()返回 this 元素的外部高度：
            var bottom_of_window = $(window).scrollTop() + $(window).height();    //.scrollTop()设置 window 元素中滚动条的垂直偏移：
            // var cell = document.getElementsByClassName('Grid__Cell');
            // var getLength = cell.length;
            /* If the object is completely visible in the window, fade it it */
            if (bottom_of_window = bottom_of_object) {
                // $(this).addClass("fadeInUp").addClass("animated");
                // for(var j = 0; j > getLength.length ; j++) {
                //     $($('.Grid__Cell')[j]).addClass("fadeInUp").addClass("animated");
                // }
                for(var j = 1; j < cells.length ; j++) {
                    $('#i'+ j).addClass("fadeInUp").addClass("animated");
                }
                          
            }
        });
    });
});
// $(".S1").click(function(){
//     var obj = document.getElementById("change");
//     var imgSrc = obj.src;//能获取到
//     imgSrc = obj.setAttribute("src", tSrc);
// });
// var newNum = document.getElementsByClassName("Cl") 

// for(var i = 0; i <newNum.length; i++) {
//         newNum[i].onclick = getNum;
//     }
// function getNum(){
//     $(".Cl ").click(function(){
//         $(".change").attr("src", "image/2.jpeg")
//     })
//     $(".Cl").click(function(){
//         $(".change").attr("src", "image/3.jpg")
//     })
//     $(".Cl").click(function(){
//         $(".change").attr("src", "image/4.jpg")
//     })
// }

    $(".Cl").click(function(){
    var imgsrc = $(this).attr("src");
    var cont = $(this).attr("value");
    console.log(this);
    console.log(imgsrc);
    console.log(cont);
    if(cont == 1){
        $("#change").attr("src", imgsrc);
    }
    if(cont == 2){
        $("#change").attr("src", imgsrc);
    }
    if(cont == 3){
        $("#change").attr("src", imgsrc);
    }
    
});



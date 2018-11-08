var btnEmptyGlass = document.getElementById("makeGlasEmpty");
btnEmptyGlass.addEventListener("click", ShowEmpty)

var myImage = document.getElementById("myGlas");

function ShowEmpty()
{
    myImage.src = "imagesÖl/tom.jpg";
}

function ShowFull()
{
    myImage.src = "imagesÖl/full.jpg";
}
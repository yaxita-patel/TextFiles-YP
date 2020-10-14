$(document).ready(function(){
//var result = "";
FileClick();

})

function FileClick(){
    var path = window.location.pathname;
    var fileNamePart = path.substr(path.lastIndexOf('/') + 1);
    return fileNamePart;
}
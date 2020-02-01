"use strict";
var PrintMedia;
(function (PrintMedia) {
    PrintMedia[PrintMedia["NewsPaper"] = 1] = "NewsPaper";
    PrintMedia[PrintMedia["Newsletter"] = 2] = "Newsletter";
    PrintMedia[PrintMedia["Magazine"] = 3] = "Magazine";
    PrintMedia[PrintMedia["Book"] = 4] = "Book";
})(PrintMedia || (PrintMedia = {}));
function getMedia(mediaName) {
    if (mediaName == 'Forbes' || mediaName == 'outlook') {
        return PrintMedia.Magazine;
    }
    return PrintMedia.Newsletter;
}
var mediaType = getMedia('Forbes');
console.log(mediaType);

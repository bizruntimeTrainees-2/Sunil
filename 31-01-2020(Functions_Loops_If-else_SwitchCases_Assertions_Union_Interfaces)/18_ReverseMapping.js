"use strict";
var printMedia;
(function (printMedia) {
    printMedia[printMedia["NewsPaper"] = 1] = "NewsPaper";
    printMedia[printMedia["Newsletter"] = 2] = "Newsletter";
    printMedia[printMedia["Magazine"] = 3] = "Magazine";
    printMedia[printMedia["Book"] = 4] = "Book";
})(printMedia || (printMedia = {}));
console.log(printMedia.Magazine);
console.log(printMedia['Magazine']);
console.log(printMedia[3]);
console.log(printMedia);

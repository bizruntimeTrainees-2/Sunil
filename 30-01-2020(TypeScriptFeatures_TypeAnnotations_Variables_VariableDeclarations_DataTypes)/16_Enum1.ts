enum PrintMedia {
    NewsPaper = 1,
    Newsletter,
    Magazine,
    Book
}

function getMedia(mediaName: string): PrintMedia{
    if(mediaName == 'Forbes' || mediaName == 'outlook'){
        return PrintMedia.Magazine
    }
        return PrintMedia.Newsletter;
}

let mediaType: PrintMedia = getMedia('Forbes');
console.log(mediaType);

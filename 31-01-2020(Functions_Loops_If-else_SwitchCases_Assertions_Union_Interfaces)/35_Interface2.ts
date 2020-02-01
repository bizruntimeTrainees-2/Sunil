interface keyValueProcessor{
    (key: number, value: string): void;
};

function addKeyValue(key: number, value: string): void{
    console.log("addKeyvalue: key " + key + " value " + value);
    
}

function updateKeyValue(key: number, value: string): void{
    console.log("updateKeyValue: key "+ key + " value " + value);
    
}

let kvp: keyValueProcessor = addKeyValue;
kvp(1, "ravi");

kvp = updateKeyValue;
kvp(2, "erron");
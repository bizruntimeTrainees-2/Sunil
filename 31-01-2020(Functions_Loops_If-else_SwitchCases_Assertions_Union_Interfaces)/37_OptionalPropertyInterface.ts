interface Citizen{
    name : String;
    readonly SSN: number;
}
let personObj: Citizen = {SSN: 110555444, name: "James Bond"};

personObj.name = 'rool';
//personObj.SSN = 1256478;
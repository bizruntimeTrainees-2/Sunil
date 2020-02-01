class Car{
    name: string;

    constructor(Name:string){
        this.name = Name;
    }
    run(speed: number= 0){
        console.log("A " + this.name + " is moving at " + speed + "mph!");
        
    }
}
class Mercedes extends Car{
    constructor(name: string){
        super(name);
    }
    run(speed = 150){
        console.log("Mercedes Started");
        super.run(speed);
    }
}
class Honda extends Car{
    constructor(name: string){
        super(name);
    }
    run(speed = 100){
        console.log("Honda Started");
        super.run(speed);
    }
}
let mercObj = new Mercedes("Mercedes-Benz GLA");
let hondaObj = new Honda("Honda City")

mercObj.run(); 
hondaObj.run();
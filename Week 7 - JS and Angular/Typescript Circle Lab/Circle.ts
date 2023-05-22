class Circle {
    radius: number; 

    constructor(radius: number){
        this.radius = radius;
    }
    //What is the difference between a method and a function?
    //1) functions exist independent of classes 
    //2) methods exist only within classes 
    CalcDiameter():number{
        return this.radius *2;
    }

    getCircumfernce() : number{
        return this.CalcDiameter() * Math.PI;
    }

    getArea():number{
        return Math.PI * this.radius * this.radius;
    }

    grow() : void{
        this.radius *= 2;
        document.getElementById("Input").value = this.radius;
        CircleInfo();
    }
}
let c : Circle = new Circle(1);

function CircleInfo(){
    let rad = document.getElementById("Input").value;

    c = new Circle(rad);

    document.getElementById("Output").innerHTML =`<p> Radius: ${c.radius}`;
    document.getElementById("Output").innerHTML +=`<p> Area: ${c.getArea()}`;
    document.getElementById("Ouput")?.innerHTML += `<p> Circumference: ${c.getCircumfernce} </p>`;
    document.getElementById("Output")?.innerHTML += `<p> Diameter: ${c.CalcDiameter()} </p>`;


}
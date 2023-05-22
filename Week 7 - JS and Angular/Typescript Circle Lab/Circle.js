var Circle = /** @class */ (function () {
    function Circle(radius) {
        this.radius = radius;
    }
    //What is the difference between a method and a function?
    //1) functions exist independent of classes 
    //2) methods exist only within classes 
    Circle.prototype.CalcDiameter = function () {
        return this.radius * 2;
    };
    Circle.prototype.getCircumfernce = function () {
        return this.CalcDiameter() * Math.PI;
    };
    Circle.prototype.getArea = function () {
        return Math.PI * this.radius * this.radius;
    };
    Circle.prototype.grow = function () {
        this.radius *= 2;
        document.getElementById("Input").value = this.radius;
        CircleInfo();
    };
    return Circle;
}());
var c = new Circle(1);
function CircleInfo() {
    var _a, _b;
    var rad = document.getElementById("Input").value;
    c = new Circle(rad);
    document.getElementById("Output").innerHTML = "<p> Radius: ".concat(c.radius);
    document.getElementById("Output").innerHTML += "<p> Area: ".concat(c.getArea());
    (_a = document.getElementById("Ouput")) === null || _a === void 0 ? void 0 : _a.innerHTML += "<p> Circumference: ".concat(c.getCircumfernce, " </p>");
    (_b = document.getElementById("Output")) === null || _b === void 0 ? void 0 : _b.innerHTML += "<p> Diameter: ".concat(c.CalcDiameter(), " </p>");
}

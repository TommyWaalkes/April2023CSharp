// name
// height
// Kilimanjaro
// 19341
// Everest
// 29029
// Denali
// 20310
var mountains = [];
var m1 = { name: "Kilamanjaro", height: 30000 };
mountains.push(m1);
var m2 = { name: "Everest", height: 29029 };
mountains.push(m2);
var m3 = { name: "Denali", height: 20310 };
mountains.push(m3);
function findTallestMountain(mountains) {
    var index = -1;
    var tallestHeight = 0;
    for (var i = 0; i < mountains.length; i++) {
        var m = mountains[i];
        if (m.height > tallestHeight) {
            index = i;
            tallestHeight = m.height;
        }
    }
    return mountains[index];
}
var tallest = findTallestMountain(mountains);
console.log(tallest);
document.getElementById("Tallest").innerText = "Tallest Name:  ".concat(tallest.name, ", Tallest Height: ").concat(tallest.height, " ");
var products = [];
var p1 = { name: "Back scratcher", price: 19.99 };
products.push(p1);
var p2 = { name: "Grabber Claw", price: 39.99 };
products.push(p2);
var p3 = { name: "Soda", price: 4.99 };
products.push(p3);
function findAveragePrice(products) {
    var total = 0;
    for (var i = 0; i < products.length; i++) {
        total += products[i].price;
    }
    return Math.round(total / products.length * 100) / 100;
}
var avg = findAveragePrice(products);
console.log(avg);
document.getElementById("AveragePrice").innerText = "Average Price: $".concat(avg);
// product.name
// product.price
// quantity
// motor
// 10.00
// 10
// sensor
// 12.50
// 4
// LED
// 1.00
// 20
var items = [];
var prod1 = { name: "Motor", price: 10 };
var i1 = { product: prod1, quantity: 10 };
items.push(i1);
var prod2 = { name: "Sensor", price: 12.50 };
var i2 = { product: prod2, quantity: 4 };
items.push(i2);
var prod3 = { name: "LED", price: 1.00 };
var i3 = { product: prod3, quantity: 20 };
items.push(i3);
console.log(i1);
function FindTotalCost(items) {
    var total = 0;
    for (var i = 0; i < items.length; i++) {
        total += items[i].product.price * items[i].quantity;
        console.log(total);
    }
    return total;
}
var total = FindTotalCost(items);
console.log(total);
document.getElementById("TotalInventory").innerText = "Total Price of Inventory: ".concat(total, " ");

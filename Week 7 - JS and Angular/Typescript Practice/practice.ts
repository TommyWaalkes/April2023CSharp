interface Mountain{
    name:string, 
    height:number
}
// name
// height
// Kilimanjaro
// 19341
// Everest
// 29029
// Denali
// 20310


let mountains: Mountain[] = []; 

let m1:Mountain = {name:"Kilamanjaro", height: 30000}; 
mountains.push( m1);

let m2: Mountain = {name: "Everest", height: 29029}; 
mountains.push(m2);

let m3: Mountain = {name:"Denali", height:20310}
mountains.push(m3); 

function findTallestMountain(mountains: Mountain[]) :Mountain{

    let index: number = -1; 
    let tallestHeight: number = 0; 
    for(let i = 0; i < mountains.length; i++){
        let m: Mountain = mountains[i]; 

        if(m.height > tallestHeight) {
            index = i; 
            tallestHeight = m.height;
        }
    }

    return mountains[index];

}

let tallest:Mountain = findTallestMountain(mountains);

console.log(tallest);

document.getElementById("Tallest").innerText = `Tallest Name:  ${tallest.name}, Tallest Height: ${tallest.height} `;

//-----------------------------------------------------------------------------------------------------------------

interface Product{ 
    name:string, 
    price:number
}

let products: Product[] = []; 

let p1: Product = {name:"Back scratcher", price:19.99};
products.push(p1); 

let p2: Product = {name: "Grabber Claw", price:39.99}; 
products.push(p2);

let p3: Product = {name:"Soda", price: 4.99};
products.push(p3);

function findAveragePrice(products: Product[]){
    let total: number = 0; 
    for(let i = 0; i <products.length; i++){
        total += products[i].price;
    }

    return Math.round(total/products.length * 100)/100; 
}

let avg:number = findAveragePrice(products);
console.log(avg);

document.getElementById("AveragePrice").innerText = `Average Price: $${avg}`; 

//-----------------------------------------------------------------------------------------------------------------

interface Inventory{
    product: Product, 
    quantity: number
}
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


let items:Inventory[] = []; 

let prod1: Product = {name: "Motor", price:10};
let i1:Inventory =  {product: prod1, quantity:10};
items.push(i1);

let prod2: Product = {name: "Sensor", price:12.50};
let i2:Inventory =  {product: prod2, quantity:4};
items.push(i2);

let prod3: Product = {name: "LED", price:1.00};
let i3:Inventory =  {product: prod3, quantity:20};
items.push(i3);

console.log(i1);

function FindTotalCost(items:Inventory[]):number {
    let total:number = 0; 
    for(let i = 0; i < items.length; i++){
        total += items[i].product.price * items[i].quantity; 
        console.log(total);
    }

    return total;
}

let total: number = FindTotalCost(items);
console.log(total);

document.getElementById("TotalInventory").innerText = `Total Price of Inventory: ${total} `;
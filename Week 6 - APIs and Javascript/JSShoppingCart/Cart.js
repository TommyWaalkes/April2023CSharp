//Javascript likes to lump classes in with other functionality

class Item{
    constructor(name, cost){
        this.name = name; 
        this.cost = cost;
    }
}
let cart = [];
let items = []; 

//Push acts the same as Add from lists in C#, it adds the item to the end of the list
items.push(new Item("Spam", 3.99)); 
items.push(new Item("Iced Tea", 10.99)); 
items.push(new Item("Water Mellon", 6.50));

function addToCart(index){
    cart.push(items[index]);
    //console.log(cart);
    calcTotal();
}

function calcTotal(){
    let total = 0; 
    for(let i = 0; i < cart.length; i++){
        total += cart[i].cost;
    }
    total *= 1.06; 
    total = Math.round(total*100)/100;
    document.getElementById("Total").innerText = `Total: $ ${total}`;
}

let output = document.getElementById("Items");

for(let i = 0; i < items.length; i++){
    let item = items[i];
    let result = `<p>Name: ${item.name}, Cost: ${item.cost}</p>  <button onClick='addToCart(${i})'> Add to Cart</button>`;

    //InnerHTML lets you change the text and thre HTML and innertext only lets you change the text inside the element
    output.innerHTML += result; 
}



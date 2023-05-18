let input = prompt("Please input a number and I will print all exponents to that number");

for(let i = 1; i <= input; i++){
    console.log("Number: " + i); 
    console.log("Square: "+ (i*i));
    console.log("Cube: "+ (i*i*i)); 
    console.log();
}
let goOn = true; 

while(goOn === true){
    //Technically in Javascript ; are optional but reccomended. 
    //You want the ; so JS doesn't get confused and treat 2 lines as one. 
    console.log("Hello and welcome to our room calculator"); 

    //Prompt creates small pop up that displays the message input as a parameter. 
    //In pop up there will be a input box to provide user input, just like console.readline()

    //With these prompts there's not preventing us from inputing any datatype
    //(BUT we will learn Typescript later on, which put C# style typing onto Javascript)
    let width = prompt("Please input a width");
    let height = prompt("Please enter a height"); 

    let area = height * width;
    console.log("Area: " + area);

    let perimeter = 2 * height + 2*width;
    console.log(`Perimeter: ${perimeter}`);

    goOn = keepGoing();
}

function keepGoing(){
    let input = prompt("Would you like to measure another room? y/n").toLowerCase();

    if(input === "y"){
        //In Javascript returns follow the same rules as C#, but with a big difference 
        //Functions do not have a return type, so you can return whatever data type whenever you want 
        //Or skip a return statement. 
        return true; 
    }
    else if(input === "n"){
        return false; 
    }
    else{
        alert("I'm sorry I didn't understand your input, let's try again");
        return keepGoing();
    }
}
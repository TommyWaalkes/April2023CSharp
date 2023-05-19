function changeHeaderColor(){
    document.getElementById("Header").style.color = "red"; 
}
let sizeNum = 14; 
function increaseLiSize(){
    let list = document.getElementsByTagName("li");
    sizeNum++;
    for(let i = 0; i < list.length; i++){
        let item = list[i]; 
        let size = item.style.fontSize; 
        console.log(size);
        // if(size== ""){
        //     size = sizeNum; 
        // }
        
        console.log(item.style.fontSize);
        item.style.fontSize = sizeNum+ "px";
        //item.style.fontSize++;
    }
}

function doMath(){
    let num1 = document.getElementById("num1"); 
    let num2 = document.getElementById("num2");
    let op = document.getElementById("operation").value; 

    //Javascript will allow you to print an object directly and it will display the object's current properties 
    console.log(num1);
    let result = 0; 
    let n1 = num1.valueAsNumber;
    let n2 = num2.valueAsNumber;
    if(op =="add"){
        result = n1+n2;
    }
    else if(op=="sub"){
        result = n1 - n2; 
    }
    else if(op=="multi"){
        result = n1 * n2; 
    }
    else if(op =="divide"){
        result = n1/n2;
    }   
    document.getElementById("output").innerText = result;
}
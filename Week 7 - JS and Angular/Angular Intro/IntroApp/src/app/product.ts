//Export makes this file availiable to be imported by any other file in the project 
//Put another way this is equivalent to making somethng public in C# 
export interface Product {
    name:string, 
    price:number, 
    description:string
}


//Like C# models, Angular models are usually interfaces and consist of a series of properties and no constructor. 
//In some situations you may also include code to convert to and from your model, particularly when dealing with APIs
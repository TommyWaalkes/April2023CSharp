export interface Employee {
    name:string, 
    title:string, 
    salary:number,
    age:number,
    
    //The ? makes it nullable which means the variable will allow nulls
    isEditing?:boolean
}

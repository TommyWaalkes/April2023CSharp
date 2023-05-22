interface Student{
    name: string, 
    homeTown: string, 
    favoriteFood:string
}

let students : Student[] = [];

let s : Student = {name:"Jimmy", favoriteFood: "Burgers", homeTown:"Texas"};
students.push(s);

let s2 : Student = {name:"Jane", favoriteFood: "Mac n Cheese", homeTown:"NYC"};
students.push(s2);

let s3 : Student = {name:"Jeni", favoriteFood: "Salad", homeTown:"Raleigh NC"};
students.push(s3);
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

let list  = document.getElementById("StudentList"); 
console.log(list);
for(let i = 0; i < students.length; i++){
    list.innerHTML += `<li>Name: ${students[i].name}</li> 
    <button onClick="StudentDetails(${i})"> Learn more about ${students[i].name} </button>`;
}

function StudentDetails(index: number) : void{
    let s: Student = students[index];

    let output = document.getElementById("Output");
    //wipe out whats there already
    output.innerHTML= "";

    output.innerHTML+= `<p> Name: ${s.name} </p>`
    output.innerHTML+= `<p> Hometown: ${s.homeTown} </p>`
    output.innerHTML+= `<p> Favorite Food: ${s.favoriteFood} </p>`
}
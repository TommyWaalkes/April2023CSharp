var students = [];
var s = { name: "Jimmy", favoriteFood: "Burgers", homeTown: "Texas" };
students.push(s);
var s2 = { name: "Jane", favoriteFood: "Mac n Cheese", homeTown: "NYC" };
students.push(s2);
var s3 = { name: "Jeni", favoriteFood: "Salad", homeTown: "Raleigh NC" };
students.push(s3);
var list = document.getElementById("StudentList");
console.log(list);
for (var i = 0; i < students.length; i++) {
    list.innerHTML += "<li>Name: ".concat(students[i].name, "</li> \n    <button onClick=\"StudentDetails(").concat(i, ")\"> Learn more about ").concat(students[i].name, " </button>");
}
function StudentDetails(index) {
    var s = students[index];
    var output = document.getElementById("Output");
    //wipe out whats there already
    output.innerHTML = "";
    output.innerHTML += "<p> Name: ".concat(s.name, " </p>");
    output.innerHTML += "<p> Hometown: ".concat(s.homeTown, " </p>");
    output.innerHTML += "<p> Favorite Food: ".concat(s.favoriteFood, " </p>");
}

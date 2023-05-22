class Country {
    //Classes in Javascript work a little different than C#, 
    //You may still declare and use properties/methods. 
    //However in Javascript, you may pop a new method or property into existence at any time.
    //You cannot set the datatype of any of your properties, so you generally have to guess the data types based on the name of the properties
    
    //You may still define construvtor in classes, but you must use the constructor keyword to do so. 
    //In Javascript the this.property syntax is used much more heavily. To access any property with the same class 
    //You must use the this. syntax. 
    constructor(name, lang, greeting, colors) {
        this.name = name;
        this.lang = lang;
        this.greeting = greeting;
        this.colors = colors;
    }
}
let usa = new Country("USA", "Murican", "Why Hello there world! Have some McDonalds", ["red", "white", "blue"]);
let mexico = new Country("Mexico", "Spanish", "Hola mundo!", ["red", "white", "green"]);
let algeria = new Country("Algeria", "Arabic and Berber", "Sup", ["blue", "yellow", "red"]);
let morocco = new Country("Morocco", "Arabic", "Salve Mundo", ["red", "green"] );


function SwitchCountry() {
    let input =  document.getElementById("CountryList").value; 
    let country;

    if (input === "USA") {
        //set country to usa 
        country = usa;
    }
    else if (input === "Mexico") {
        country = mexico;
    }
    else if (input === "Algeria") {
        country = algeria;
    }
    else if(input== "Morocco"){
        country = morocco;
    }

    let name = document.getElementById("CountryName"); 

    name.innerText = country.name; 

    let lang = document.getElementById("OfficialLanguage"); 

    lang.innerText = country.lang; 

    
    let greeting = document.getElementById("HelloWorld"); 

    greeting.innerText = country.greeting; 

    if(country.colors.length == 3){
        let col1 = document.getElementById("Color1"); 
        col1.style.backgroundColor = country.colors[0];

        let col2 = document.getElementById("Color2"); 
        col2.style.backgroundColor = country.colors[1];

        let col3 = document.getElementById("Color3"); 
        col3.style.backgroundColor = country.colors[2];
    }
    else if(country.colors.length == 2){
        let col1 = document.getElementById("Color1"); 
        col1.style.backgroundColor = country.colors[0];

        let col2 = document.getElementById("Color2"); 
        col2.style.backgroundColor = country.colors[1];

        let col3 = document.getElementById("Color3"); 
        col3.style.backgroundColor = country.colors[1];
    }

}

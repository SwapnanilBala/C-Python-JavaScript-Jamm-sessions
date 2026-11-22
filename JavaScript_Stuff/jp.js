// console.log("Hello World\n");

// const firstname = 'Swapnanil';
// var age = 28;
// var profession = "Data Engineer";
// var email = "swapnanil.professionale@gmail.com";
// let ismarried = false;
// let preference = null;

// console.table([firstname, age,profession,email, ismarried,preference]);
// console.log(typeof([firstname,age,profession,email,ismarried,preference]));

// console.log(typeof(firstname));
// console.log(typeof undefined);
// console.log(typeof null);

// alert(1+3);

// let score = 33;

// console.log(typeof score);
// console.log(typeof(score));

// both carry the same meaning, only difference is in writting

// let score = 28;
// let age = "28";

// console.log(Number(age));
// console.log(score);
// console.log(Number(age) == score);

// let score = "28";
// let val = Number(score);

// console.log(val);
// console.log(typeof(val));
// console.log(val);

// let strnum = "28abd";

// console.log(typeof(Number(strnum)));
// console.log(Number(strnum));

// function greet(name) {
//     return `Hey ${name}, pleasure making your acquiantance`;
// }
// console.log(greet("Swapnanil Bala"));

// const score = 100;

//Primitive DataTypes

// 7 Types: String, Number, Boolean, Null, Undefined, Symbol, BigInt

// Reference Data Types (non-Primitive)

// Memory Reference can be allocated: Arrays, Objects, Functions

// const val1 = Symbol("1234");
// const val2 = Symbol("1234");

// console.log(val1 == val2);
// console.log(`The values are ${val1} and ${val2}`); // Will throw an error
// Type val1.description only then you will see the output

const menu = [
    {name : "Cold Drink", price: 2},
    {name : "Hard Liquor", price: 12},
    {name : "Pizza", price: 22},
    {name : "Chocolate", price: 5},

]

// var cashInRegister = 150;
// var orderQueue = [];

// function addFood(foodname) {
//     for(const [key,value] of Object.entries(foodname)) {
//         switch(key) {
//             case "Pizza":
//                 orderQueue.push(key);
//                 cashInRegister -= value;
        
//         }
//     }

//     return cashInRegister;
// }

// console.log(`After Ordering the new balance is ${addFood(menu("Pizza"))}`);


// for (item of menu) {
//     for (const [name, price] of Object.entries(item)) {
//     console.log(`Item: ${name} and Price: ${price}`);


//     }
// }


// function addNewStuff(stuff) {
//     menu.push(stuff)
// }

// addNewStuff({Name: "Hot Dog", Price: 6})

// function show_the_menu (items) {
//     for (things of items) {
//         for (const[key,value] of Object.entries(things)) {
//             return `The object is ${key} and the price for it is ${value}`;
//         }
//     }
// }

// console.log(show_the_menu(menu));


// mnu = []

// function stm (itm) {
//     for (things in itm) {
//         for (const[key,value] of Object.entries(things)) {
//             mnu.push(`Item: ${key} and Price ${value}`)
//         }
//     }
//     return null

// }

// stm(menu)




// console.log(typeof(mnu))

// for (items of mnu) {
//     for (const [name,price] of Object.entries(items)) {
//         console.log(`\n Name of the Item: ${name} and the Price of it is this: ${price}`)
//     }
// }

// for (const[key, value] of mnu) {
//     console.log(`name: ${key} price: ${value}`);
// }


const user = {
    username: "Swap",
    age: 29,
    skills: ['Python', 'C#'],
    isActive: false
}

// Function(Name) {
//     console.log(`Hello ${user.usename}, you are ${user.age} years old and your skills are ${user.skills}, thank you for your kindness`)
//     return
// }

// for (items of user) {
//     for (const[key, val] in Object.entries(items)) {
//     console.log({`\n item is : ${val}`})
// }
// }

// for (const [key, val] of Object.entries(user)) {
//     console.log(`The item is : ${key} and the detailing is: ${val}`)
// }

// function printstuff(userde) {
//     return console.log(`Hello ${userde.username}`);
// }

// printstuff(user)


// console.log(typeof(user))
// console.log(typeof(user.age))
// console.log(typeof(user.skills))

// const numbers = [1,2,3,4,5]

// const answer = Array.of(5);

// console.log(answer)

// const letters  = Array.from('Dog');

// console.log(letters)

const zeros = new Array(5).fill(1);
console.log(zeros);


function placeOrder(foodName) {
    const selectedFood  = menu.find(foodName => foodName.name === "Cold Drinks")
    cashInRegister += foodName.price
    const newOrder = {foodName: selectedFood, status: "Ordered"}
    
}
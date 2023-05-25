const allFuncs = require('./Ex02-CustomModule');
const empObj = require('./Ex02-CustomModule').empObject
const tFunc = require('./Ex02-CustomModule').testFunc;
const mulFunc = require('./Ex02-CustomModule').
multiplicationTable;

// allFuncs.multiplicationTable(12);
// mulFunc(5);
// console.log(JSON.stringify(empObj));
// tFunc()
// allFuncs.testFunc();

const empClass = allFuncs.empClass;
const obj1 = new empClass(123, "Phaniraj", "Mysore");
const obj2 = new empClass(124, "Sunder", "Hyderabad");
console.log(JSON.stringify(obj1)) 
console.log(JSON.stringify(obj2)) 

const cst1 = new allFuncs.customer(123, "David Warner", 2343243, 5600);
const cst2 = new allFuncs.customer(124, "Tom Alter", 9879757, 3600);

console.log(JSON.stringify(cst1))
console.log(JSON.stringify(cst2))
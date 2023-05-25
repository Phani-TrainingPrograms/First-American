console.log("Testing Nodejs from Cmd")

function testFunc(){
    console.log("test Function is implemented")
}
const addFunc = (v1, v2) => v1 + v2;
const mulFunc = (v1, v2) => v1 * v2;
testFunc();

console.log(addFunc(123, 23));
console.log(mulFunc(12, 4));

const arr = ["Apples", "Mangoes"];
arr.push("Oranges")
for(let i = 0; i < arr.length; i++)
 console.log(arr[i])
console.log("-------------Iterating using for of statment--------")
for(const element of arr)
console.log(element) 
console.log("-------------Iterating using for in statment--------")
for(const key in arr)
  console.log(`Index: ${key}---> Value: ${arr[key]}`)
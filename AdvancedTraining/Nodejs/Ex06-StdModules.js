//Nodejs gives a set of predefined modules that can be used for developing Apps. These builtin modules have APIs that can allow to perform various kinds of complex operations required for developing Apps. 
//fs is a built in module of nodejs used to perform IO operations on files using JavaScript. 

const fs = require('fs');

// const fileName = "Ex06-StdModules.js";
// //Read the contents of the File in a synchronous manner
// //const contents = fs.readFileSync(fileName, 'utf-8');
// //console.log(contents)

// //Read the contents of the File in a asynchronous manner
// fs.readFile(fileName, 'utf-8', (err, contents)=>{
//     if(err != null)
//       console.log(err.message);
//     else{
//         console.log(contents)
//     }
// })

// fs.writeFileSync("TestFile.txt", "Sample Text to write", "utf-8")
// const obj = {};
// obj.empId = 123;
// obj.empName = "Phaniraj";
// obj.empAddress = "Bangalore";
// obj.empSalary = 67000;
// fs.writeFileSync("EmpData.csv", JSON.stringify(obj), 'utf-8');
// console.log("End of the file reading--------------------")

const array = [];
array.push({id : 111, empName : "Phaniraj", empAddress : "Bangalore"});
array.push({id : 112, empName : "Aditya", empAddress : "Nagpur"});
array.push({id : 113, empName : "Sahana", empAddress : "Tumkur"});
array.push({id : 114, empName : "Faizal", empAddress : "Bangalore"});
array.push({id : 115, empName : "Junaid", empAddress : "Dehradun"});
array.push({id : 116, empName : "Leheri", empAddress : "Chennai"});
array.push({id : 117, empName : "Charan", empAddress : "Mysore"});
array.push({id : 118, empName : "Nidhi", empAddress : "Chandigarh"});
array.push({id : 119, empName : "Abhisek", empAddress : "Bhubaneshwar"});
array.push({id : 120, empName : "Vivek", empAddress : "Varanasi"});
array.push({id : 121, empName : "Omkar", empAddress : "Kolhapur"});

 const filename = "empRecords.csv";
// array.forEach(element => {
//     const line = `${element.id},${element.empName},${element.empAddress}\n`
//     fs.appendFileSync(filename, line, 'utf-8');
// });


// //read the data after it. 
// const contents = fs.readFileSync(filename, 'utf-8');
// console.log(contents)









//Task:
function getRecords(fileName){
    const empData = [];
    var data = fs.readFileSync(fileName, 'utf-8');
    const lines = data.split('\n');
    lines.forEach(line =>{
        if(line != ""){
            let values = line.split(',');
            let emp = {};
            emp.id = parseInt(values[0])
            emp.empName = values[1];
            emp.empAddress = values[2];
            empData.push(emp);
        }
    })
    return empData;    
}
const records = getRecords(filename);//read the CSV file...
for(const item of records)
    console.log(item.empName);

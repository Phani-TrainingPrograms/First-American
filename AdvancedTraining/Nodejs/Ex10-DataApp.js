const http = require('http');
const fs = require('fs');
const parse = require('url').parse;//For HTTP GET PROCESSING....
const qs = require('querystring');

const currDir = __dirname;

function renderHtml(filename, res){
    const file = currDir + filename 
    fs.createReadStream(file).pipe(res);
}

function processGet(req, res){
    const data = parse(req.url, true).query;
    const msg = `<h1>Welcome to Mr. ${data.txtName}</h1><hr/><p>Thanks for Registering with Us!</p><p>Other Details will be intimated to you by UR registered address at ${data.txtAddress}</p>`;
    res.end(msg);
}
function processPost(req, res){
    let inputValues = "";
    req.on("data", (result)=>{//when the page is posted. 
        console.log(result)
        inputValues += result
    })

    req.on("end", ()=>{//When the posted data reaches the server
        let data = qs.parse(inputValues);
        console.log(data)
        const line = `${data.txtId}, ${data.txtName}, ${data.txtAddress}\n`;
        fs.appendFileSync("empRecords.csv", line, 'utf-8' );
        const msg = `<h1>Welcome to Mr. ${data.txtName}</h1><hr/><p>Thanks for Registering with Us using HTTPPOST!</p><p>Other Details will be intimated to you by UR registered address at ${data.txtAddress}</p>`;
        res.end(msg);
    })
}
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
//TODO: Modify the POST operation to append the inputs to the CSV file created. Add another case in the switch case to display the data from the CSV file into a Table of recods. 
function displayTable(res){
    let page = "<h1>Table of Records with Us</h1><hr/>";
    let data = getRecords("empRecords.csv");
    let table = `<table border= "1">
                    <tr>
                        <th>EmpId</th>
                        <th>Emp Name</th>
                        <th>Emp Address</th>
                    </tr>`
    data.forEach((value)=>{
        const row = `<tr>
                    <td>${value.id}</td>
                    <td>${value.empName}</td>
                    <td>${value.empAddress}</td>
                    </tr>`
        table += row;            
    })
    page += table;
    res.end(page);
}

http.createServer((req, res) => {
    if (req.url == '/favicon.ico') {
        return;
    }
    if (req.method == "POST") {
        processPost(req, res);
        return;
    }else {
        const data = parse(req.url).query;
        if (data != null) {
            processGet(req, res);
            return;
        }
        switch (req.url) {
            case "/Register":
                renderHtml("/Register.html", res);
                break;
            case "/jQueryExample":
                renderHtml("/TableOfRecords.html", res)
                break;
            case "/EmpData":
                res.end(JSON.stringify(getRecords("empRecords.csv")));
                break;
            case "/ShowRecords":
                displayTable(res);
                break;
            default:
                renderHtml("/ErrorPage.html", res)
                break;
        }
    }
}).listen(1234);
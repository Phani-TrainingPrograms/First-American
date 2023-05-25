const express = require('express');
const sql = require('msnodesqlv8');

const app = express();
//Include a package called mssql and msnodesqlv8 for the Nodejs module to connect to SQL server database
app.use(express.json());
app.use(express.urlencoded({extended : false}));
const connectionString = "Server={.\\SQLEXPRESS}; Database={FaiTraining}; Trusted_Connection=Yes;Driver={SQL Server Native Client 11.0}; "
const selectQuery = "SELECT * FROM EMPLOYEES";

app.get('/Employees', (req, res) => {
    sql.query(connectionString, selectQuery, (err, rows) => {
        res.send(rows);
    });
});

app.get("/Employees/:id", (req, res)=>{
    const id = req.params.id
    const query = "Select * from Employees where EmpId = " + id;
    sql.query(connectionString, query, (err, rows)=>{
        res.send(rows[0])
    })
})


app.post("/AddEmployee", (req, res)=>{
    const body = req.body;
    const query = `Insert into Employees values('${body.EmpName}', '${body.EmpEmailAddress}', ${body.EmpSalary})`;
    sql.query(connectionString, query, (err, result)=>{
        if(err) res.send(err.message);
        else 
            res.send("Employee added successfully");
    })
 })

 app.put("/Update", (req, res)=>{
    const body = req.body;
    const query = `Update Employees Set EmpName = '${body.EmpName}', EmpEmailAddress = '${body.EmpEmailAddress}', EmpSalary =  ${body.EmpSalary} where EmpId = ${body.EmpId}`;
    sql.query(connectionString, query, (err, result)=>{
        if(err) res.send(err.message);
        else 
            res.send("Employee updated successfully");
    })
 })
 

 app.delete("/Employees/:id", (req, res)=>{
    const id = req.params.id
    const query = "Delete from Employees where EmpId = " + id;
    sql.query(connectionString, query, (err, rows)=>{
        if(err) 
            res.send(err.message) 
        else
            res.send("Employee deleted successfully")
    })
})

app.listen(1234, ()=>{
    console.log("Server at 1234");
})
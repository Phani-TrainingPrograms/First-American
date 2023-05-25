const express = require('express');
const app = express();
//This will ensure that the Posted data will be the part of the req.body object. If not given, then the body object will not be in the req object. 

//If U want to add additional rules/ enforce new code into the pipeline of the Nodejs Environment, we use MIDDLEWARE. 
app.use(express.urlencoded({ extended : false }));

app.get('/', (req, res)=>{
    res.send("Default Home Page");
})

app.get("/EmpData", (req, res)=>{
    res.send("USe the logic of the previous example and allow the data to be displayed here as JSON. <br>This is UR Assignment")
})
////////////Add this new End point//////////////////////////
app.get("/Register", (req, res)=>{
    res.sendFile(__dirname + "/Register.html");
})

app.get("/ProcessPage", (req, res)=>{
    const strContent = `<h1>${req.query.txtName} Details with us!!!</h1><hr/><p>The Address registered with us is ${req.query.txtAddress}</p><p>Thank you!!!</p>`
    res.send(strContent)
})

app.post("/AfterRegister", (req, res)=>{
  let name = req.body.txtName;  
  let address = req.body.txtAddress;
  const strContent = `<h1>${name} Details with us!!!</h1><hr/><p>The Address registered with us thru HTTP POST is ${address}</p><p>Thank you!!!</p>` 
  res.send(strContent)  
})

app.get("/Client", (req, res)=>{
    res.sendFile(__dirname + "/Client.html");
})
app.listen(1234, ()=>{
    console.log("server is available at port no 1234")
})
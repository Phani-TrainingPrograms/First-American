module.exports.testFunc = () => console.log("Test Func from the Custom Module")

module.exports.empObject = {
    empName : "Phaniraj", 
    empAddres : "Bangalore",
    empSalary : 56000
}

module.exports.multiplicationTable = function(no){
    console.log("Multiplication Table for " + no)
    for(let i = 1; i < 11; i++){
        console.log(`${no} X ${i} = ${no * i}`)
    }
    console.log("End of the Table")
}

//Classic JS Feature of Class creation.
module.exports.empClass = function(id, name, address){
    this.empId = id;
    this.empName = name;
    this.empAddress = address
}

//ES6 Feature of Class creation
module.exports.customer = class{
    constructor(id, name, phone, billAmount){
        this.cstId = id;
        this.cstName = name;
        this.cstPhone = phone;
        this.cstBill = billAmount
    }
}


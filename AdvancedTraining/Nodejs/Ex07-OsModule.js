const os = require('os');
//os module is used to get info about the system where the nodejs is running. 

console.log(os.userInfo());

console.log("The Computer Name is " + os.hostname());
console.log("The Platform is " + os.platform());
console.log("The OS architecture is " + os.arch());
console.log("The OS version is " + os.version())
console.log("The total no of CPUs in this machine is " + os.cpus().length)
console.log("The Computer is running since " + os.uptime() /3600  + " hrs")
console.log("The free memory of this machine in Mega-Bytes is " + os.freemem() / (1024 * 1024 * 1024));
console.log("The Total memory of this machine in GB is " + os.totalmem() /  (1024 * 1024 * 1024) )

const processors = os.cpus();
for(const cpu of processors){
    console.log(JSON.stringify(cpu))
}
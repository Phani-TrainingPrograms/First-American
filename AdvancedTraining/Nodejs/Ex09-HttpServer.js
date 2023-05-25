//Http is an important module of Nodejs used for creating Web Servers in UR platform. Http provides mininal APIs for creating server applications using JavaScript. It allows to render HTML pages as well as processing of those pages in ur app using http methods like GET, PUT, POST and DELETE
const fs = require('fs');
const http = require('http');
const currDir = __dirname;//Executing directory of the Application

const processUrl = function(req, res){
    const url = req.url;
    const content = url + " page and its contents are processed here";
    res.write(content);
    res.end();
}
http.createServer((req, res)=>{
    if(req.url != "/favicon.ico"){
        console.log(req.url)
        if(req.url == '/Client'){
             fs.createReadStream(currDir + req.url + ".html").pipe(res);
             return;   
        }else
        processUrl(req, res)
    }
}).listen(1234);
console.log("server is available at port 1234")
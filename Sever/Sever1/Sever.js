var http = require("http");// ref to http lib
var func = require("./Func");

var sever = http.createServer(function(req, res){
    res.writeHead(200, {"Content-Type" : "text/html"});
    res.write("<center> <h1> Hello World! </h1> </center>");

    //use module Func
    res.write("Sum: " + func.sum(1,2) + "</br>");
    res.write("Sub: " + func.sub(2,1) + "</br>");

    res.end("<h1> . </h1>");
});

sever.listen(8080,function(){
    console.log("Sever running on port 8080")
});
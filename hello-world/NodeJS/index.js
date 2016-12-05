var HelloWorldClient = require('./helloWorldClient');

//#######################################################
//###
//### Super simple get request based on helloworld.json
//###
//#######################################################
var client = new HelloWorldClient();
client.greeting.get(function(err, msg, http){
    console.log(`errors: ${err}`);
    console.log(`message: ${msg}`);
    console.log(`HTTP: ${JSON.stringify(http)}`);
});


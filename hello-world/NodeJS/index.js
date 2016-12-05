var helloWorldClient = require('./helloWorldClient');

client = new helloWorldClient();
client.greeting.get(function(err, msg, http){
    console.log(err, msg, http);
});


//Events are actions performed by the user on the object. The object should be able to emit the events triggered by the user. Nodejs has events module that allows UR classes to trigger events when some action is performed by the user.

const events = require('events');

const button = new events();
button.on("click", ()=>{
    console.log("Button's click event is triggered")
})

button.on("dblClick", ()=>{
    console.log("Button's double click event is triggered")
})

button.on("customName", ()=>{
    console.log("Custom event called customName is triggered")
})

//Raise the event from the code.
button.emit("click");
button.emit("click");
button.emit("click");
button.emit("click");
button.emit("click");

button.emit("customName")

//Named Function in JS
function addFunc(v1, v2) {
    return v1 + v2;
}

//Anonymous Functions
const subFunc = function(v1, v2) {
    return v1 - v2;
}
//Arrow functions or Lambda Functions.
const mulFunc = (v1, v2) => v1 * v2;

const divFunc = (v1, v2) => v1 / v2;

const operation = function(v1, v2, operand){
    let result = 0.0;
    switch(operand){
        case "+" : result = addFunc(v1, v2); break;
        case "-" : result = subFunc(v1, v2); break;
        case "*" : result = mulFunc(v1, v2); break;
        case "/" : result = divFunc(v1, v2); break;
        default: result = 0;
    }
    return result;   
}
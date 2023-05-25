//IIFE stands for Immediately Invoked Functional Expressions that can return an object directly for the user who consumes the module. 

module.exports.shoppingCart = (function(){
    let cart = [];

    addItem = (item) => cart.push(item);
    getAll = () => cart;
    findItem = (id) => cart.find((i) => i.id == id)
    
    return {
        addItem, getAll, findItem
    }
})();

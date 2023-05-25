const cart = require('./Ex04-IIFE Functions').shoppingCart;

cart.addItem({id : 123, itemName : "Apples", quantity : "4 Kgs"});
cart.addItem({id : 124, itemName : "Mangoes", quantity : "2 Kgs"});
cart.addItem({id : 125, itemName : "Oranges", quantity : "1 Kgs"});

const allProducts = cart.getAll();
for (const item of allProducts) {
    console.log(item)
}


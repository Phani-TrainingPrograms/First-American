//Representation of class in classic JavaScript. This is called as function based classes. 
const Employee = function(id, name, address, salary){
    this.id = id;
    this.name = name;
    this.address = address;
    this.salary = salary;

    this.display = function(){
        console.log(`The Name is ${this.name} from ${this.address} earning a salary of Rs. ${this.salary}`);
    }
}
//////////////////////////////////////////////////////////////////////////////
//////////////////////////////////New Syntax for Class creation///////////////
//////////////////////////////////////////////////////////////////////////////
class Book{
    constructor(id, title, cost, author){
        this.bookId = id;
        this.price = cost;
        this.bookTitle = title;
        this.author = author;
    }

    display(){
        return `${this.bookTitle} is written by ${this.author} and is priced ${this.price}`
    }
}


class BookStore{
    constructor(){
        this.books = [];//blank Array of books
    }

    getAllBooks = () => this.books;

    addNewBook = (book) => this.books.push(book);  
     

    updateBook = (book) =>{
        const index = this.books.indexOf(book);
        this.books.splice(index, 1, book);
    }

    deleteBook = (id) =>{
        const index = this.books.findIndex((book)=>book.bookId == id);
        this.books.splice(index, 1);
    }
}
//U could create objects for these classes using new operator.  
//Helper function
function $(id){
    return document.getElementById(id);
}
# jQuery Tutorial
- jQuery is a library (Open source) for developing Web Apps using JavaScript. 
- It provides APIs to search(Query) the elements of DOM and access them to manipulate them. 
- This includes resizing, animating, event handling and features that affect the UI of the Application. 
- Its all about DOM Manipulations. 
- jQuery follows a principle of write less, get more concept where with minimal code, U should be able to get larger features incorporated in the Application. 

## Features of jQuery
- The lib is available as a single file downloadable from the internet or could be extracted thru a CDN(Content Delivery Network).
- It has Selectors that allows to select a DOM Element or a collection of elements on which operations could be performed. 
- These selectors are based on CSS Selectors: ElementById, ElementsByClassName, ElementsByTagName and so forth. 
- There is a seperate lib for UI enhancements like DragDrop and rich UI features called jquery.ui library. 
- jQuery has APIs to even access Server side APIs(REST APIs) using Ajax Features. (Ajax is a way of getting parts of pages instead of full page from the server).

## How to get jQuery library
- U can download the single file of jQuery library from the official website at this URL: 
```
https://code.jquery.com/jquery-3.6.4.min.js
```
- However, U could also get the CDN Server location from your most trusted Organization: Google, Microsoft, Yahoo, jQuery, AWS, NPM and many more. 
- U should download the minified version of the library which is smaller in size and is compacted to suit UR production requirement.

## How to use the jQuery APIs
- Include the downloaded script file in the html document.
- jQuery is a library of JS, so its same as JavaScript only.
- U can refer the jQuery API using jQuery object. Its short form is $. 
- jQuery object takes a parameter of a selector on which U want to perform an operation and U provide callback function to the action that the User wishes to perform. 

## document.ready
- We use ready event to load the whole document and then map any events to the elements that we select. 
- $() implicitly refers to document itself. The default selector for jQuery is document itself. 
- U should use anonymous methods for handling events of the DOM elements as it contains the reference to the object on which the operation is performed. Lambda Methods hoist the functions to the DOM object which will be the Window object.
- document.ready ensures that the elements are all loaded into the Page and DOM structure is created before we could access the elements using other jQuery selectors.



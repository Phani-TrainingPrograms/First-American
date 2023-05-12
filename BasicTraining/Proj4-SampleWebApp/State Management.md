## State Management: 
- Ability to store small pieces of information that can be used across the Web Pages for a specified period of time. U cannot store information in the Page objects or anywhere as the HTTP is a Stateless protocol. Web Servers do not store any information about the pages or the data of those pages. Every REQUEST made by the User is a unique request for which the server gives RESPONSE. The Information is returned to the browser as a HTTPRESPONSE to the HTTPREQUEST made by the Browser. 
- So http is the protocol used for sharing the info from the Server to the Client Browser. 
- HTTP being stateless protocol, do not hold any information about the previous Request or Response from the Current one.
- As a Server side web programmer, we depend on some features of HTTP to retain the data. It can be on the Client browser or in the Web Server. 
- State is managed in 2 ways: 
  - Client side State Management and 
  - Server side State Management.

## Client Side State Management:
1. QueryString: Text in the form KEY-VALUE pairs sent thru the URL of the Web Page.
2. Cookies: Text based files saved in the Client machines that can have information that could be used within the Application for a long period of time.
3. PreviousPage object in ASP.NET that contains the info about the Previous Page in  the form of Page object which will be available in the Current Page.   

## Server Side State management:
1. Session: An unique interaction b/w the client and the server identified by an ID that will be available till the browser is closed. 
2. Application: State that is used commonly for all the users of the Application. It will be available in the server until the Programmer destroys it or when the Server is shut down. 
3. ViewData that can be available for the Page object itself.
4. Caching of the Data in the Page is also one of the server side state management technique. 

### Questions to ask:
1. What is State management in Server side Programming?
2. Why State management is required in SSP?
3. What are the different ways of achieving State management?
4. What is the difference b/w Client Side State Management and Server side state Management?
5. What are the client side state Management techniques?
6. What are the server side State managament techiniques?

### QueryString: 
- A text based key-value pairs of data seperated by an & and appended into the URL of the Page that U want to view is called as Querystring. 
- Forms submitted thru HTTPGET would use QueryString to send the data to the server. 
- QueryString data is obtained using the Request object of the Page class.
- Limitations are: Querystring is not safe, it can be viewed by all other users of the machine and is available in the History of the browser. Some Browsers restrict the length of the URL upto 255 charecters and it can have only Text.

### Cookies:
- Cookies are text-based files that are stored in the Temp internet files of the browser that allows developers to store small text-based data in the client machine. They are harmless and allows to store information for up to 1 Year.
- Cookies are programmatically represented as objects of a class HTTPCOOKIE. The object allows storing single value using the Value property of the cookie object or multiple values as KEY-VALUE pairs using the Values property. 
- After the required values are set, the cookie object should be a part of the Cookies Collection of the Response object before we post or send to the server. **Cookies are set using the Response object.** 
- Cookies are **extracted using the Cookies Collection of the Request object.**

### Sessions:
- Session is a collection object that is stored in the server where it allows to store data of any kind in it in the form of Dictionary
- Session is created when a Request is made by the user to the Application and will remain so till the User closes or exits the Application. 
- Every Session is identified by a unique Id called SessionId which can be stored as a cookie in the browser to retain the data even if the browser is closed.
- Session can store any amount of data, but is not recommended to hold the data longer than its required to hold. - Session objects can be added using KEY-VALUE Pairs.  





   

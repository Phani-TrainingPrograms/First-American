State Management: 
Ability to store small pieces of information that can be used across the Web Pages for a specified period of time. U cannot store information in the Page objects or anywhere as the HTTP is a Stateless protocol. Web Servers do not store any information about the pages or the data of those pages. Every REQUEST made by the User is a unique request for which the server gives RESPONSE. The Information is returned to the browser as a HTTPRESPONSE to the HTTPREQUEST made by the Browser. So http is the protocol used for sharing the info from the Server to the Client Browser. 
HTTP being stateless protocol, do not hold any information about the previous Request or Response from the Current one.
As a Server side web programmer, we depend on some features of HTTP to retain the data. It can be on the Client browser or in the Web Server. 
State is managed in 2 ways: Client side State Management and Server side State Management.
Client Side State Management:
1. QueryString: Text in the form KEY-VALUE pairs sent thru the URL of the Web Page.
2. Cookies: Text based files saved in the Client machines that can have information that could be used within the Application for a long period of time.
3. PreviousPage object in ASP.NET that contains the info about the Previous Page in  the form of Page object which will be available in the Current Page.   

Server Side State management:
1. Session: An unique interaction b/w the client and the server identified by an ID that will be available till the browser is closed. 
2. Application: State that is used commonly for all the users of the Application. It will be available in the server until the Programmer destroys it or when the Server is shut down. 
3. ViewData that can be available for the Page object itself.
4. Caching of the Data in the Page is also one of the server side state management technique. 

What is State management in Server side Programming?
Why State management is required in SSP?
What are the different ways of achieving State management?
What is the difference b/w Client Side State Management and Server side state Management?
What are the client side state Management techniques?
What are the server side State managament techiniques?


QueryString: 
A text based key-value pairs of data seperated by an & and appended into the URL of the Page that U want to view is called as Querystring. 
Forms submitted thru HTTPGET would use QueryString to send the data to the server. 







   
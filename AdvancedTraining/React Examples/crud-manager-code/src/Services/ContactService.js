import axios from "axios";
//Axios is a external lin for providing HTTP Client services on Nodejs Applications.  It returns Promise objects to perform async calls in a easy manner. 
export class ContactService{
    static baseUrl = 'http://localhost:5105/Contacts'

    static getAllContacts(){
        return axios.get(this.baseUrl);
    }

    static getContact(contactId){
        let getUrl = `${this.baseUrl}/${contactId}`;
        return axios.get(getUrl);
    }

    static addContact(contact){
        return axios.post(this.baseUrl, contact);
    }

    static updateContact(contact){
        return axios.put(this.baseUrl, contact)
    }

    static deleteContact(contactId){
        let delUrl = `${this.baseUrl}/${contactId}`;
        return axios.delete(delUrl);
    }
}
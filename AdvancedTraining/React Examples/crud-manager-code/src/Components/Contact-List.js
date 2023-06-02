import React, { useEffect, useState } from 'react'
import { ContactService } from '../Services/ContactService';
import Contact from './Contact';

export default function ContactList() {
  
    //The data to be stored in the component
    const [ state, setState] = useState({
        contacts : [],
        errorMsg : ''
    });

    //useEffect hook is used to perform background work while the main component is doing its main work like loading or rendering. 
    useEffect(() => {
      async function fetchData(){
        const response = await ContactService.getAllContacts();
        setState({
            ...state, contacts : response.data
        })
      }
      fetchData()
    }, []);
    
    let { contacts, errorMsg } = state;
    
    
    return(
        <>
            <div className="container">
                <div className="row">
                    <div className="col">
                        <div className="container">
                            <div className="row">
                                <div className="col-md-6">
                                    <input type="search" className='form-control' placeholder='Search for Contact' />
                                </div>
                                <div className="col">
                                    <button className='btn btn-primary'>Search</button>
                                </div>
                            </div>
                            <div className="row">
                                {
                                    contacts.map((c) =>
                                        <Contact contact = {c} disabled= {true}/>
                                )}
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </>
    )
  
}

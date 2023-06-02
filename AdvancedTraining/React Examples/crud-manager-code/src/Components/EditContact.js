import React, { useEffect, useState } from 'react'
import { useParams } from 'react-router-dom'
import { ContactService } from '../Services/ContactService';
import Contact from './Contact';

export default function EditContact() {
    let{ contactId } = useParams();
    let[ state, setState ] = useState({selected : {}})

    useEffect(()=>{
        async function getRec(){
            debugger;
            console.log(contactId);
            let response = await ContactService.getContact(contactId)
            setState({selected : response.data})
        }
        getRec();

    }, [contactId])
    let { selected } = state;
  return (
    <div className='container'>
        <Contact contact={selected} disabled={false}/>
    </div>
  )
}

import './App.css';
import React, { useState } from 'react'

function ArrayComponent(){
    const [items, setItems] = useState([
        {id : 123, empName : "Phaniraj"},
        {id : 124, empName : "Gopal"},
        {id : 125, empName : "Suresh"},
        {id : 126, empName : "Kumar"}
    ])

    function removeItem(item){
        setItems(items.filter(i => i.id !== item.id))
    }
    const cards = items.map((item, index)=>{
        return(
            <div key={index} className='card'>
                <h2>{item.id}</h2>
                <h2>{item.empName}</h2>
                <button onClick={() =>removeItem(item)}>Remove</button>
            </div>
        )
    })

    function eventHander() {
        let lastId = 1;
        if(items.length > 0){
            lastId = items[items.length - 1].id;
        }
        const name = prompt("Enter the Name of the Employee");
        setItems([...items, {id : lastId + 1, empName : name}]);
    }
    //provide a functionality to have a button in every card, so that when it is clicked, it should delete itself from the items list and the UI should be updated accordingly.
    return(
        <div>
            <button onClick={eventHander}>Add Item</button>
            <br/>
            {cards}    
        </div>
    )
}
export default function App3() {
  return (
    <div>
        <ArrayComponent/>
    </div>
  )
}


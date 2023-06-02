import React,  { useState } from 'react'

/////////////Props Example//////////////////////
function PropsComponent({title, develper, company}){
    return(
        <div className='card'>
            <h1>{title}</h1>
            <p>Developed By: {develper}</p>
            <p>
                <h2>Under the ownership of {company}</h2>
            </p>
        </div>
    )
}

function PropsComponent2(props){
     
    const rows = Object.entries(props).map(([key, value]) =>{
        return(
                <tr key={key}>
                    <td>{key}</td>    
                    <td>{value}</td>    
                </tr>
            )
    })
    return(
        <>
           <h2>List of properties and Values</h2>
            <table border="1">
                <tr>
                    <th>Property Name</th>
                    <th>Property Value</th>
                </tr>
                {rows}
            </table>
        </>
    )
}
/////////////////SpreadOperator Example/////////////////
function SpreadOperatorExample(){
    const items = ["Apples", "Mangoes", "Oranges"]
    const newItems = [ ...items, "Pine Apples"]

    const user = {};
    const userWithName = { ...user, "Name" : "Phaniraj"}
    console.log(userWithName);
    const userWithNameAndAddress = { ...userWithName, "Address" : "Bangalore"};
    console.log(userWithNameAndAddress);
    const userWithNAS = { ...userWithNameAndAddress, "Salary" : 45000};
    console.log(userWithNAS);

    const listItems = newItems.map((value) => <li>{value}</li>)
    return (
        <>
        <div className='card'>
            <ol>{listItems}</ol>
        </div>
        <div className='card'>
            <h1>Name : {userWithNAS.Name}</h1>
            <p>Address : {userWithNAS.Address}</p>
            <p>Salary: {userWithNAS.Salary}</p>
        </div>
        </>
    )
}

//////////////////State Management/////////////////////
function UseStateExample(){
    //data in react should not be directly modified, it is limited to the component that creates it. If U want to update the data, we should use a hook called useState. 

    const [num, setNum] = useState(123)

    return(
        <>
            <h2>Current value: {num}</h2>
            <button onClick={()=>setNum(num + 1)}>Increment it!!!</button>
            <button onClick={()=>setNum(num - 1)}>Decrement it!!!</button>
        </>
    )
}

////////////////////Root Component//////////////////////
function App2() {
    const v1 = "Props Example with Values";
    const v2 = "Phaniraj B.N.";
    const v3 = "First American Training"
  return (
    <div>
        <h2>Props Example</h2>
        <PropsComponent title="React Example" develper="Phaniraj" company="First American"/>
        <PropsComponent title={v1} develper={v2} company={v3}/>
        <PropsComponent2 test1 ="Apples" test2="Pine Apples"  test3 ="Examples"/>
        <h2>Spread Operator Example</h2>
        <SpreadOperatorExample/>
        <h2>State Management</h2>
        <UseStateExample/>
    </div>
  )
}
export default App2
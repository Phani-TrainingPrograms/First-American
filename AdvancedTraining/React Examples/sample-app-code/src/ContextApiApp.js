import React, { useContext, useState } from 'react'
import { employees } from './MyContext';

const Post = () =>{
  // const [loading, setLoading] = useState(true);
  // const [error, setError] = useState(false);
  // const [post, setPost] = useState([]);
  const { empData, setEmpData } = useContext(employees);

  const baseUrl = "http://localhost:3000/employees"
  /*////////////////Example using useState//////////////////
  const handleFetch = ()=>{
    setLoading(true);
    setError(false);
    fetch(baseUrl)
      .then((response)=> response.json())
      .then((data)=>{
        setLoading(false);
        setPost(data);
      })
      .catch((err)=>{
        setLoading(false);
        setError(true);
      })
  }
  //////////////////////////////////////////////////////////*/
  const records = empData.map((emp)=> {
    return (
      <div>
        <h2>{emp.empName}</h2>
        <p>{emp.empAddress}</p>
        <p>{emp.empSalary}</p>
      </div>
    )
  })
  const handleFetch = () =>{
    fetch(baseUrl). then((res)=> res.json())
    .then((data)=>{
      setEmpData(data)
    })
  }
  return(
    <div>
      <h1>State Management using useContext</h1>
      <button onClick={handleFetch}>
        Fetch Records
      </button>
      <div>
        {records}
      </div>
    </div>
  )
}
function ContextApiApp() {
  const [empData, setEmpData] = useState([]);
  return (
    <div>
        <employees.Provider value={{ empData, setEmpData }}>
          <Post/>
        </employees.Provider>
    </div>
  )
}

export default ContextApiApp
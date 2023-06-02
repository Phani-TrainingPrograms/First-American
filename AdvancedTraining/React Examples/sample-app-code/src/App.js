import './App.css';
import pic1  from './images/Phaniraj.png';

const userProfile = {
  "userId" : 123,
  "userName" : "Phaniraj",
  "userAddress" : "Bangalore",
  "userIncome" : 56000,
  "userImage" : pic1
}

//////////////Profile Component///////////////////////
const Profile = () =>{
  return(
    <div className='card'>
      <h1>Details of Mr.{userProfile.userName}</h1>
      <p>
        <img className='imgCard' src={userProfile.userImage}/>
      </p>
      <hr />
      <p>{userProfile.userAddress}</p>
      <p>Rs. {userProfile.userIncome}</p>
    </div>
  )
}

//////////////////Footer Component///////////////////
const AppFooter = () =>{
  return (
    <>
      <p style={{color : 'red', fontSize: '0.8em', textAlign:'center', width:'100%', bottom:'0px', height: '30px', position: 'fixed'}}>
        <i>
          All Rights Reserved- FAI Training- 2023
        </i>
      </p>
    </>
  )
}
///////////////////ButtonComponent//////////////////////
const ButtonComponent = ()=>{
  function eventHandler(){
    alert("Button was clicked")
  }
  return(
    <>
      <button onClick={eventHandler}>Click me!!!!</button>
      <button onClick={()=>alert("This also works")}>Click me again!!!!</button>
    </>
  )
}

//////////////////Header Component//////////////////////
function AppHeader(){
  const title = "Welcome to React Training"
  const content= "This training is focused for FAI Engineers to learn React"
  return (
    <>
      <div className='App'>
        <h1>{title}</h1>
        <hr />
        <p>{content}</p>
      </div>
    </>
  )
}
//////////////////ArrayComponent////////////////////////
const trainees = [
  'Abhisek', 'Aditya', 'Sahana', 'Shivani', 'Omkar', 'Vivek', 'Veeresh', 'Himanshu'
]

function TraineeList(){
  const listItems = trainees.map((value) => <li style={{color : 'blue'}}>{value}</li>);

  return(
    <div className='card'>
      <h1>List of Trainees here!!!</h1>
      <ul style={{listStyleType : 'none'}}>{listItems}</ul>
    </div>
  )
}

///////////////////Root Component///////////////////////
function App() {
  
  return (
    <>
      <AppHeader />
      <ButtonComponent />
      <h2>Profile Details</h2>
      <Profile />
      <TraineeList />
      <AppFooter />
    </>
  );
}

export default App;

import { Navigate, Route, Routes } from 'react-router-dom';
import './App.css';
import AddContact from './Components/AddContact';
import ContactList from './Components/Contact-List';
import EditContact from './Components/EditContact';
import ViewContact from './Components/ViewContact';
import NavBar from './Components/NavBar';

function App() {
  return (
    <div className="App">
      <NavBar/>
      <Routes>
        <Route path={'/'} element={ <Navigate to={'/contacts/list'}/>}/>
        <Route path={'/contacts/list'} element={ <ContactList/> }/>
        <Route path={'/contacts/add'} element={ <AddContact/> }/>
        <Route path={'/contacts/view/:contactId'} element={ <ViewContact/>}/>
        <Route path={'/contacts/edit/:contactId'} element={ <EditContact/>}/>
      </Routes>
    </div>
  );
}

export default App;

import { Link } from "react-router-dom"

let NavBar = ()=>{
    return(
        <>
            <nav className="navbar navbar-dark bg-dark navbar-expand-sm">
                <div className="container">
                    <Link to={'/'} className='navbar-brand'>
                        View 
                        <i className="fa fa-mobile-phone text-light" aria-hidden="true"></i>
                        <span className="text-warning"> All Contacts</span>
                    </Link>
                    <Link to={'/contacts/add'} className='btn btn-success text-light m-2'>
                        Add New
                        <i className="fa fa-plus text-warning" aria-hidden="true"></i>
                        <span className="text-warning m-2">Contact</span>
                    </Link>
                </div>
            </nav>
        </>
    )
}

export default NavBar;
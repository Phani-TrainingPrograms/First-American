import React from 'react'
import { Link } from "react-router-dom";
export default function Navigation(props)
{
  return (
        <div className="col-md-2">
            <ul className='list-group'>
                <li className="list-group-item">
                    <Link to={`/contacts/edit/${props.id}`} className="btn btn-warning">
                        <i className="fa fa-pen" aria-hidden="true"></i>
                    </Link>
                </li>
                <li className="list-group-item">
                    <Link to={`/contacts/view/${props.id}`} className="btn btn-success">
                        <i className="fa fa-eye" aria-hidden="true"></i>
                    </Link>
                </li>
                <li className="list-group-item">
                    <Link to={`/contacts/delete/${props.id}`} className="btn btn-danger">
                        <i className="fa fa-trash" aria-hidden="true"></i>
                    </Link>
                </li>
            </ul>
        </div>
  )
}

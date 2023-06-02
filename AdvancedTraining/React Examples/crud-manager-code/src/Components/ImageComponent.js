
let ImageComponent = (props)=>{
    return(
        <div>
            <img className="card-img" src={process.env.PUBLIC_URL + "/Images/" + props.url} alt="Image will come"/>
        </div>
    )
}

export default ImageComponent
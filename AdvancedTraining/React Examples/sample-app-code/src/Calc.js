import React, { useState } from 'react'
import './App.css'
export default function Calc() {
    const [first, setFirst] = useState(0)
    const [second, setSecond] = useState(0)
    const [operand, setOperand] = useState("")
    const [result, setResult] = useState(0)

    //Issue: Storing multiple values is hard to maintain in real time apps...

    function getResult(ev){
        ev.preventDefault();
        switch (operand) {
            case "Add":
                setResult(parseFloat(first) + parseFloat(second));
                break;
            case "Subtract":
                setResult(first - second);
                break;
            case "Multiply":
                setResult(first * second);
                break;
            case "Divide":
                setResult(first / second);
                break;
            default:
                break;
        }
    }
  return (
    <div>
        <h1 className='App'>Calc Program</h1>
        <form>
            <div>
                Enter the First Value:
                <input type={'number'} onChange={(e) => setFirst(e.target.value)}/>
            </div>
            <div>
                Enter the Second Value:
                <input type={'number'} onChange={(e) => setSecond(e.target.value)}/>
            </div>
            <div>
                Select the Choice:
                <select onChange={(e) => setOperand(e.target.value)}>
                    <option>Add</option>
                    <option>Subtract</option>
                    <option>Multiply</option>
                    <option>Delete</option>
                </select>
            </div>
            <div>
                <button onClick={(ev) =>getResult(ev)}>Get Result</button>
            </div>
            <div>
                {result}
            </div>
        </form>
    </div>
  )
}

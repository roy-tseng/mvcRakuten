import React, {useState} from 'react'
import {GlobalParams} from '../../commonconfigs/GlobalParams'

export const AirportInfo = (props) => {

    const [propState, setPropState] = useState(props)   
    
    function showPage(){
        console.log(props.name);
    }

    return(
          <>
          <div className="cell">
             <div className="card">
                <div className="card-header">
                   <img src="./images/tw_airport.jpg"/>
                </div>
                <div className="card-content p-2">
                    <p className="fg-gray">{propState.name}</p>
                    {props.des}, {GlobalParams.AirPort.Visitors}:{props.visitors}
                </div>
                <div className="card-footer">
                    <button className="button secondary" onClick={showPage}>{GlobalParams.AirPort.Seemore}</button>
                </div>
            </div>
            </div>
          </>
    )
}
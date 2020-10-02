import React from 'react'
import {GlobalParams} from '../../commonconfigs/GlobalParams'
import {AirportInfo} from './AirportInfo'
import "./airport.scss"

export const Airport = (props) =>{

    const ports = [{'name':'桃園機場', 'des':'國際機場', 'visitors':'1250'},  {'name':'松山機場', 'des':'國際機場', 'visitors':'1250'}, {'name':'台中機場', 'des':'國際機場', 'visitors':'1250'}, {'name':'高雄機場', 'des':'國際機場', 'visitors':'1250'} ];    

    return(

        <>
            <div class="row flex-align-start">
            {
                ports.map(function(name, key) {
                    return <AirportInfo key={key} {...name}/>
                })
            }
            </div>
        </>

    )
}
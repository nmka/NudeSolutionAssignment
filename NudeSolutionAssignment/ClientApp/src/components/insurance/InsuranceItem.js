import React from 'react';
import { AiFillDelete } from "react-icons/ai";

const InsuranceItem = ({ item, deleteItem }) => {
    const handleClick = () => {
        deleteItem(item);
    }
    return <li className='insurance-item'>
        <span className='name'>{item.name}</span>
        <span className='value'>{item.value}$</span>
        <AiFillDelete className= 'clickable' onClick={handleClick}></AiFillDelete>
    </li>
}

export default InsuranceItem;
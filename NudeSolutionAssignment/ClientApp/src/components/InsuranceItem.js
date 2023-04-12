import React from 'react';

const InsuranceItem = ({ item }) => {
    return <li className='insurance-item'>
        <span className='name'>{item.name}</span> {item.value}$ <span>deleteitem</span>
    </li>
}

export default InsuranceItem;
import React from 'react';

const InsuranceItem = ({ item }) => {
    return <li>{item.id} {item.name} {item.value}</li>
}

export default InsuranceItem;
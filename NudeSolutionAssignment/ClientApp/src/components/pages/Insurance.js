
import React, { useState, useEffect } from 'react';
import services from '../../api/index'
import InsuranceItemForm from '../InsuranceItemForm';
import InsuranceItemsList from '../InsuranceItemsList';

const Insurance = () => {

    const [items, setItems] = useState(null);
    const categories = [{ name: 'Electronics', id: 1 }, { name: 'Arts', id: 2 }];

    useEffect(() => {
        if (items != null) return;
        services.insuranceService.getAllItems().then(response => {
            setItems(response);
        });
        
    })

    const addItem = (item) => {
        services.insuranceService.createItem(item).then(response => {
            setItems([...items, response]);
        })
        
    }

    return (<main>
        <InsuranceItemsList items={items}></InsuranceItemsList>
        <InsuranceItemForm addItem={addItem} categories={categories}></InsuranceItemForm>
    </main>)
}

export default Insurance;
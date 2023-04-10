
import React, { useState, useEffect } from 'react';
import { createItem } from '../../api/services/insurance-service';
import InsuranceItemForm from '../InsuranceItemForm';
import InsuranceItemsList from '../InsuranceItemsList';

const Insurance = () => {

    const [items, setItems] = useState(null);
    const categories = [{ name: 'Electronics', id: 1 }, { name: 'Arts', id: 2 }];

    useEffect(() => {
        if (items != null) return;
        fetch('item')
            .then((result) => {
                return result.json();
            })
            .then(data => {
                setItems(data);
            })
    })

    const addItem = (item) => {
        createItem(item).then(data => {
            setItems([...items, data]);
        })
    }

    return (<main>
        <InsuranceItemsList items={items}></InsuranceItemsList>
        <InsuranceItemForm addItem={addItem} categories={categories}></InsuranceItemForm>
    </main>)
}

export default Insurance;
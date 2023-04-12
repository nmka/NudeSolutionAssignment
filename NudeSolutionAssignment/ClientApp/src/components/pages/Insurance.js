
import React, { useState, useEffect } from 'react';
import services from '../../api/index'
import InsuranceItemForm from '../InsuranceItemForm';
import InsuranceCategory from '../InsuranceCategory';

const Insurance = () => {

    const [categories, setCategories] = useState(null);

    useEffect(() => {
        if (categories != null) return;
        services.insuranceService.getAllCategories().then(response => {
            setCategories(response);
            console.log('response',response)
        });

    })

    const addItem = (item) => {
        services.insuranceService.createItem(item).then(response => {
            //setItems([...items, response]);
        })

    }

    return (<main>
        
        {categories != null ? <>
            {categories.map((category) => <InsuranceCategory key={category.id} category={category}></InsuranceCategory>)}
            <InsuranceItemForm addItem={addItem} categories={categories}></InsuranceItemForm>
        </>:<div>Loading...</div>}
    </main>)
}

export default Insurance;
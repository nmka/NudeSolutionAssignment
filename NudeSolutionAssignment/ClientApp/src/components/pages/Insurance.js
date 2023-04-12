
import React, { useState, useEffect } from 'react';
import services from '../../api/index'
import InsuranceItemForm from '../InsuranceItemForm';
import InsuranceCategory from '../InsuranceCategory';

const Insurance = () => {

    const [categories, setCategories] = useState(null);

    useEffect(() => {
        if (categories != null) return;
        services.insurance.getAllCategories().then(response => {
            setCategories(response);
            console.log('response', response)
        });

    })
    const calculateCategoryTotal = (category) => {
        return category.items.reduce((sum, item) => sum + item.value, 0);
    }

    const calculateTotal = () => {
        return categories?.reduce((sum, category) => sum + calculateCategoryTotal(category), 0);
    }

    const addItem = (item) => {
        services.insurance.createItem(item).then(response => {
            let newCategories = [...categories];
            let targetCategory = newCategories.find(category => category.id === response.categoryId);
            targetCategory.items.push(response);
            setCategories([...newCategories]);

            console.log('new', newCategories);
            console.log('target', targetCategory);
        });
    }
    const deleteItem = (toDeleteItem) => {

        if (!window.confirm("Are you sure you wanna delete item?")) return;

        services.insurance.deleteItem(toDeleteItem).then(_ => {
            let newCategories = [...categories];
            let targetCategory = newCategories.find(category => category.id === toDeleteItem.categoryId);
            targetCategory.items = targetCategory.items.filter(item => item.id !== toDeleteItem.id);
            setCategories([...newCategories]);
        });
    }

    return (<main className='insurance'>

        {categories != null ? <>
            {categories.map((category) => <InsuranceCategory
                deleteItem={deleteItem}
                key={category.id}
                category={category}
                calculateCategoryTotal={calculateCategoryTotal}>
            </InsuranceCategory>)}
            <b> <span className='name'> Total </span> {calculateTotal()}$</b>
            <hr></hr>
            <InsuranceItemForm addItem={addItem} categories={categories} ></InsuranceItemForm>
        </> : <div>Loading...</div>}
    </main>)
}

export default Insurance;
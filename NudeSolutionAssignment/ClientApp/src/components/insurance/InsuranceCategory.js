import React from 'react';
import InsuranceItemsList from './InsuranceItemsList';

const InsuranceCategory = ({ category, deleteItem, calculateCategoryTotal }) => {
    
    return (<main>
        {(category != null) ?
            <div className='insurance-category'>
                <p><span className='name'>{category.name}</span>{calculateCategoryTotal(category) }$</p>
                <InsuranceItemsList key={category.id} items={category.items} deleteItem = {deleteItem}></InsuranceItemsList>
            </div>
            : <div>Loading...</div>}
            <hr></hr>
    </main>)
}

export default InsuranceCategory;
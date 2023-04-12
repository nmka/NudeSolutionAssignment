import React from 'react';
import InsuranceItemsList from './InsuranceItemsList';

const InsuranceCategory = ({ category }) => {
    const calculateTotal = (category) => {
        return category.items.reduce((sum, item) => sum + item.value, 0);
    }
    return (<main>
        {(category != null) ?
            <div className='insurance-category'>
                <p><span className='name'>{category.name}</span>{ calculateTotal(category) }$</p>
                <InsuranceItemsList key={category.id} items={category.items}></InsuranceItemsList>
            </div>
            : <div>Loading...</div>}
    </main>)
}

export default InsuranceCategory;
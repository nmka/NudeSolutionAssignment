import React from 'react';
import InsuranceItemsList from './InsuranceItemsList';

const InsuranceCategory = ({ category }) => {
    return (<main>
        {(category != null) ?
            <>
                <h4>{category.name} {category.value}</h4>
                <ul><InsuranceItemsList key={category.id} items={category.items}></InsuranceItemsList></ul>
            </>
            : <div>Loading...</div>}
    </main>)
}

export default InsuranceCategory;
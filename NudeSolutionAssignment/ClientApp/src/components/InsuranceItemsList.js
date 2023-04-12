
import React from 'react';
import InsuranceItem from './InsuranceItem'

const InsuranceItemsList = ({items}) => {
    
    return (<main>
        {(items != null) ?
            <ul>{items.map((item) => <InsuranceItem key={ item.id} item={ item }></InsuranceItem>)}</ul>
            : <div>Loading...</div>}
    </main>)
}

export default InsuranceItemsList;

import React from 'react';
import InsuranceItem from './InsuranceItem'

const InsuranceItemsList = ({items, deleteItem}) => {
    
    return (<main>
        {(items != null) ?
            <ul>{items.map((item) => <InsuranceItem key={item.id} item={item} deleteItem={deleteItem}></InsuranceItem>)}</ul>
            : <div>Loading...</div>}
    </main>)
}

export default InsuranceItemsList;
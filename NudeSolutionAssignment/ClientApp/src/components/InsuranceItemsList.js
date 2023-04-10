
import React from 'react';

const InsuranceItemsList = ({items}) => {
    
    return (<main>
        {(items != null) ?
            <ul>{items.map((item) => <li key={item.id }>{item.id} {item.name}</li>)}</ul>
            : <div>Loading...</div>}
    </main>)
}

export default InsuranceItemsList;
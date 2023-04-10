
import React, { useId, useState } from 'react';

const InsuranceItemForm = ({addItem, categories}) => {

    const [name,setName] = useState('');
    const [value, setValue] = useState(0);
    const [categoryId,setCategoryId] = useState('1');

    const submit = () => {
        addItem({ name, categoryId, value });
    }

    return (<main>

        <input name="Item Name" value={name} onChange={e => setName(e.target.value)} />
        <input name="Value" value={value} onChange={e => setValue(e.target.value)} />
        <select value={categoryId} onChange={e => setCategoryId(e.target.value)}>
            {categories.map((category) => <option key={category.id} value={category.id} > {category.name}</option >)}
        </select>
        <button onClick={submit}>Add</button>
    </main>)
}

export default InsuranceItemForm;
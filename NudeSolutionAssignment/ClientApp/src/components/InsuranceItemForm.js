
import React, { useId, useState } from 'react';

const InsuranceItemForm = ({addItem, categories}) => {

    const [name,setName] = useState('');
    const [value, setValue] = useState(0);
    const [categoryId,setCategoryId] = useState('1');

    const submit = () => {
        addItem({ name, categoryId, value });
        setName('');
        setValue('');
    }

    return (<main className ='insurance-form'>

        <input className='name-input' placeholder='name' name="Name" value={name} onChange={e => setName(e.target.value)} />
        <input className='value-input' placeholder='value'  name="Value" value={value} onChange={e => setValue(e.target.value)} />
        <select className='category-input' value={categoryId} onChange={e => setCategoryId(e.target.value)}>
            {categories.map((category) => <option key={category.id} value={category.id} > {category.name}</option >)}
        </select>
        <button className='submit-btn' onClick={submit}>Add</button>
    </main>)
}

export default InsuranceItemForm;
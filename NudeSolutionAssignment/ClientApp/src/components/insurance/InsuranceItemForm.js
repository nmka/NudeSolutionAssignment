
import React, { useState } from 'react';
import { AiFillCaretUp, AiFillCaretDown } from 'react-icons/ai'

const InsuranceItemForm = ({addItem, categories}) => {

    const [name,setName] = useState('');
    const [value, setValue] = useState(0);
    const [categoryId,setCategoryId] = useState('1');

    const submit = () => {
        addItem({ name, categoryId, value });
        setName('');
        setValue('');
    }

    const changeValueInput= (e) =>
        setValue((v) => (e.target.validity.valid ? e.target.value : v))

    const increment= () => {
        setValue(parseInt(value) + 1);
    }
    const decrement = () => {
        if(value > 0) setValue(parseInt(value) - 1);
    }

    return (<main className ='insurance-form'>

        <input
            className='name-input'
            placeholder='name'
            name="Name"
            value={name}
            onChange={e => setName(e.target.value)}
        />
        <input
            className='value-input'
            placeholder='value'
            name="Value"
            value={value}
            pattern="[0-9]*"
            onChange={e => changeValueInput(e)}
        />
        <div className='grid'>
            <AiFillCaretUp className='clickable' onClick={increment} />
            <AiFillCaretDown className='clickable' onClick={decrement} />
        </div>
        <select
            className='category-input'
            value={categoryId}
            onChange={e => setCategoryId(e.target.value)}
        >
            {categories.map((category) => <option key={category.id} value={category.id} > {category.name}</option >)}
        </select>
        <button className='submit-btn' onClick={submit}>Add</button>
    </main>)
}

export default InsuranceItemForm;
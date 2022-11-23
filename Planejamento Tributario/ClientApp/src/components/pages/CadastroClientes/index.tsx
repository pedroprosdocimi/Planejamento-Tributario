import React, { useState } from 'react'
import {
  MDBValidation,
  MDBValidationItem,
  MDBInput,
  MDBBtn,
  MDBCheckbox
} from 'mdb-react-ui-kit';

export const CadastroClientes = () => {
  const [formValue, setFormValue] = useState({
    name: '',
    documento: '',
  });

  const onChange = (e: any) => {
    setFormValue({ ...formValue, [e.target.name]: e.target.value });
  };

  return (
    <MDBValidation className='row g-2'>
      <MDBValidationItem className='col-md-4'>
        <MDBInput
          value={formValue.name}
          name='name'
          onChange={onChange}
          id='validationCustom01'
          required
          label='Nome'
        />
      </MDBValidationItem>
      <MDBValidationItem className='col-md-4'>
        <MDBInput
          value={formValue.documento}
          name='documento'
          onChange={onChange}
          id='validationCustom02'
          required
          label='Documento'
        />
      </MDBValidationItem>

      <div className='col-12'>
        <MDBBtn type='submit'>Cadastrar</MDBBtn>
      </div>
    </MDBValidation>
  )
}

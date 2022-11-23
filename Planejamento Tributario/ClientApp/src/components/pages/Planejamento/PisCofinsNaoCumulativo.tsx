import React from 'react'
import { MDBTable, MDBTableHead, MDBTableBody } from 'mdb-react-ui-kit';

export const PisCofinsNaoCumulativo = () => {
 console.log('')

  return (
    <MDBTable hover>
      <MDBTableHead>
        <tr className="table-secondary">
          <th scope='col'>Departamento</th>
          <th scope='col'>%</th>
          <th scope='col'>Receita Bruta</th>
          <th scope='col'>Pis</th>
          <th scope='col'>Cofins</th>
        </tr>
      </MDBTableHead>
      <MDBTableBody>
        <tr>
          <th scope='row'>Receita Serviços</th>
          <td>100,00%</td>
          <td>6.543.345,65</td>
          <td>40.768,89</td>
          <td>Pis</td>
        </tr>
        <tr>
          <th scope='row'>Receitas Financeiras</th>
          <td>0,00%</td>
          <td>-</td>
          <td>-</td>
          <td>-</td>
        </tr>
        <tr className="table-secondary">
          <th scope='row'>Total Receitas</th>
          <td>100,00%</td>
          <td>6.456.654,65</td>
          <td>6.456.654,65</td>
          <td>-</td>
        </tr>
        <tr>
          <th scope='row'>Descontos Adicionais</th>
          <td>0,00%</td>
          <td>-</td>
          <td>-</td>
          <td>-</td>
        </tr>
        <tr className="table-secondary">
          <th scope='row'>Receita Líquida</th>
          <td></td>
          <td>6.456.654,65</td>
          <td>6.456.654,65</td>
          <td>-</td>
        </tr>
        <tr>
          <th scope='row'>(-) Insumos/Serviços</th>
          <td>0,00%</td>
          <td>-</td>
          <td>-</td>
          <td>-</td>
        </tr>
        <tr>
          <th scope='row'>(-) Imobilizado 01/48</th>
          <td>0,00%</td>
          <td>-</td>
          <td>-</td>
          <td>-</td>
        </tr>
        <tr>
          <th scope='row'>(-) Energia Elétrica</th>
          <td>0,00%</td>
          <td>-</td>
          <td>-</td>
          <td>-</td>
        </tr>
        <tr>
          <th scope='row'>(-) Aluguel</th>
          <td>0,00%</td>
          <td>-</td>
          <td>-</td>
          <td>-</td>
        </tr>
        <tr>
          <th scope='row'>(-) Créditos Períodos Anteriores</th>
          <td>0,00%</td>
          <td>-</td>
          <td>-</td>
          <td>-</td>
        </tr>
        <tr className="table-secondary">
          <th scope='row'>Base de Cálculo PIS/Cofins</th>
          <td></td>
          <td>-</td>
          <td>-</td>
          <td>-</td>
        </tr>
      </MDBTableBody>
    </MDBTable>
  )
}

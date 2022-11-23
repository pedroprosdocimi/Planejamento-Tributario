import React, { useState } from 'react'
import {
    MDBTabs,
    MDBTabsItem,
    MDBTabsLink,
    MDBTabsContent,
    MDBTabsPane
  } from 'mdb-react-ui-kit';
import { Simulada } from './Simulada'
import { PisCofinsCumulativo } from './PisCofinsCumulativo';
import { PisCofinsNaoCumulativo } from './PisCofinsNaoCumulativo';
import { IRPresumido } from './IRPresumido';
import { IRReal } from './IRReal';
import { Comparativo } from './Comparativo';
import { Simples } from './Simples';
import { AuxiliarCustoDespesas } from './AuxiliarCustoDespesas';

export const Planejamento = () => {
    const [basicActive, setBasicActive] = useState('tab1');

    const handleBasicClick = (value: string) => {
      if (value === basicActive) {
        return;
      }
  
      setBasicActive(value);
    };

  return (
    <>
      <MDBTabs className='mb-3'>
        <MDBTabsItem>
          <MDBTabsLink onClick={() => handleBasicClick('tab1')} active={basicActive === 'tab1'}>
            Simulada
          </MDBTabsLink>
        </MDBTabsItem>
        <MDBTabsItem>
          <MDBTabsLink onClick={() => handleBasicClick('tab2')} active={basicActive === 'tab2'}>
            Pis Cofins Cumulativa
          </MDBTabsLink>
        </MDBTabsItem>
        <MDBTabsItem>
          <MDBTabsLink onClick={() => handleBasicClick('tab3')} active={basicActive === 'tab3'}>
            Pis Cofins Não Cumulativa
          </MDBTabsLink>
        </MDBTabsItem>
        <MDBTabsItem>
          <MDBTabsLink onClick={() => handleBasicClick('tab4')} active={basicActive === 'tab4'}>
            IR CSLL Presumido
          </MDBTabsLink>
        </MDBTabsItem>
        <MDBTabsItem>
          <MDBTabsLink onClick={() => handleBasicClick('tab5')} active={basicActive === 'tab5'}>
            IR CSLL Real
          </MDBTabsLink>
        </MDBTabsItem>
        <MDBTabsItem>
          <MDBTabsLink onClick={() => handleBasicClick('tab6')} active={basicActive === 'tab6'}>
            Comparativo
          </MDBTabsLink>
        </MDBTabsItem>
        <MDBTabsItem>
          <MDBTabsLink onClick={() => handleBasicClick('tab7')} active={basicActive === 'tab7'}>
            Simples
          </MDBTabsLink>
        </MDBTabsItem>
        <MDBTabsItem>
          <MDBTabsLink onClick={() => handleBasicClick('tab8')} active={basicActive === 'tab8'}>
            Auxiliar Custos Despesas
          </MDBTabsLink>
        </MDBTabsItem>
      </MDBTabs>

      <MDBTabsContent>
        <MDBTabsPane show={basicActive === 'tab1'}><Simulada /></MDBTabsPane>
        <MDBTabsPane show={basicActive === 'tab2'}><PisCofinsCumulativo /></MDBTabsPane>
        <MDBTabsPane show={basicActive === 'tab3'}><PisCofinsNaoCumulativo /></MDBTabsPane>
        <MDBTabsPane show={basicActive === 'tab4'}><IRPresumido /></MDBTabsPane>
        <MDBTabsPane show={basicActive === 'tab5'}><IRReal /></MDBTabsPane>
        <MDBTabsPane show={basicActive === 'tab6'}><Comparativo /></MDBTabsPane>
        <MDBTabsPane show={basicActive === 'tab7'}><Simples /></MDBTabsPane>
        <MDBTabsPane show={basicActive === 'tab8'}><AuxiliarCustoDespesas /></MDBTabsPane>
      </MDBTabsContent>
    </>
  )
}

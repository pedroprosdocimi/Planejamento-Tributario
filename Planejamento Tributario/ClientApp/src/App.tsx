import * as React from 'react';
import { Route } from 'react-router-dom';
import Layout from './components/Layout';
import Home from './components/Home';
import Counter from './components/pages/Counter';
import FetchData from './components/pages/FetchData';
import { Login } from './components/pages/Login';
import { Planejamento } from './components/pages/Planejamento';
import { CadastroClientes } from './components/pages/CadastroClientes';

import './custom.css'

export default () => (
    <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/counter' component={Counter} />
        <Route path='/fetch-data/:startDateIndex?' component={FetchData} />
        <Route path='/login' component={Login} />
        <Route path='/planejamento' component={Planejamento} />
        <Route path='/cadastrar' component={CadastroClientes} />
    </Layout>
);

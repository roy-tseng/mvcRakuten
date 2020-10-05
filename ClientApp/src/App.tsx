import * as React from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import Home from './components/Home';
import Counter from './components/Counter';
import FetchData from './components/FetchData';
import {Airport} from './components/Airport/Airport';
import { CPBL } from './components/baseball/cpbl/CPBL';

export default () => (
    <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/counter' component={Counter} />
        <Route path='/airports' component={CPBL} />
        <Route path='/fetch-data/:startDateIndex?' component={FetchData} />
    </Layout>
);

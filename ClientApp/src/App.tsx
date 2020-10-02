import * as React from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import Home from './components/Home';
import Counter from './components/Counter';
import FetchData from './components/FetchData';
import {Airport} from './components/Airport/Airport';

import './custom.css'

export default () => (
    <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/counter' component={Counter} />
         //if the routing name is the same as asp.net core controller routing name, asp.net controller will hanlde it.
         // because in pipeline, spa handler is behind controller
        <Route path='/airport' component={Airport} />
        <Route path='/fetch-data/:startDateIndex?' component={FetchData} />
    </Layout>
);

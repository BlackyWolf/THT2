import React, { Component } from 'react';
import { Provider } from 'react-redux';
import { ConnectedRouter } from 'connected-react-router';
import store from '../store';
import history from '../history';
import '../assets/scss/global.scss';
import App from './App.code';

class Root extends Component {
    render() {
        return (
            <Provider store={store}>
                <ConnectedRouter history={history}>
                    <App history={history} />
                </ConnectedRouter>
            </Provider>
        );
    }
}

export default Root

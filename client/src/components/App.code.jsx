import React, { Component } from 'react';
import AdminLayout from './admin/AdminLayout.ui';
import ClientLayout from './client/ClientLayout.ui';
import FrontendLayout from './frontend/FrontendLayout.ui';

class App extends Component {
    render() {
        const { history: { location } } = this.props;

        if (location.pathname.indexOf('/admin') === 0) {
            return <AdminLayout />;
        } else if (location.pathname.indexOf('/client') === 0) {
            return <ClientLayout />;
        } else {
            return <FrontendLayout />;
        }
    }
}

export default App;

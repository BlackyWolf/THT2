import React from 'react';
// import PropTypes from 'prop-types';
import adminRoutes from '../../routing/admin.routes';
import AdminContent from './AdminContent.ui';
import AdminSideBar from './AdminSideBar.ui';
import AdminTopBar from './AdminTopBar.ui';

const AdminLayoutUi = () => (
    <section className="admin-layout">
        <AdminTopBar />

        <div>
            <AdminSideBar />

            <AdminContent pages={adminRoutes} />
        </div>
    </section>
);

AdminLayoutUi.propTypes = {

};

export default AdminLayoutUi;

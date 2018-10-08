import React from 'react';
import PropTypes from 'prop-types';
import { PageView } from '../';

const AdminContent = ({ pages }) => (
    <main>
        <PageView pages={pages} />
    </main>
);

AdminContent.propTypes = {
    pages: PropTypes.array.isRequired
};

export default AdminContent;

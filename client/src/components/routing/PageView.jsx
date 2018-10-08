import React from 'react';
import PropTypes from 'prop-types';
import { Route, Switch } from 'react-router-dom';

const PageView = ({ pages }) => (
    <Switch>
        {pages.map(page => (
            <Route exact path={page.path} component={page.component} key={page.path} />
        ))}
    </Switch>
);

PageView.propTypes = {
    pages: PropTypes.array.isRequired
};

export default PageView;

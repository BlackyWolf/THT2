import React from 'react';
import { Route, Switch } from 'react-router-dom';
import PropTypes from 'prop-types';

const PageView = ({ routes }) => (
    <Switch>
        {routes.map(route => (
            <Route exact path={route.path} component={route.component} />
        ))}
    </Switch>
);

PageView.propTypes = {
    routes: PropTypes.array.isRequired
};

export default PageView;

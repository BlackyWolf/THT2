import { combineReducers } from 'redux';

// Reducers
import global from './global/reducers';

const rootReducer = combineReducers({
    global
});

export default rootReducer;

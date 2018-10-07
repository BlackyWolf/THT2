import {
    TOGGLE_LOADER
} from './types';

const initial = {
    showLoader: false
};

export default function (state = initial, action) {
    switch (action.type) {
        case TOGGLE_LOADER:
            return Object.assign({}, state, {
                showLoader: action.payload
            });

        default:
            return state;
    }
}

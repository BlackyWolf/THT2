import {
    TOGGLE_LOADER
} from './types';

export const toggleLoader = (showLoader) => ({
    type: TOGGLE_LOADER,
    payload: showLoader
});

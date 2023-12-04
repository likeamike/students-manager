import { configureStore } from '@reduxjs/toolkit';
import { setupListeners } from '@reduxjs/toolkit/query';
import { studentsApi } from '../services/students';
import { studentsGroupsApi } from '../services/studentsGroups';

export const store = configureStore({
    reducer: {
        [studentsApi.reducerPath]: studentsApi.reducer,
        [studentsGroupsApi.reducerPath]: studentsGroupsApi.reducer,
    },
    middleware: (getDefaultMiddleware) =>
        getDefaultMiddleware()
            .concat(studentsApi.middleware)
            .concat(studentsGroupsApi.middleware),
});

setupListeners(store.dispatch);

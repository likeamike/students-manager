import { createApi, fetchBaseQuery } from '@reduxjs/toolkit/query/react';
import { Group } from '../types/types';

export const studentsGroupsApi = createApi({
    reducerPath: 'studentsGroupsApi',
    baseQuery: fetchBaseQuery({ baseUrl: 'api/studentsGroups' }),
    tagTypes: ['studentsGroup'],
    endpoints: (builder) => ({
        getStudentsGroups: builder.query<Group[], void>({
            query: () => '/',
            providesTags: ["studentsGroup"]
        })
    })
})

export const { 
    useGetStudentsGroupsQuery
} = studentsGroupsApi;

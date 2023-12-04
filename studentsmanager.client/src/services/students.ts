import { createApi, fetchBaseQuery } from '@reduxjs/toolkit/query/react';
import { Student } from '../types/types';

export const studentsApi = createApi({
    reducerPath: 'studentsApi',
    baseQuery: fetchBaseQuery({ baseUrl: 'api/students' }),
    tagTypes: ['student'],
    endpoints: (builder) => ({
        getStudents: builder.query<Student[], void>({
            query: () => '/',
            providesTags: ["student"],
        }),
        deleteStudent: builder.mutation<void, string>({
            query: (id: string) => {
                return {
                    url: `/${id}`,
                    method: 'DELETE'
                }
            },
            invalidatesTags: ["student"],
        }),
        updateStudent: builder.mutation<void, Student>({
            query: (student) => {
                return {
                    url: `/${student.id}`,
                    method: 'PUT',
                    body: student
                }
            },
            invalidatesTags: ["student"],
        }),
        createStudent: builder.mutation<void, Student>({
            query: (student) => {
                return {
                    url: '/',
                    method: 'POST',
                    body: student
                }
            },
            invalidatesTags: ["student"],
        }),
    })
})

export const { 
    useGetStudentsQuery, 
    useDeleteStudentMutation,
    useUpdateStudentMutation,
    useCreateStudentMutation,
} = studentsApi;

import { useDeleteStudentMutation, useGetStudentsQuery, useUpdateStudentMutation } from "../../services/students";
import { StudentRow } from "./StudentRow/StudentRow";

export const StudentsTable = () => {
    const { data: students } = useGetStudentsQuery();
    const [deleteStudent] = useDeleteStudentMutation();
    const [updateStudent] = useUpdateStudentMutation();

    if (!students) {
        return (
            <p>
                <em>
                    Loading... Please refresh once the ASP.NET backend has started.
                    See <a href="https://aka.ms/jspsintegrationreact">https://aka.ms/jspsintegrationreact</a> for more details.
                </em>
            </p>);
    }

    return (
        <table className="table table-striped" aria-labelledby="tabelLabel">
            <thead>
                <tr>
                    <th>Student Name</th>
                    <th>Birth Date</th>
                    <th>Gender</th>
                    <th>Group Name</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
                {students.map(student => <StudentRow
                    key={student.id}
                    student={student}
                    onDelete={deleteStudent}
                    onUpdate={updateStudent}
                />)}
            </tbody>
        </table>);
}

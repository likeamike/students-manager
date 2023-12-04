import { useCallback, useState } from "react";
import { Student } from "../../../types/types";
import { Modal } from "../../Modal/Modal";
import { StudentEditForm } from "../../StudentEditForm/StudentEditForm";
import './StudentRow.css';

interface StudentRowProps {
    student: Student,
    onDelete: (id: string) => void,
    onUpdate: (student: Student) => void,
}

export const StudentRow = ({ student, onDelete, onUpdate }: StudentRowProps) => {
    const [isEditOpen, setIsEditOpen] = useState<boolean>(false);

    const editCloseHandler = useCallback(() => {
        setIsEditOpen(false);
    }, [setIsEditOpen]);

    const editSaveHandler = useCallback((student: Student) => {
        onUpdate(student);
        editCloseHandler();
    }, [editCloseHandler, onUpdate])

    const deleteHandler = () => {
        const isConfirmed = confirm(`Do you really want to delete the ${student.firstName} ${student.lastName}?`);
        isConfirmed && onDelete(student.id);
    }

    return (
        <tr>
            <td>{student.firstName} {student.lastName}</td>
            <td>{student.birthDate}</td>
            <td>{student.gender}</td>
            <td>{student.group?.name}</td>
            <td className="actions">
                <a onClick={() => setIsEditOpen(true)}>Edit</a>
                <a onClick={deleteHandler}>Delete</a>
            </td>
            <Modal
                title={`Edit record for ${student.firstName} ${student.lastName}`}
                modalWrapperId="student-row-edit-modal"
                isOpen={isEditOpen}
                onClose={editCloseHandler}>
                <StudentEditForm
                    student={student}
                    onClose={editCloseHandler}
                    onSave={editSaveHandler} />
            </Modal>
        </tr>
    );
}

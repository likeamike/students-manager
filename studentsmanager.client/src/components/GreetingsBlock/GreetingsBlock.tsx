import { useCallback, useState } from 'react';
import { useCreateStudentMutation } from '../../services/students';
import { Student } from '../../types/types';
import { Modal } from '../Modal/Modal';
import { StudentEditForm } from '../StudentEditForm/StudentEditForm';

export const GreetingsBlock = () => {
    const [isAddFormOpen, setIsAddFormOpen] = useState<boolean>(false);
    const [createStudent] = useCreateStudentMutation();

    const addFormCloseHandler = useCallback(() => {
        setIsAddFormOpen(false);
    }, [setIsAddFormOpen]);

    const addFormSaveHandler = useCallback((student: Student) => {
        createStudent(student);
        addFormCloseHandler();
    }, [addFormCloseHandler, createStudent])

    return (
        <>
            <p>This application enables you to read, edit, delete, and
                <a onClick={() => setIsAddFormOpen(true)}> add new students</a>.
            </p>
            <Modal
                title={`Add new student`}
                modalWrapperId="add-student-modal"
                isOpen={isAddFormOpen}
                onClose={addFormCloseHandler}>
                <StudentEditForm
                    student={{} as Student}
                    onClose={addFormCloseHandler}
                    onSave={addFormSaveHandler} />
            </Modal>
        </>
    );
}

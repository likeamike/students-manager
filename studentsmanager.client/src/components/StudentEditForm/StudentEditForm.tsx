import { useCallback, useRef } from 'react';
import { Group, Student } from '../../types/types';
import { cloneDeep } from 'lodash-es';
import { StudentsGroupSelector } from './StudentsGroupSelector/StudentsGroupSelector';
import './StudentEditForm.css';

interface StudentEditFormProps {
    student: Student,
    onClose: () => void,
    onSave: (student: Student) => void,
}

export const StudentEditForm = ({ student, onClose, onSave }: StudentEditFormProps) => {
    const studentRef = useRef<Student>(cloneDeep(student));

    const formChangeHandler = ({ target }: React.ChangeEvent<HTMLFormElement>) => {
        const { value, name } = target;

        if (name === 'groupId') {
            if (!value) {
                studentRef.current.group = null;    
            } else {
                studentRef.current.group = {
                    id: value,
                } as Group;
            }
        } else {
            studentRef.current[name as keyof typeof studentRef.current] = value;
        }
    }

    const formSaveHandler = useCallback(() => {
        onSave(studentRef.current);
    }, [onSave, studentRef]);

    return (
        <div className="edit-content">
            <form className="student-edit-fields" onChange={formChangeHandler}>
                <label>
                    <span>First Name:</span>
                    <input type="text" name='firstName'
                        defaultValue={studentRef.current.firstName}
                    />
                </label>
                <label>
                    <span>Last Name:</span>
                    <input type="text" name='lastName'
                        defaultValue={studentRef.current.lastName}
                    />
                </label>
                <label>
                    <span>Birth Date:</span> 
                    <input type="date" name='birthDate'
                        defaultValue={studentRef.current.birthDate?.substring(0, 10)}
                    />
                </label>
                <label>
                    <span>Gender:</span>
                    <select defaultValue={studentRef.current.gender} name='gender'>
                        <option value="Male">Male</option>
                        <option value="Female">Female</option>
                        <option value="NonBinary">Non-binary</option>
                    </select>
                </label>
                <StudentsGroupSelector defaultGroupId={studentRef.current.group?.id} />
            </form>
            <div className="controll-buttons">
                <button className='save' onClick={formSaveHandler}>
                    Save
                </button>
                <button className='cancel' onClick={() => onClose()}>
                    Cancel
                </button>
            </div>
        </div>
    );
}

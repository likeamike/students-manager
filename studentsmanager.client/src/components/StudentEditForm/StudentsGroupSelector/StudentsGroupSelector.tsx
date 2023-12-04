import { useGetStudentsGroupsQuery } from "../../../services/studentsGroups";

interface StudentsGroupSelectorProps {
    defaultGroupId?: string,
}

export const StudentsGroupSelector = ({ defaultGroupId }: StudentsGroupSelectorProps) => {
    const { data: groups } = useGetStudentsGroupsQuery();

    return (
        <label>
            <span>Group:</span>
            {groups && (
                <select defaultValue={defaultGroupId} name="groupId">
                    <option key='undefined' value={undefined}></option>
                    {groups.map(g => <option key={g.id} value={g.id}>{g.name}</option>)}
                </select>
            )}
        </label>
    );
}

export interface Student {
    id: string;
    firstName: string;
    lastName: string;
    birthDate: string;
    gender: Gender;
    group: Group | null;
}

export interface Group {
    id: string;
    name: string;
}

export type Gender = "Male" | "Female" | "NonBinary";

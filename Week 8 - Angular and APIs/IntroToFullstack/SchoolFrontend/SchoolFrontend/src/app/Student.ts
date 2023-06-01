// To parse this data:
//
//   import { Convert, Student } from "./file";
//
//   const student = Convert.toStudent(json);

//Remember this model needs to match the spelling and casing of what the C# API has in its JSON 
export interface Student {
    id:           number;
    name:         string;
    age:          number;
    averageGrade: number;
    isPassing:    boolean;
}

// Converts JSON strings to/from your types
export class Convert {
    public static toStudent(json: string): Student {
        return JSON.parse(json);
    }

    public static studentToJson(value: Student): string {
        return JSON.stringify(value);
    }
}

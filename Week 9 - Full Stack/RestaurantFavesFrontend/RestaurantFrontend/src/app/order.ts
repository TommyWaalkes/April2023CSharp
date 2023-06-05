// To parse this data:
//
//   import { Convert, Order } from "./file";
//
//   const order = Convert.toOrder(json);

//This model needs to match the spelling and casing of the C# API 
//The C# model needs to match the SQL database
export interface Order {
    id:          number;
    description: string;
    restaurant:  string;
    rating:      number;
    orderAgain:  boolean;
}

// Converts JSON strings to/from your types
export class Convert {
    public static toOrder(json: string): Order {
        return JSON.parse(json);
    }

    public static orderToJson(value: Order): string {
        return JSON.stringify(value);
    }
}

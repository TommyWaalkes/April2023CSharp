//The properties in this model for our API, needs to match the spelling and casing of our API 
//And not Typescript conventions, this is a case where we have to ignore those conventions

// To parse this data:
//
//   import { Convert, MovieDetails } from "./file";
//
//   const movieDetails = Convert.toMovieDetails(json);

export interface MovieDetails {
    Title:      string;
    Year:       string;
    Rated:      string;
    Released:   string;
    Runtime:    string;
    Genre:      string;
    Director:   string;
    Writer:     string;
    Actors:     string;
    Plot:       string;
    Language:   string;
    Country:    string;
    Awards:     string;
    Poster:     string;
    Ratings:    Rating[];
    Metascore:  string;
    imdbRating: string;
    imdbVotes:  string;
    imdbID:     string;
    Type:       string;
    DVD:        string;
    BoxOffice:  string;
    Production: string;
    Website:    string;
    Response:   string;
}

export interface Rating {
    Source: string;
    Value:  string;
}

// Converts JSON strings to/from your types
export class ConvertDetails {
    public static toMovieDetails(json: string): MovieDetails {
        return JSON.parse(json);
    }

    public static movieDetailsToJson(value: MovieDetails): string {
        return JSON.stringify(value);
    }
}


// To parse this data:
//
//   import { Convert, MovieResults } from "./file";
//
//   const movieResults = Convert.toMovieResults(json);

export interface MovieResults {
    Search:       Search[];
    totalResults: string;
    Response:     string;
}

export interface Search {
    Title:  string;
    Year:   string;
    imdbID: string;
    Type:   Type;
    Poster: string;
}

export enum Type {
    Movie = "movie",
}

// Converts JSON strings to/from your types
export class ConvertResult {
    public static toMovieResults(json: string): MovieResults {
        return JSON.parse(json);
    }

    public static movieResultsToJson(value: MovieResults): string {
        return JSON.stringify(value);
    }
}

import axios from "axios";

export interface IMenu {
  name: string;
  ingredients: string;
  type: string;
  price: number;
}

export interface SearchResponse {
  data: IMenu[];
}

export const search = async (url: string) => {
  try {
    const data = await axios.get<SearchResponse>(
      `http://localhost:5144/api/${url}`
    );
    return data;
  } catch (error) {
    if (axios.isAxiosError(error)) {
      console.log("error message: ", error.message);
      return error.message;
    } else {
      console.log("unexpected error");
      return "an unexpected error";
    }
  }
};

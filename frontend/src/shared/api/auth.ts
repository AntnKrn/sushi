import axios from "axios";

import { IUserLoginResponse } from "../interfaces/IUser";

export const login = async (login: string, password: string) => {
  try {
    console.log(login, password);
    const response = await axios.post<IUserLoginResponse>(
      `http://localhost:5144/api/account/login`,
      {
        userName: login,
        password: password,
      }
    );
    console.log(response.data.token);
    document.cookie = "Bearer=" + response.data.token;
    console.log(document.cookie);
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

import axios from "axios";

import { IUserLoginResponse } from "../interfaces/IUser";
import { setCookieByNameAndValue } from "../helpers/cookie.helper";

export const login = async (login: string, password: string) => {
  try {
    const response = await axios.post<IUserLoginResponse>(
      `http://localhost:5144/api/account/login`,
      {
        userName: login,
        password: password,
      }
    );
    setCookieByNameAndValue("Bearer", response.data.token);
  } catch (error) {
    if (axios.isAxiosError(error)) {
      throw Error(error.message);
    } else {
      throw Error("an unexpected error");
    }
  }
};

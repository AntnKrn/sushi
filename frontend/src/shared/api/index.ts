import axios from "axios";
import { getCookieByName } from "../helpers/cookie.helper";

export const client = axios.create({
  baseURL: "http://localhost:5144",
  headers: {
    Authorization: "Bearer" + getCookieByName("Bearer") || "",
  },
});

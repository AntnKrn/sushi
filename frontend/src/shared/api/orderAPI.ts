import {
  AxiosRequestConfig,
  AxiosResponse,
  RawAxiosRequestHeaders,
} from "axios";
import { ICreateOrder } from "../interfaces/ICreateOrder";
import { client } from "./index";

export const post = async (url: string, createData: ICreateOrder) => {
  const config: AxiosRequestConfig = {
    headers: {
      Accept: "*",
      ContentType: "application/json",
    } as RawAxiosRequestHeaders,
  };
  try {
    const response: AxiosResponse = await client.post(url, createData, config);
    console.log(response);
  } catch (err) {
    console.log(err);
  }
};

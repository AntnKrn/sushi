export interface IUserLogin {
  login: string;
  password: string;
}

export interface IUserLoginResponse {
  userName: string;
  email: string;
  token: string;
}

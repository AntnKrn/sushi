import React, { useEffect, useState } from "react";
import "./index.scss";
import { AuthInput } from "../../../entities/authInput";
import { login } from "../../../shared/api/auth";
import { Navigate } from "react-router";
import { useSelector } from "react-redux";
import { RootState } from "../../../shared/store/store";

export const Authorization = () => {
  const [currentLogin, setCurrentLogin] = useState<string>("");
  const [currentPassword, setCurrentPassword] = useState<string>("");
  const [isRegistration, setIsRegistration] = useState<boolean>(false);

  const [rightLoginData, setRightLoginData] = useState<boolean>(
    useSelector((state: RootState) => state.chechAuth.value)
  );

  if (rightLoginData) return <Navigate replace to="/account" />;

  const onChangeLogin = (e: React.ChangeEvent<HTMLInputElement>) => {
    setCurrentLogin(e.target.value);
  };
  const onChangePassword = (e: React.ChangeEvent<HTMLInputElement>) => {
    setCurrentPassword(e.target.value);
  };
  const onClickSubmit = async () => {
    try {
      await login(currentLogin, currentPassword);
      setRightLoginData((prev) => !prev);
    } catch (err) {
      const inputs = Array.from(
        document.getElementsByClassName(
          "auth-input"
        ) as HTMLCollectionOf<HTMLElement>
      );
      inputs.forEach((element) => {
        element.style.borderColor = "red";
      });
    }
  };

  return (
    <div id="auth-wrapper">
      <h6>{isRegistration ? "Registration" : "Authorization"}</h6>
      <div className="auth-inside">
        <div className="auth-inputs">
          <AuthInput
            name="login"
            type="text"
            placeholder="Login"
            value={currentLogin}
            onChangeValue={onChangeLogin}
          />
          <AuthInput
            name="password"
            type="password"
            placeholder="Password"
            value={currentPassword}
            onChangeValue={onChangePassword}
          />
        </div>
        <div className="auth-btns">
          <button onClick={onClickSubmit}>
            {isRegistration ? "Sign up" : "Sign in"}
          </button>
          <button onClick={() => setIsRegistration((prev) => !prev)}>
            {isRegistration ? "Sign in" : "Sign up"}
          </button>
        </div>
      </div>
    </div>
  );
};

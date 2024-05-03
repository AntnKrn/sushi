import React, { useEffect, useState } from "react";
import "./index.scss";
import { AuthInput } from "../../../entities/authInput";
import { login } from "../../../shared/api/auth";

interface IAthorizationProps {
  onClose: () => void;
}
export const Authorization = ({ onClose }: IAthorizationProps) => {
  const [currentLogin, setCurrentLogin] = useState<string>("");
  const [currentPassword, setCurrentPassword] = useState<string>("");

  const onChangeLogin = (e: React.ChangeEvent<HTMLInputElement>) => {
    setCurrentLogin(e.target.value);
  };
  const onChangePassword = (e: React.ChangeEvent<HTMLInputElement>) => {
    setCurrentPassword(e.target.value);
  };
  const onClickSubmit = () => {
    login(currentLogin, currentPassword);
  };

  return (
    <div className="auth-window">
      <button onClick={() => onClose()}>Close</button>
      <h6>Authorization</h6>
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
          type="text"
          placeholder="Password"
          value={currentPassword}
          onChangeValue={onChangePassword}
        />
      </div>
      <button onClick={onClickSubmit}>Sign in</button>
      <button>Register</button>
    </div>
  );
};

import React from "react";
import "./index.scss";

interface IPropsAuthInput {
  name: string;
  type: string;
  placeholder: string;
  value: string;
  onChangeValue: (e: React.ChangeEvent<HTMLInputElement>) => void;
}

export const AuthInput = ({
  name,
  type,
  placeholder,
  value,
  onChangeValue,
}: IPropsAuthInput) => {
  return (
    <input
      className="auth-input"
      name={name}
      type={type}
      placeholder={placeholder}
      value={value}
      onChange={onChangeValue}
    />
  );
};

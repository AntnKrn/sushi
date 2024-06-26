import React from "react";
import { inherits } from "util";
import "./index.scss";
interface IContactsInputProps {
  name: string;
}
export const ContactsInput = ({ name }: IContactsInputProps) => {
  return (
    <>
      <label style={{ marginBottom: "3px", color: "#212529", width: "100px" }}>
        {name}
      </label>
      <input className="contacts-input" />
    </>
  );
};

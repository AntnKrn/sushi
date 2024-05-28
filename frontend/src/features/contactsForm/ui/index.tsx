import React from "react";
import { ContactsInput } from "../../../entities/ContactsInput/ui";
import "./index.scss";
export const ContactsForm = () => {
  return (
    <div id="contacts-form-container">
      <div id="contacts-description">
        <h6>CONTACTS</h6>
        <h3>Any questions?</h3>
        <p>Please, give us ur data. We will call back.</p>
      </div>

      <form>
        <div style={{ display: "flex", flexDirection: "column" }}>
          <ContactsInput name={"Name"} />
          <ContactsInput name="E-mail" />
          <ContactsInput name="Phone" />
          <ContactsInput name="Message" />
        </div>

        <div id="btns-form">
          <button
            style={{
              color: "black",
              backgroundColor: "inherit",
              textAlign: "left",
            }}
          >
            Clear
          </button>
          <button style={{ color: "white", backgroundColor: "#007bff" }}>
            Send
          </button>
        </div>
      </form>
    </div>
  );
};

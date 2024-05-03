import React from "react";
import "./index.scss";
import { Header } from "../../../widgets/header";
import { Footer } from "../../../widgets/footer";
import { AuthInput } from "../../../entities/authInput";

export const AuthorizationPage = () => {
  return (
    <div>
      <Header />
      {/*       <AuthInput />
       */}
      <Footer />
    </div>
  );
};

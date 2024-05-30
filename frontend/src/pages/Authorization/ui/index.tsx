import React from "react";
import { Header } from "../../../widgets/header";
import { Footer } from "../../../widgets/footer";
import { Authorization } from "../../../widgets/authorization";

export const AuthorizationPage = () => {
  return (
    <>
      <Header />
      <Authorization />
      <Footer />
    </>
  );
};

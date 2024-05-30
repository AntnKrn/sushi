import React from "react";
import { AuthorizationPage } from "../../Authorization/ui";
import { Navigate } from "react-router";

export const AccountPage = () => {
  if (document.cookie === "") return <Navigate to="/authorization" />;
  return <div>account info</div>;
};

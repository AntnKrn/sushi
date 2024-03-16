import React from "react";
import { Navigation } from "../../../features/navigation";
import { Contacts } from "../../../features/contacts";

export const Header = () => {
  return (
    <header>
      <Navigation />
      <Contacts />
    </header>
  );
};

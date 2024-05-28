import React from "react";
import { Header } from "../../../widgets/header";
import { Footer } from "../../../widgets/footer";
import img1 from "./banner-kontacts.jpg";
import { ContactsForm } from "../../../features/contactsForm/ui";
import { MapGoogle } from "../../../shared/ui/map";

export const ContactsPage = () => {
  return (
    <>
      <Header />
      <img src={img1} style={{ maxWidth: "100%", height: "auto" }} />
      <ContactsForm />
      <MapGoogle />
      <Footer />
    </>
  );
};

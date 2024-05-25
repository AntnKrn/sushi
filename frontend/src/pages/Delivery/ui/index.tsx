import React from "react";
import "./index.scss";
import { Header } from "../../../widgets/header";
import { Footer } from "../../../widgets/footer";
import { DeliveryBanner } from "../../../entities/deliveryBanner/ui";
import { AboutDelivery } from "../../../widgets/aboutDelivery/ui";
import { MapGoogle } from "../map";

export const DeliveryPage = () => {
  return (
    <>
      <Header />
      <DeliveryBanner />
      <AboutDelivery />
      <MapGoogle />
      <Footer />
    </>
  );
};

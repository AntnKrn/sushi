import React from "react";

import "./BusketPage.scss";
import { Header } from "../../../widgets/header";
import { Footer } from "../../../widgets/footer";
import { Cart } from "../../../features/cart/ui";
export const BusketPage = () => {
  return (
    <div>
      <Header />
      <Cart />
      <Footer />
    </div>
  );
};

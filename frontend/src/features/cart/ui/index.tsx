import React from "react";
import "./index.scss";

import { BusketList } from "../../../widgets/BusketList/ui";
export const Cart = () => {
  return (
    <div className="cart-wrapper">
      <h6>Cart</h6>
      <div className="cart-inner">
        <h6>Cart</h6>
        {localStorage.getItem("cart") === null ||
        JSON.parse(localStorage.getItem("cart")!)?.length === 0 ? (
          <div className="cart-empty">
            <p>Your cart is empty</p>
          </div>
        ) : (
          <BusketList />
        )}
      </div>
    </div>
  );
};

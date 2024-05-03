import React from "react";
import "./index.scss";
import { CartItem } from "../../../entities/cartItem/ui";
export const BusketList = () => {
  return (
    <div>
      <div>
        <CartItem />
        <CartItem />
        <CartItem />
        <CartItem />
        <CartItem />
      </div>
      <p>Total price: 12 020P</p>
      <div id="cart-choice">
        <p>Continue shopping</p>
        <p>Checkout</p>
      </div>
    </div>
  );
};

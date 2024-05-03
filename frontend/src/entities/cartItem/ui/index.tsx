import React from "react";
import img1 from "../../menuItem/ui/img1.jpg";
import "./index.scss";

export const CartItem = () => {
  return (
    <div className="cart-item">
      <div>
        <img src={img1} width={"80px"} height={"80px"} />
      </div>
      <p>Party de lux</p>
      <p>6700P</p>
      <div className="counter">
        <input defaultValue={1} />
        <button className="quantity-input-btn-up">+</button>
        <button className="quantity-input-btn-down">-</button>
      </div>

      <p id="delete">Delete</p>
    </div>
  );
};

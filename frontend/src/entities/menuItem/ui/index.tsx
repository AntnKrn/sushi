import React from "react";
import "./index.scss";
import img1 from "./img1.jpg";

interface MenuItemProp {
  name: string;
  ingredients: string;
  price: number;
}

export const MenuItem = ({ name, ingredients, price }: MenuItemProp) => {
  return (
    <div className="menu-item">
      <img src={img1} className="menu-item-img" />
      <h1>{name}</h1>
      <p style={{ textAlign: "left" }}>{ingredients}</p>
      <div
        style={{
          display: "flex",
          justifyContent: "space-between",
          width: "100%",
          bottom: "2em",
          position: "absolute",
        }}
      >
        <span>{price} Р</span>
        <button>+</button>
      </div>
    </div>
  );
};

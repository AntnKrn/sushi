import React from "react";
import "./index.scss";
import { useDispatch } from "react-redux";
import { increment } from "../../../shared/store/counterCart/counterCart";

interface MenuItemProp {
  id: number;
  name: string;
  ingredients: string;
  price: number;
  imgUrl: string;
}

export const MenuItem = ({
  id,
  name,
  ingredients,
  price,
  imgUrl,
}: MenuItemProp) => {
  const dispatch = useDispatch();
  const addMenuItemToCart = () => {
    dispatch(increment(id));
  };
  return (
    <div className="menu-item">
      <img src={imgUrl} alt={name} className="menu-item-img" />
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
        <button onClick={addMenuItemToCart}>+</button>
      </div>
    </div>
  );
};

import React, { useState } from "react";
import "./index.scss";

interface Props {
  id: number;
  quantity: number;
  name: string;
  img: string;
  price: number;
}

export const CartItem = ({ name, img, price, quantity, id }: Props) => {
  const [quantityState, setQuantityState] = useState(quantity);

  const changeQuantityInLocalStorage = (
    action: string,
    e?: React.ChangeEvent<HTMLInputElement>
  ) => {
    let store = JSON.parse(window.localStorage.getItem("cart")!);
    const productId = store.find((item: any) => item.idItem === id);
    if (action === "addOne") {
      productId.quantity += 1;
      setQuantityState((prev: number) => prev + 1);
    } else if (action === "decOne") {
      if (quantityState === 0) return;
      productId.quantity -= 1;
      setQuantityState((prev: number) => prev - 1);
    } else if (action === "change") {
      const value = Number(e?.target.value);
      if (value >= 0 && value < 100) {
        productId.quantity = value;
        setQuantityState(value);
      }
    }

    localStorage.setItem("cart", JSON.stringify(store));
  };

  const deleteProductFromLocalStorage = () => {
    console.log("yaa");
    let store = JSON.parse(window.localStorage.getItem("cart")!);
    store = store.filter((item: any) => item.idItem !== id);
    localStorage.setItem("cart", JSON.stringify(store));
    window.location.reload();
  };

  return (
    <div className="cart-item">
      <div>
        <img src={img} alt="" width={"80px"} height={"80px"} />
      </div>
      <p>{name}</p>
      <p>{price}P</p>
      <div className="counter">
        <input
          value={quantityState}
          onChange={(e) => {
            changeQuantityInLocalStorage("change", e);
          }}
        />
        <button
          className="quantity-input-btn-up"
          onClick={() => {
            changeQuantityInLocalStorage("addOne");
          }}
        >
          +
        </button>
        <button
          className="quantity-input-btn-down"
          onClick={() => {
            changeQuantityInLocalStorage("decOne");
          }}
        >
          -
        </button>
      </div>

      <p id="delete" onClick={() => deleteProductFromLocalStorage()}>
        Delete
      </p>
    </div>
  );
};

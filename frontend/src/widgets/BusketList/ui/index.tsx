import React, { useEffect, useState } from "react";
import "./index.scss";
import { CartItem } from "../../../entities/cartItem/ui";

interface ICartLocalStore {
  name: string;
  idItem: number;
  quantity: number;
  imgUrl: string;
  price: number;
}

export const BusketList = () => {
  const [cartItems, setCartItems] = useState<any>([]);
  const [loading, setLoading] = useState<boolean>(false);

  useEffect(() => {
    const ids = JSON.parse(localStorage.getItem("cart")!) || null;
    const arrayLinks: { link: string; quantity: number; idItem: number }[] = [];
    ids.forEach((item: ICartLocalStore) => {
      let link: string = `http://localhost:5144/api/menu/${item.idItem}`;
      console.log(item);
      arrayLinks.push({
        link: link,
        quantity: item.quantity,
        idItem: item.idItem,
      });
    });

    async function fetchData(url: string) {
      const response = await fetch(url);
      if (!response.ok) {
        throw new Error(`Ошибка загрузки данных: ${response.statusText}`);
      }
      return await response.json();
    }

    async function loadData() {
      try {
        const results = await Promise.all(
          arrayLinks.map(async (item) => {
            const response = await fetchData(item.link);
            response.quantity = item.quantity;
            response.idItem = item.idItem;
            return response;
          })
        );

        setCartItems(results);
        setLoading(false);
      } catch (error) {
        setLoading(false);
      }
    }
    loadData();
  }, []);
  return (
    <div>
      <div>
        {loading === false && JSON.parse(localStorage.getItem("cart")!) !== null
          ? cartItems.map((item: ICartLocalStore, index: number) => {
              return (
                <CartItem
                  key={index}
                  name={item.name}
                  price={item.price}
                  quantity={item.quantity}
                  img={item.imgUrl}
                  id={item.idItem}
                />
              );
            })
          : null}
      </div>
      <p>Total price: 12 020P</p>
      <div id="cart-choice">
        <p>Continue shopping</p>
        <p>Checkout</p>
      </div>
    </div>
  );
};

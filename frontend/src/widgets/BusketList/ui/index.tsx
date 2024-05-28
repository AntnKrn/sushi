import React, { useEffect, useState } from "react";
import "./index.scss";
import { CartItem } from "../../../entities/cartItem/ui";
import { ICreateOrder } from "../../../shared/interfaces/ICreateOrder";
import { post } from "../../../shared/api/orderAPI";

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
  const sendOrderToServer = async () => {
    const data: ICreateOrder = {
      clientId: null,
      date: new Date(),
      totalPrice: 55,
      status: "Готовится",
      orderItems: [],
    };
    let localstorage = JSON.parse(window.localStorage.getItem("cart")!);
    localstorage.forEach((el: any) => {
      data.orderItems.push({
        menuId: el.idItem,
        quantity: el.quantity,
        subSum: 1,
      });
    });

    await post("/api/orders", data);
  };
  useEffect(() => {
    const ids = JSON.parse(localStorage.getItem("cart")!) || null;
    const arrayLinks: { link: string; quantity: number; idItem: number }[] = [];
    ids.forEach((item: ICartLocalStore) => {
      let link: string = `http://localhost:5144/api/menu/${item.idItem}`;
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
        <a href="/products">Continue shopping</a>
        <p onClick={() => sendOrderToServer()}>Checkout</p>
      </div>
    </div>
  );
};

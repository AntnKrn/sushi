import React from "react";
import "./index.scss";
import { AboutDeliveryItem } from "../../../entities/aboutDeliveryItem/ui";

import img1 from "../imgs/mask.svg";
import img2 from "../imgs/24.svg";
import img3 from "../imgs/timer.svg";
import img4 from "../imgs/delivery.svg";
import img5 from "../imgs/clock.svg";
import img6 from "../imgs/bag.svg";
import img7 from "../imgs/cash.svg";
import img8 from "../imgs/card.svg";
import img9 from "../imgs/kassa.svg";
import img10 from "../imgs/payment.svg";

interface IAboutDeliveryItem {
  img: string;
  name: string;
  description: string;
}

const items: IAboutDeliveryItem[][] = [
  [
    {
      img: img1,
      name: "Safely securely",
      description:
        "We check all our staff every day. We have thorough disinfection and contactless delivery.",
    },
    {
      img: img2,
      name: "40 minutes",
      description:
        "We will deliver the order in 40 minutes. One in three orders are delivered sooner.",
    },
    {
      img: img3,
      name: "24-hour",
      description: "We work without days off, 24 hours a day.",
    },
  ],
  [
    {
      img: img4,
      name: "Delivery to your door",
      description:
        "The courier will deliver your order within 40 minutes to your door.",
    },
    {
      img: img5,
      name: "Fast delivery",
      description:
        "Choose one of the ready-made kits and it will be delivered within 30 minutes.",
    },
    {
      img: img6,
      name: "Take it with you",
      description:
        "Get a 20% discount by picking up your order at the restaurant.",
    },
  ],
  [
    {
      img: img7,
      name: "Cash",
      description: "Pay in cash to the courier or at the establishment itself.",
    },
    {
      img: img8,
      name: "By card online",
      description:
        "Pay for your order on the website using Visa, MasterCard, MIR cards.",
    },
    {
      img: img9,
      name: "Card upon receipt",
      description:
        "Pay for your order with a Visa, MasterCard, MIR bank card when receiving your order.",
    },
    {
      img: img10,
      name: "Google Pay и Apple Pay",
      description:
        "Pay for orders using Google Pay and Apple Pay. It's safe and convenient.",
    },
  ],
];

export const AboutDelivery = () => {
  return (
    <div className="about-delivery-wrapper">
      <h1 id="about-delivery">About Delivery</h1>
      <h5 className="delivery-benefit">Delivery terms</h5>
      <section className="about-delivery-items">
        {items[0].map((item: IAboutDeliveryItem, index: number) => (
          <AboutDeliveryItem
            key={index}
            img={item.img}
            name={item.name}
            description={item.description}
          />
        ))}
      </section>
      <h5 className="delivery-benefit">Orders types</h5>
      <section className="about-delivery-items">
        {items[1].map((item: IAboutDeliveryItem, index: number) => (
          <AboutDeliveryItem
            key={index}
            img={item.img}
            name={item.name}
            description={item.description}
          />
        ))}
      </section>

      <h5 className="delivery-benefit">Convenient payment</h5>
      <section className="about-delivery-items">
        {items[2].map((item: IAboutDeliveryItem, index: number) => (
          <AboutDeliveryItem
            key={index}
            img={item.img}
            name={item.name}
            description={item.description}
          />
        ))}
      </section>
    </div>
  );
};

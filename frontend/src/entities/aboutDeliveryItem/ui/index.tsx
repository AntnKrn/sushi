import React from "react";
import "./index.scss";

interface IPropsAboutDeliveryItem {
  img: string;
  name: string;
  description: string;
}

export const AboutDeliveryItem = ({
  img,
  name,
  description,
}: IPropsAboutDeliveryItem) => {
  return (
    <div className="about-delivery-item">
      <img src={img} alt={name} />
      <h3>{name}</h3>
      <p>{description}</p>
    </div>
  );
};

import React from "react";
import "./index.scss";

export const BlogItem = () => {
  return (
    <div className="blog-item">
      <a href="www.google.com">
        <img width={250} height={200} />
      </a>

      <a className="blog-item-name" href="www.google.com">
        Скидка на первый заказ
      </a>
      <p className="blog-item-date">12/12/2012</p>
      <p className="blog-item-description">
        Попробуйте новое меню, представленное в ресторане. Наши повара собрали
        все лучшее, что может дать японская кухня. Именно японская кухня
        отличается предпочтением натуральных…
      </p>
      <a className="info-blog-btn" href="www.google.com">
        Узнать подробнее
      </a>
    </div>
  );
};

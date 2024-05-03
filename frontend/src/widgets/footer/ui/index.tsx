import React from "react";
import { Logo } from "../../../shared/ui/icons/logo";
import facebook from "./facebook.svg";
import { Facebook } from "../../../shared/ui/icons/facebook/facebook";
import "./index.scss";

export const Footer = () => {
  return (
    <footer>
      <div className="footer-column-flex">
        <div className="footer-logo">
          <Logo />
        </div>
        <div className="social-media">
          <Facebook />
          <Facebook />
          <Facebook />
          <Facebook />
          <Facebook />
        </div>
        <div className="footer-info">
          <div className="footer-column-item">
            <a>Меню</a>
            <a>О доставке</a>
            <a>Новости и акции</a>
            <a>Блог</a>
            <a>Контакты</a>
          </div>
          <div className="footer-column-item desc">
            <p className="delivery-description">
              Доставка суши — онлайн сервис заказа суши и других блюд в Минске.
            </p>
            <p>Прием заказов: c 10:00 до 4:45</p>
            <a>+7 (495) 111-11-11</a>
            <a>site@t.demowildbiz.ru</a>
          </div>
          <div className="footer-column-item">
            <a>Согласие на обработку данных</a>
            <a>Политика конфиденциальности</a>
          </div>
        </div>
        <p id="all-rights">Все права все права</p>
      </div>
    </footer>
  );
};

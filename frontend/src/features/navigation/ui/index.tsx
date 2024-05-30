import React, { useState } from "react";

import "./index.scss";
import { BusketIcon } from "./busket";
import { Account } from "../../../shared/ui/icons/account";
import { Authorization } from "../../../widgets/authorization";
import { useSelector } from "react-redux";
import { RootState } from "../../../shared/store/store";

export const Navigation = () => {
  const [isMenuOpen, setIsMenuOpen] = useState<boolean>(false);
  const count = useSelector((state: RootState) => state.counter.value);

  const onClickMenuHandler = () => {
    setIsMenuOpen((prev) => !prev);
    const menu = document.getElementById("nav-menu");
    if (menu) {
      if (isMenuOpen) {
        menu.style.left = "-100%";
      }
      if (!isMenuOpen) {
        menu.style.left = "0";
      }
    }
  };
  return (
    <nav style={{ margin: 0 }}>
      <ul id="nav-menu">
        <li>
          <a href="/products">MENU</a>
        </li>
        <li>
          <a href="/delivery">ABOUT DELIVERY</a>
        </li>
        <li>
          <a href="/blog">BLOG</a>
        </li>
        <li>
          <a href="/contacts">CONTACTS</a>
        </li>
        <li id="busket">
          <a href="/busket">
            <BusketIcon count={count} />
          </a>
        </li>
        <li id="account">
          <a href={document.cookie === "" ? "/authorization" : "/account"}>
            <Account />
          </a>
        </li>
      </ul>

      <div onClick={() => onClickMenuHandler()} id="mobile_btn">
        {isMenuOpen ? <p>X</p> : <p>MENU</p>}
      </div>
    </nav>
  );
};

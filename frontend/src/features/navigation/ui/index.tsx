import React, { useState } from "react";

import "./index.scss";
import { BusketIcon } from "./busket";
import { Account } from "../../../shared/ui/icons/account";
import { Authorization } from "../../../widgets/authorization";

export const Navigation = () => {
  const [isClosedAuth, setIsClosedAuth] = useState<boolean>(false);
  const [isMenuOpen, setIsMenuOpen] = useState<boolean>(false);

  const closeOpenAuthWindow = () => {
    setIsClosedAuth((prev) => !prev);
    console.log(isClosedAuth);
  };
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
  console.log(isMenuOpen);
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
            <BusketIcon />
          </a>
        </li>
        <li id="account">
          <div>
            {document.cookie !== "" ? (
              <a href="/account">
                <Account onClickAccount={closeOpenAuthWindow} />
              </a>
            ) : isClosedAuth ? (
              <Authorization onClose={closeOpenAuthWindow} />
            ) : (
              <Account onClickAccount={closeOpenAuthWindow} />
            )}
          </div>
        </li>
      </ul>

      <div onClick={() => onClickMenuHandler()} id="mobile_btn">
        {isMenuOpen ? <p>Close</p> : <p>Menu</p>}
      </div>
    </nav>
  );
};

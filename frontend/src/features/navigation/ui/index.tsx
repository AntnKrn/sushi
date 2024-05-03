import React, { useState } from "react";

import "./index.scss";
import { BusketIcon } from "./busket";
import { Account } from "../../../shared/ui/icons/account";
import { Authorization } from "../../../widgets/authorization";

export const Navigation = () => {
  const [isClosedAuth, setIsClosedAuth] = useState<boolean>(false);

  const closeOpenAuthWindow = () => {
    setIsClosedAuth((prev) => !prev);
    console.log(isClosedAuth);
  };
  return (
    <nav>
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
          <Account onClickAccount={closeOpenAuthWindow} />
          {isClosedAuth ? (
            <Authorization onClose={closeOpenAuthWindow} />
          ) : null}
        </div>
      </li>
    </nav>
  );
};

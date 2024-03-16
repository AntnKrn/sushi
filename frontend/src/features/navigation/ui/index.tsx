import React from "react";

import "./index.scss";
import { BusketIcon } from "./busket";

export const Navigation = () => {
  return (
    <nav>
      <li>
        <a href="/">MENU</a>
      </li>
      <li>
        <a href="/products">ABOUT DELIVERY</a>
      </li>
      <li>
        <a href="/news">NEWS AND SAILES</a>
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
    </nav>
  );
};

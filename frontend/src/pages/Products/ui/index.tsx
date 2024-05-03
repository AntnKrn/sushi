import React, { useEffect, useState } from "react";

import { Header } from "../../../widgets/header";
import "./ProductsPage.scss";
import { Footer } from "../../../widgets/footer";
import { ScrollMenu } from "../../../widgets/scrollMenu";
import { Menu } from "../../../widgets/menu";
import { MenuList } from "../../../widgets/menuList/ui";
import { MenuItemsList } from "../../../widgets/menuItemsList/ui";
import { IMenu, search } from "../../../shared/api";

export const ProductsPage = () => {
  const [response, setResponse] = useState<IMenu[]>([]);
  const [type, setType] = useState<string>("");

  useEffect(() => {
    const param = window.location.search;
    setType(param);
    (async function () {
      const result = await search(`menu${param}`);
      if (typeof result === "string") {
        console.log("error");
      } else if (Array.isArray(result.data)) {
        setResponse(result.data);
      }
    })();
    console.log(response);
  }, []);

  return (
    <div>
      <Header />
      <ScrollMenu />
      <MenuItemsList data={response} />
      <Footer />
    </div>
  );
};

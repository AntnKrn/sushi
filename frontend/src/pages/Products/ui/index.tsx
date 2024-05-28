import React, { useEffect, useState } from "react";

import { Header } from "../../../widgets/header";
import "./ProductsPage.scss";
import { Footer } from "../../../widgets/footer";
import { ScrollMenu } from "../../../widgets/scrollMenu";
import { MenuItemsList } from "../../../widgets/menuItemsList/ui";
import { IMenu } from "../../../shared/interfaces/IMenu";
import { search } from "../../../shared/api/menu";

export const ProductsPage = () => {
  const [response, setResponse] = useState<IMenu[]>([]);

  useEffect(() => {
    const param = window.location.search;
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

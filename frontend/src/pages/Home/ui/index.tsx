import React from "react";

import { Header } from "../../../widgets/header";
import { News } from "../../../widgets/news";
import { ScrollMenu } from "../../../widgets/scrollMenu";
import { Menu } from "../../../widgets/menu";
import { Footer } from "../../../widgets/footer";
import { search } from "../../../shared/api/menu";

export const HomePage = () => {
  return (
    <div>
      <Header />
      <News />
      <ScrollMenu />
      <Menu />
      <Footer />
    </div>
  );
};

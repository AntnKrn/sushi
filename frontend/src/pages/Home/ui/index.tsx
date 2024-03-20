import React from "react";

import { Header } from "../../../widgets/header";
import { News } from "../../../widgets/news";
import { ScrollMenu } from "../../../widgets/scrollMenu";

export const HomePage = () => {
  return (
    <div>
      <Header />
      <News />
      <ScrollMenu />
    </div>
  );
};

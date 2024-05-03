import React from "react";

import "./index.scss";
import { ScrollMenuItem } from "../../../entities/scrollMenuItem";

import img2 from "./sous.png";
import img3 from "./supy.png";
import img4 from "./rolly.png";
import img5 from "./napitki.png";
import img6 from "./sashimi.png";
import img7 from "./sushi.png";

export const ScrollMenu = () => {
  const arrayImages: Array<Array<string>> = [
    [img2, "Соусы", "?Type=souces"],
    [img3, "Супы", "?Type=soups"],
    [img4, "Роллы", "?Type=rolls"],
    [img5, "Напитки", "?Type=drinks"],
    [img6, "Сашими", "?Type=sashimi"],
    [img7, "Суши", "?Type=sushi"],
  ];

  return (
    <div className="wrapper-scroll">
      <div className="scroll-menu">
        {arrayImages.map((el, index) => (
          <ScrollMenuItem
            key={index}
            image={
              <a href={el[2]}>
                <img
                  className="scroll-menu-img"
                  src={el[0]}
                  width="65px"
                  height="65px"
                />
              </a>
            }
            name={el[1]}
            index={index}
          />
        ))}
      </div>
    </div>
  );
};

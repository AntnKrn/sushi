import React from "react";

import "./index.scss";
import { ScrollMenuItem } from "../../../entities/scrollMenuItem";

import img2 from "./scrollImg2.jpg";
import img3 from "./scrollImg3.jpg";
import img4 from "./scrollImg4.jpg";

export const ScrollMenu = () => {
  const arrayImages: string[] = [img2, img3, img4, img2, img3, img4];

  return (
    <div className="wrapper-scroll">
      <div className="scroll-menu">
        {arrayImages.map((el, index) => (
          <ScrollMenuItem
            image={
              <img
                className="scroll-menu-img"
                src={el}
                width="65px"
                height="65px"
              />
            }
            name="суши"
            index={index}
          />
        ))}
      </div>
    </div>
  );
};

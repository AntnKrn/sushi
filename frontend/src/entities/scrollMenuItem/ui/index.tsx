import react from "react";
import img from "./scrollImg.jpg";

import "./index.scss";

interface Props {
  image?: JSX.Element;
  name: string;
  index: number;
}

export const ScrollMenuItem = ({ image, name, index }: Props) => {
  return (
    <div className="scrollMenuItem" key={index}>
      {image}
      {/* <img src={img} width="65px" height="65px" /> */}
      <h6
        className="scrollMenuItemName"
        style={{
          textAlign: "center",
          margin: 0,
        }}
      >
        {name}
      </h6>
    </div>
  );
};

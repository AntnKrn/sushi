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
      <p
        className="scrollMenuItemName"
        style={{
          textAlign: "center",
          margin: "0",
          position: "sticky",
          top: "0",
        }}
      >
        {name}
      </p>
    </div>
  );
};

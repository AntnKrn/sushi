import React, { useEffect, useState } from "react";

import "./index.scss";

import img1 from "./img1.jpg";
import img2 from "./img2.jpg";
import img3 from "./img3.jpg";
import img4 from "./img4.jpg";
import img5 from "./img6.jpg";

export const News = () => {
  const imagesUrls: string[] = [img1, img2, img3, img4, img5];

  const [imageIndex, setImageIndex] = useState(0);

  useEffect(() => {
    const toggle = setInterval(() => {
      setImageIndex((index) => {
        if (index === imagesUrls.length - 1) return 0;
        return index + 1;
      });
    }, 4000);

    return () => clearInterval(toggle);
  });

  const showNextImage = () => {
    setImageIndex((index) => {
      if (index === imagesUrls.length - 1) return 0;
      return index + 1;
    });
  };

  const showPrevImage = () => {
    setImageIndex((index) => {
      if (index === 0) return imagesUrls.length - 1;
      return index - 1;
    });
  };

  return (
    <div style={{ position: "relative" }}>
      <div className="news-wrapper">
        <img src={imagesUrls[imageIndex]} className="img-slider" />
        <button
          onClick={showPrevImage}
          className="img-slider-btn"
          style={{ left: 0 }}
        >
          Prev
        </button>
        <button
          onClick={showNextImage}
          className="img-slider-btn"
          style={{ right: 0 }}
        >
          Next
        </button>
      </div>
    </div>
  );
};

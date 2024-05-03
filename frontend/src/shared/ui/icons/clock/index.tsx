import React from "react";
import "./index.scss";

export const Clock = () => {
  return (
    <svg
      width="800px"
      height="800px"
      viewBox="0 0 64 64"
      xmlns="http://www.w3.org/2000/svg"
      fill="none"
      stroke="#000000"
      className="contact-icon"
    >
      <circle cx="32" cy="32" r="24" />
      <polyline points="40 44 32 32 32 16" />
    </svg>
  );
};

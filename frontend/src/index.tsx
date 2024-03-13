import React from "react";
import ReactDOM from "react-dom/client";
import App from "./App/App";
import { RouterProvider } from "react-router-dom";
import { router } from "./pages";

const root = ReactDOM.createRoot(
  document.getElementById("root") as HTMLElement
);

root.render(<App />);

import React from "react";

import "./App.scss";
import { RouterProvider } from "react-router-dom";
import { router } from "../pages";

const App = () => {
  return <RouterProvider router={router}></RouterProvider>;
};

export default App;

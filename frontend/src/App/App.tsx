import React from "react";

import "./App.scss";
import { RouterProvider } from "react-router-dom";
import { Provider } from "react-redux";
import { store } from "../shared/store/store";
import { router } from "../pages";

const App = () => {
  return (
    <Provider store={store}>
      <RouterProvider router={router}></RouterProvider>
    </Provider>
  );
};

export default App;

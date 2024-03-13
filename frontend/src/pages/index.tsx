import { createBrowserRouter } from "react-router-dom";

import { ProductsPage } from "./Products";
import { BusketPage } from "./Busket/ui";
import App from "../App/App";

export const router = createBrowserRouter([
  {
    path: "/products",
    element: <ProductsPage />,
  },
  {
    path: "/busket",
    element: <BusketPage />,
  },
]);

import { createBrowserRouter } from "react-router-dom";

import { ProductsPage } from "./Products";
import { BusketPage } from "./Busket";
import { HomePage } from "./Home";

export const router = createBrowserRouter([
  {
    path: "/",
    element: <HomePage />
  },
  {
    path: "/products",
    element: <ProductsPage />,
  },
  {
    path: "/busket",
    element: <BusketPage />,
  },
]);
